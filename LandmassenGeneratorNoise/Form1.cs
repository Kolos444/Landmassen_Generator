using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LandmassenGeneratorNoise{
	public partial class Form1 : Form{
		private Dictionary<KeyValuePair<string, Color>, float[]> _bioms;
		private Map                                              map;

		public Form1() {
			WriteData();
			getBioms();

			InitializeComponent();
		}

		private void getBioms() {
			StreamReader fileStream = new StreamReader(new FileStream(
														   AppDomain.CurrentDomain.BaseDirectory + "/biomData.json",
														   FileMode.Open));
			string readToEnd = fileStream.ReadToEnd();
			_bioms = JsonSerializer.Deserialize<Dictionary<KeyValuePair<string, Color>, float[]>>(readToEnd);
			fileStream.Close();
		}


		private void buttonDraw_Click(object sender, EventArgs e) {
			map = new Map(Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text),
						  Convert.ToInt32(textBoxSeed.Text), (float)numericUpDownFrequenzy.Value);
			pictureBox1.Image = map.getBitmap();
		}

		private void buttonDraw_Click_1(object sender, EventArgs e) {
			Application.Exit();
		}

		private void WriteData() {
			Dictionary<KeyValuePair<string, Color>, float[]> bioms =
				new Dictionary<KeyValuePair<string, Color>, float[]>();

			bioms.Add(new KeyValuePair<string, Color>("Deep Ocean", Color.DarkBlue), new[] { 0.0f, 0.1f, 0.0f, 1.0f });
			bioms.Add(new KeyValuePair<string, Color>("Ocean", Color.Blue), new[] { 0.1f, 0.2f, 0.0f, 1.0f });
			bioms.Add(new KeyValuePair<string, Color>("Shoreline", Color.Aqua), new[] { 0.2f, 0.22f, 0.0f, 1.0f });
			bioms.Add(new KeyValuePair<string, Color>("Beach", Color.Aqua), new[] { 0.22f, 0.24f, 0.0f, 1.0f });
			bioms.Add(new KeyValuePair<string, Color>("Desert", Color.SandyBrown), new[] { 0.24f, 0.4f, 0.0f, 0.1f });
			bioms.Add(new KeyValuePair<string, Color>("Savannah", Color.Goldenrod), new[] { 0.24f, 0.4f, 0.1f, 0.2f });
			bioms.Add(new KeyValuePair<string, Color>("Grasslands", Color.Green), new[] { 0.24f, 0.4f, 0.2f, 0.3f });
			bioms.Add(new KeyValuePair<string, Color>("Hills", Color.SaddleBrown), new[] { 0.4f, 0.5f, 0.0f, 0.3f });

			Dictionary<string, float[]> data       = new Dictionary<string, float[]>(bioms.Count);
			JsonSerializerOptions       jsonOption = new JsonSerializerOptions { WriteIndented = true };


			foreach (KeyValuePair<KeyValuePair<string, Color>, float[]> keyValuePair in bioms){
				string serialize = JsonSerializer.Serialize(keyValuePair.Key, jsonOption);


				data.Add(serialize, keyValuePair.Value);
				Console.WriteLine(serialize);
			}

			FileStream fileStream =
				new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/biomData.json", FileMode.Create);
			string       a      = JsonSerializer.Serialize(data, jsonOption);
			StreamWriter writer = new StreamWriter(fileStream);
			a = a.Replace(@"\r\n", Environment.NewLine);
			writer.Write(a.Replace(@"\u0022", "\""));
			writer.Flush();
			writer.Close();
			fileStream.Close();
		}

		private void drawCover_Click(object sender, EventArgs e) {
			int    size  = pictureBox1.Width < pictureBox1.Height ? pictureBox1.Width : pictureBox1.Height;
			Bitmap chart = new Bitmap(size, size);

			foreach (KeyValuePair<KeyValuePair<string, Color>, float[]> biom in _bioms){
				for (int x = (int)(biom.Value[2] * size); x < biom.Value[3] * size; x++){
					for (int y = (int)(biom.Value[0] * size); y < biom.Value[1] * size; y++){
						chart.SetPixel(x, y * -1 + size - 1, biom.Key.Value);
					}
				}
			}

			pictureBox1.Image = chart;
		}
	}
}