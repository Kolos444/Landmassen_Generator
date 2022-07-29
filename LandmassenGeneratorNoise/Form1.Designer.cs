namespace LandmassenGeneratorNoise{
	partial class Form1{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)){
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panelControll          = new System.Windows.Forms.Panel();
			this.drawCover              = new System.Windows.Forms.Button();
			this.numericUpDownFrequenzy = new System.Windows.Forms.NumericUpDown();
			this.labelFrequenzy         = new System.Windows.Forms.Label();
			this.buttonClose            = new System.Windows.Forms.Button();
			this.labelSeed              = new System.Windows.Forms.Label();
			this.textBoxSeed            = new System.Windows.Forms.TextBox();
			this.labelHeight            = new System.Windows.Forms.Label();
			this.textBoxHeight          = new System.Windows.Forms.TextBox();
			this.labelWidth             = new System.Windows.Forms.Label();
			this.textBoxWidth           = new System.Windows.Forms.TextBox();
			this.buttonGenerate         = new System.Windows.Forms.Button();
			this.panelPicture           = new System.Windows.Forms.Panel();
			this.pictureBox1            = new System.Windows.Forms.PictureBox();
			this.panelControll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequenzy)).BeginInit();
			this.panelPicture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();

			//
			// panelControll
			//
			this.panelControll.Controls.Add(this.drawCover);
			this.panelControll.Controls.Add(this.numericUpDownFrequenzy);
			this.panelControll.Controls.Add(this.labelFrequenzy);
			this.panelControll.Controls.Add(this.buttonClose);
			this.panelControll.Controls.Add(this.labelSeed);
			this.panelControll.Controls.Add(this.textBoxSeed);
			this.panelControll.Controls.Add(this.labelHeight);
			this.panelControll.Controls.Add(this.textBoxHeight);
			this.panelControll.Controls.Add(this.labelWidth);
			this.panelControll.Controls.Add(this.textBoxWidth);
			this.panelControll.Controls.Add(this.buttonGenerate);
			this.panelControll.Dock     = System.Windows.Forms.DockStyle.Left;
			this.panelControll.Location = new System.Drawing.Point(0, 0);
			this.panelControll.Name     = "panelControll";
			this.panelControll.Size     = new System.Drawing.Size(100, 1080);
			this.panelControll.TabIndex = 0;

			//
			// drawCover
			//
			this.drawCover.Location                =  new System.Drawing.Point(-1, 998);
			this.drawCover.Name                    =  "drawCover";
			this.drawCover.Size                    =  new System.Drawing.Size(101, 41);
			this.drawCover.TabIndex                =  11;
			this.drawCover.Text                    =  "Draw Cover";
			this.drawCover.UseVisualStyleBackColor =  true;
			this.drawCover.Click                   += new System.EventHandler(this.drawCover_Click);

			//
			// numericUpDownFrequenzy
			//
			this.numericUpDownFrequenzy.DecimalPlaces = 6;
			this.numericUpDownFrequenzy.Increment     = new decimal(new int[] { 5, 0, 0, 262144 });
			this.numericUpDownFrequenzy.Location      = new System.Drawing.Point(0, 240);
			this.numericUpDownFrequenzy.Maximum       = new decimal(new int[] { 10, 0, 0, 65536 });
			this.numericUpDownFrequenzy.Name          = "numericUpDownFrequenzy";
			this.numericUpDownFrequenzy.Size          = new System.Drawing.Size(99, 20);
			this.numericUpDownFrequenzy.TabIndex      = 10;
			this.numericUpDownFrequenzy.Value         = new decimal(new int[] { 7, 0, 0, 196608 });

			//
			// labelFrequenzy
			//
			this.labelFrequenzy.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFrequenzy.Location  = new System.Drawing.Point(0, 207);
			this.labelFrequenzy.Name      = "labelFrequenzy";
			this.labelFrequenzy.Size      = new System.Drawing.Size(99, 22);
			this.labelFrequenzy.TabIndex  = 9;
			this.labelFrequenzy.Text      = "Frequenzy";
			this.labelFrequenzy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			//
			// buttonClose
			//
			this.buttonClose.Location                =  new System.Drawing.Point(0, 1045);
			this.buttonClose.Name                    =  "buttonClose";
			this.buttonClose.Size                    =  new System.Drawing.Size(100, 35);
			this.buttonClose.TabIndex                =  7;
			this.buttonClose.Text                    =  "Close";
			this.buttonClose.UseVisualStyleBackColor =  true;
			this.buttonClose.Click                   += new System.EventHandler(this.buttonDraw_Click_1);

			//
			// labelSeed
			//
			this.labelSeed.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSeed.Location  = new System.Drawing.Point(1, 150);
			this.labelSeed.Name      = "labelSeed";
			this.labelSeed.Size      = new System.Drawing.Size(99, 22);
			this.labelSeed.TabIndex  = 6;
			this.labelSeed.Text      = " Seed";
			this.labelSeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			//
			// textBoxSeed
			//
			this.textBoxSeed.Location = new System.Drawing.Point(0, 175);
			this.textBoxSeed.Name     = "textBoxSeed";
			this.textBoxSeed.Size     = new System.Drawing.Size(100, 20);
			this.textBoxSeed.TabIndex = 5;
			this.textBoxSeed.Text     = " 256";

			//
			// labelHeight
			//
			this.labelHeight.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHeight.Location  = new System.Drawing.Point(0, 102);
			this.labelHeight.Name      = "labelHeight";
			this.labelHeight.Size      = new System.Drawing.Size(99, 22);
			this.labelHeight.TabIndex  = 4;
			this.labelHeight.Text      = "Height";
			this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			//
			// textBoxHeight
			//
			this.textBoxHeight.Location = new System.Drawing.Point(-1, 127);
			this.textBoxHeight.Name     = "textBoxHeight";
			this.textBoxHeight.Size     = new System.Drawing.Size(100, 20);
			this.textBoxHeight.TabIndex = 3;
			this.textBoxHeight.Text     = "1080";

			//
			// labelWidth
			//
			this.labelWidth.Font      = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWidth.Location  = new System.Drawing.Point(-2, 41);
			this.labelWidth.Name      = "labelWidth";
			this.labelWidth.Size      = new System.Drawing.Size(99, 22);
			this.labelWidth.TabIndex  = 2;
			this.labelWidth.Text      = "Width";
			this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			//
			// textBoxWidth
			//
			this.textBoxWidth.Location = new System.Drawing.Point(-3, 66);
			this.textBoxWidth.Name     = "textBoxWidth";
			this.textBoxWidth.Size     = new System.Drawing.Size(100, 20);
			this.textBoxWidth.TabIndex = 1;
			this.textBoxWidth.Text     = "1820";

			//
			// buttonGenerate
			//
			this.buttonGenerate.Location                =  new System.Drawing.Point(0, 0);
			this.buttonGenerate.Name                    =  "buttonGenerate";
			this.buttonGenerate.Size                    =  new System.Drawing.Size(100, 35);
			this.buttonGenerate.TabIndex                =  0;
			this.buttonGenerate.Text                    =  "Generate";
			this.buttonGenerate.UseVisualStyleBackColor =  true;
			this.buttonGenerate.Click                   += new System.EventHandler(this.buttonDraw_Click);

			//
			// panelPicture
			//
			this.panelPicture.Controls.Add(this.pictureBox1);
			this.panelPicture.Dock     = System.Windows.Forms.DockStyle.Fill;
			this.panelPicture.Location = new System.Drawing.Point(100, 0);
			this.panelPicture.Name     = "panelPicture";
			this.panelPicture.Size     = new System.Drawing.Size(1820, 1080);
			this.panelPicture.TabIndex = 1;

			//
			// pictureBox1
			//
			this.pictureBox1.Dock     = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name     = "pictureBox1";
			this.pictureBox1.Size     = new System.Drawing.Size(1820, 1080);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop  = false;

			//
			// Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor           = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize          = new System.Drawing.Size(1920, 1080);
			this.Controls.Add(this.panelPicture);
			this.Controls.Add(this.panelControll);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name            = "Form1";
			this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text            = "Landmassen Generator Perlin Noise";
			this.WindowState     = System.Windows.Forms.FormWindowState.Maximized;
			this.panelControll.ResumeLayout(false);
			this.panelControll.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequenzy)).EndInit();
			this.panelPicture.ResumeLayout(false);
			this.panelPicture.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button drawCover;

		private System.Windows.Forms.NumericUpDown numericUpDownFrequenzy;

		private System.Windows.Forms.TrackBar trackBar1;

		private System.Windows.Forms.Label   labelFrequenzy;

		private System.Windows.Forms.Button buttonClose;

		private System.Windows.Forms.Label labelSeed;

		private System.Windows.Forms.TextBox textBoxSeed;

		private System.Windows.Forms.PictureBox pictureBox1;

		private System.Windows.Forms.Panel panelPicture;

		private System.Windows.Forms.Label   labelHeight;
		private System.Windows.Forms.TextBox textBoxHeight;

		private System.Windows.Forms.TextBox textBoxWidth;
		private System.Windows.Forms.Label   labelWidth;

		private System.Windows.Forms.Button buttonGenerate;

		private System.Windows.Forms.Panel panelControll;

		#endregion
	}
}