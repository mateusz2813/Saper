using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _PwSG__Lab3
{
    public partial class UstawieniaDialog : Form
    {
        public UstawieniaDialog()
        {
            InitializeComponent();

            this.numericUpDown1.Value = Logika.Wiersze;
            this.numericUpDown2.Value=Logika.Kolumny;
            this.trackBar1.Value = Logika.Prawdopodobienstwo;
            this.setBombaImage.ErrorImage = this.setBombaImage.InitialImage;
            this.setFlagImage.ErrorImage = this.setFlagImage.InitialImage;
            aktualizujObrazy();
        }

        private void aktualizujObrazy()
        {
            bool wynik = true;

            if (Logika.ObrazBomba != "")
            {
                this.setBombaImage.LoadAsync(Logika.ObrazBomba);
                wynik = this.setBombaImage.Image.Equals(this.setBombaImage.ErrorImage);
            }
            else
                this.setBombaImage.Image = this.setBombaImage.InitialImage;

            if (Logika.ObrazFlaga != "")
            {
                this.setFlagImage.LoadAsync(Logika.ObrazFlaga);
                wynik = wynik && (this.setFlagImage.Image.Equals(this.setFlagImage.ErrorImage));
            }
            else 
                this.setFlagImage.Image = this.setFlagImage.InitialImage;

            if (!wynik)
                MessageBox.Show("Coś poszło nie tak...", "Ostrzeżenie");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logika.Wiersze = (int)this.numericUpDown1.Value;
            Logika.Kolumny = (int)this.numericUpDown2.Value;
            Logika.Prawdopodobienstwo = (int)this.trackBar1.Value;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color=Logika.KolorBomba;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Logika.KolorBomba = dialog.Color;
            Logika.ObrazBomba = "";
            aktualizujObrazy();
        }

        private void wybierzFlageButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Logika.KolorFlaga;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Logika.KolorFlaga = dialog.Color;
            Logika.ObrazFlaga = "";
            aktualizujObrazy();
        }

        private void wybierzBezpieczneButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Logika.KolorBezpieczne;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Logika.KolorBezpieczne = dialog.Color;
        }

        private void wybierzNieodkryteButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Logika.KolorNieodkryte;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Logika.KolorNieodkryte = dialog.Color;
        }

        private void setBombaImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Logika.ObrazBomba = openFileDialog1.FileName;
            aktualizujObrazy();

        }

        private void setFlagImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Logika.ObrazFlaga = openFileDialog1.FileName;
            aktualizujObrazy();

        }
    }
}
