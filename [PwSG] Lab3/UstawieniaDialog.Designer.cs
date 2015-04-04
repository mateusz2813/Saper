namespace _PwSG__Lab3
{
    partial class UstawieniaDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wybierzBombeButton = new System.Windows.Forms.Button();
            this.wybierzFlageButton = new System.Windows.Forms.Button();
            this.wybierzBezpieczneButton = new System.Windows.Forms.Button();
            this.wybierzNieodkryteButton = new System.Windows.Forms.Button();
            this.setBombaImage = new System.Windows.Forms.PictureBox();
            this.setFlagImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBombaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setFlagImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wierszy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kolumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prawdopodobieństwo bomby";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(196, 189);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(119, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(196, 37);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bomba";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Flaga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Odkryte pole bezpieczne";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pole nieodkryte";
            // 
            // wybierzBombeButton
            // 
            this.wybierzBombeButton.Location = new System.Drawing.Point(196, 63);
            this.wybierzBombeButton.Name = "wybierzBombeButton";
            this.wybierzBombeButton.Size = new System.Drawing.Size(121, 23);
            this.wybierzBombeButton.TabIndex = 11;
            this.wybierzBombeButton.Text = "ustaw kolor";
            this.wybierzBombeButton.UseVisualStyleBackColor = true;
            this.wybierzBombeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // wybierzFlageButton
            // 
            this.wybierzFlageButton.Location = new System.Drawing.Point(196, 91);
            this.wybierzFlageButton.Name = "wybierzFlageButton";
            this.wybierzFlageButton.Size = new System.Drawing.Size(120, 23);
            this.wybierzFlageButton.TabIndex = 12;
            this.wybierzFlageButton.Text = "ustaw kolor";
            this.wybierzFlageButton.UseVisualStyleBackColor = true;
            this.wybierzFlageButton.Click += new System.EventHandler(this.wybierzFlageButton_Click);
            // 
            // wybierzBezpieczneButton
            // 
            this.wybierzBezpieczneButton.Location = new System.Drawing.Point(197, 120);
            this.wybierzBezpieczneButton.Name = "wybierzBezpieczneButton";
            this.wybierzBezpieczneButton.Size = new System.Drawing.Size(120, 24);
            this.wybierzBezpieczneButton.TabIndex = 13;
            this.wybierzBezpieczneButton.Text = "ustaw kolor";
            this.wybierzBezpieczneButton.UseVisualStyleBackColor = true;
            this.wybierzBezpieczneButton.Click += new System.EventHandler(this.wybierzBezpieczneButton_Click);
            // 
            // wybierzNieodkryteButton
            // 
            this.wybierzNieodkryteButton.Location = new System.Drawing.Point(197, 151);
            this.wybierzNieodkryteButton.Name = "wybierzNieodkryteButton";
            this.wybierzNieodkryteButton.Size = new System.Drawing.Size(120, 23);
            this.wybierzNieodkryteButton.TabIndex = 14;
            this.wybierzNieodkryteButton.Text = "ustaw kolor";
            this.wybierzNieodkryteButton.UseVisualStyleBackColor = true;
            this.wybierzNieodkryteButton.Click += new System.EventHandler(this.wybierzNieodkryteButton_Click);
            // 
            // setBombaImage
            // 
            this.setBombaImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setBombaImage.Location = new System.Drawing.Point(162, 63);
            this.setBombaImage.Name = "setBombaImage";
            this.setBombaImage.Size = new System.Drawing.Size(28, 22);
            this.setBombaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setBombaImage.TabIndex = 15;
            this.setBombaImage.TabStop = false;
            this.setBombaImage.Click += new System.EventHandler(this.setBombaImage_Click);
            // 
            // setFlagImage
            // 
            this.setFlagImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setFlagImage.Location = new System.Drawing.Point(162, 92);
            this.setFlagImage.Name = "setFlagImage";
            this.setFlagImage.Size = new System.Drawing.Size(28, 22);
            this.setFlagImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setFlagImage.TabIndex = 16;
            this.setFlagImage.TabStop = false;
            this.setFlagImage.Click += new System.EventHandler(this.setFlagImage_Click);
            // 
            // UstawieniaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 279);
            this.Controls.Add(this.setFlagImage);
            this.Controls.Add(this.setBombaImage);
            this.Controls.Add(this.wybierzNieodkryteButton);
            this.Controls.Add(this.wybierzBezpieczneButton);
            this.Controls.Add(this.wybierzFlageButton);
            this.Controls.Add(this.wybierzBombeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UstawieniaDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.Ustawienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBombaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setFlagImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button wybierzBombeButton;
        private System.Windows.Forms.Button wybierzFlageButton;
        private System.Windows.Forms.Button wybierzBezpieczneButton;
        private System.Windows.Forms.Button wybierzNieodkryteButton;
        private System.Windows.Forms.PictureBox setBombaImage;
        private System.Windows.Forms.PictureBox setFlagImage;
    }
}