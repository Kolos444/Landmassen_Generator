using System.Collections.Generic;
using System.Drawing;

namespace LandmassenGeneratorNoise{
	internal class Map{
		private readonly int height;

		private readonly int     width;
		private          float   frequenzy;
		private          float[] heightMap, bioms;
		private          int     seed;

		public Map(int width, int height, int seed = 256, float frequenzy = 1f) {
			this.width     = width;
			this.height    = height;
			this.seed      = seed;
			this.frequenzy = frequenzy;
			createArrays(width, height, seed, frequenzy);
		}


		public Map(int width = 128, int seed = 256, float frequenzy = 1f) {
			this.width     = width;
			height         = width;
			this.seed      = seed;
			this.frequenzy = frequenzy;
			createArrays(width, width, seed, frequenzy);
		}

		private void createArrays(int width, int height, int seed, float frequency) {
			heightMap = new float[width * height];

			bioms = new float[width * height];

			FastNoiseLite noise = new FastNoiseLite(seed);
			noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);
			noise.SetFrequency(frequency);
			noise.SetFractalOctaves(5);
			noise.SetFractalLacunarity(2);
			noise.SetFractalGain(0.5f);
			noise.SetFractalWeightedStrength(1);

			int index = 0;
			for (int x = 0; x < width; x++){
				for (int y = 0; y < height; y++){
					heightMap[index++] = (noise.GetNoise(x, y) + 1) / 2;
				}
			}

			noise.SetFrequency(frequency / 1.5f);

			index = 0;
			for (int x = width; x < width * 2; x++){
				for (int y = height; y < height * 2; y++){
					bioms[index++] = (noise.GetNoise(x, y) + 1) / 2;
				}
			}
		}


		public Bitmap getBitmap() {

			Bitmap bitmap = new Bitmap(width, height);

			int index = 0;
			for (int x = 0; x < width; x++){
				for (int y = 0; y < height; y++){
					int pixelHeight = (int)(heightMap[index] * 256);
					int biomValue   = (int)(bioms[index++]   * 256);
					bitmap.SetPixel(x, y, Color.FromArgb(pixelHeight, pixelHeight, pixelHeight));
				}
			}

			return bitmap;
		}

		private KeyValuePair<Color, float>[] GetBioms() {
			return null;
		}
	}
}