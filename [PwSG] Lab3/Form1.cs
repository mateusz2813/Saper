using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _PwSG__Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Logika.MainForm = this;
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UstawieniaDialog dlg1 = new UstawieniaDialog();
            dlg1.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Czy jesteś pewien, że chcesz zakończyć?", "Potwierdzenie", MessageBoxButtons.OKCancel);

            if (result == System.Windows.Forms.DialogResult.Cancel)
                e.Cancel = true;
            else
                Properties.Ustawienia.Default.Save();
        }

        public void zaslonWszystkiePola()
        {
            for (int i = 0; i < Logika.Pola.Length; i++)
            {
                Logika.Pola[i].BackColor = Logika.KolorNieodkryte;
                Logika.Pola[i].Text = "";
                Logika.Pola[i].BackgroundImage = null;
            }
        }

        public void nowaPlansza()
        {
            //generowanie nowej gry
            if (Logika.Pola != null)
            {
                //niszczenie starej gry

                if (this.tableLayoutPanel1.ColumnCount == Logika.Kolumny 
                    && this.tableLayoutPanel1.RowCount == Logika.Wiersze)
                {
                    //taki sam rozmiar, wystarczy zaslonic pola i wygenerowac nowe wartosci
                    zaslonWszystkiePola();
                    return;
                }



                for (int i = 0; i < Logika.Pola.Length; i++)
                    this.tableLayoutPanel1.Controls.Remove(Logika.Pola[i]);
                
                Logika.Pola = null;

                this.tableLayoutPanel1.ColumnCount = 0;
                this.tableLayoutPanel1.RowCount = 0;
            }

            Logika.Pola = new Button[Logika.Kolumny * Logika.Wiersze];

            for (int i = this.tableLayoutPanel1.RowCount; i < Logika.Wiersze; i++)
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));

            for (int i = this.tableLayoutPanel1.ColumnCount; i < Logika.Kolumny; i++)
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            this.tableLayoutPanel1.ColumnCount = Logika.Kolumny;
            this.tableLayoutPanel1.RowCount = Logika.Wiersze;

            for (int i = 0; i < Logika.Wiersze * Logika.Kolumny; i++)
            {
                Logika.Pola[i] = new Button();
                Logika.Pola[i].BackColor = Logika.KolorNieodkryte;
                Logika.Pola[i].Name = i.ToString();
                Logika.Pola[i].Margin = System.Windows.Forms.Padding.Empty;

                Logika.Pola[i].Font = new Font(FontFamily.GenericSerif, 16, FontStyle.Bold);
                Logika.Pola[i].Visible = true;
                Logika.Pola[i].Size = new Size(int.MaxValue, int.MaxValue);

                Logika.Pola[i].MouseDown += PoleClick;
                this.tableLayoutPanel1.Controls.Add(Logika.Pola[i]);
                Logika.Pola[i].BackgroundImageLayout = ImageLayout.Stretch;
            }


        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nowaPlansza();

            Logika.WartosciPol = new Wartosci[Logika.Kolumny * Logika.Wiersze];
            Logika.OdkrytePole = new Widok[Logika.Kolumny * Logika.Wiersze];
            
            Random r = new Random();
            bool czyBylaBomba = false;
            for (int i = 0; i < Logika.Wiersze * Logika.Kolumny; i++)
            {          
                int wylosowana = r.Next(0, 10);
                if (wylosowana >= Logika.Prawdopodobienstwo)
                    Logika.WartosciPol[i] = Wartosci.PUSTE; //0 - nie ma bomby
                else
                {
                    Logika.WartosciPol[i] = Wartosci.BOMBA; //1 - bomba
                    czyBylaBomba = true;
                }

                Logika.OdkrytePole[i] = Widok.ZASLONIETE;
            }
            Logika.Zablokowana = false;

            Logika.Czas = DateTime.Now;

            if (!czyBylaBomba)
            {
                Logika.Zablokowana = true;
                AddNewScoreDialog dial = new AddNewScoreDialog();
                dial.Show();
            }
        }

        private bool czyFlagiNaBombach()
        {
            for (int i = 0; i < Logika.WartosciPol.Length; ++i)
            {
                if (Logika.WartosciPol[i] != Wartosci.BOMBA)
                    continue;

                if (Logika.OdkrytePole[i] != Widok.FLAGA)
                    return false;
            }

            return true;
        }

        public void PoleClick(object sender, EventArgs e)
        {
            if (Logika.Zablokowana == true)
                return;

            Button przycisk = (Button)sender;
            int numer = Int32.Parse(przycisk.Name);

            if (Logika.OdkrytePole[numer] == Widok.FLAGA)
            {
                if (e != EventArgs.Empty)
                {
                    MouseEventArgs me = (MouseEventArgs)e;
                    if (me.Button == MouseButtons.Right)
                    {
                        //zdejmowanie flagi
                        przycisk.Image = null;
                        przycisk.BackColor = Logika.KolorNieodkryte;
                        przycisk.Text = "";
                        Logika.OdkrytePole[numer] = Widok.ZASLONIETE;
                        return;
                    }
                }
            }

            if (Logika.OdkrytePole[numer] == Widok.ODSLONIETE)
                return;

            if (e != EventArgs.Empty)
            {
                MouseEventArgs me = (MouseEventArgs)e;

                if (me.Button == MouseButtons.Right)
                {
                    Logika.OdkrytePole[numer] = Widok.FLAGA;

                    try
                    {
                        przycisk.BackgroundImage = Image.FromFile(Logika.ObrazFlaga);
                        przycisk.Text = "";
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Coś poszło nie tak...", "Ostrzeżenie");
                        przycisk.Text = "!";
                        przycisk.BackColor = Logika.KolorFlaga;
                        przycisk.Font = new Font(FontFamily.GenericSerif, 7, FontStyle.Regular);
                    }

                    if (!Logika.ReadOnly && czyFlagiNaBombach())
                    {
                        //wygrana - to do!
                        Logika.Zablokowana = true;
                        AddNewScoreDialog dlg1 = new AddNewScoreDialog();
                        dlg1.Show();

                    }

                    return;
                }
            }


            Logika.OdkrytePole[numer] = Widok.ODSLONIETE;

            if (Logika.WartosciPol[numer] == Wartosci.BOMBA)
            {
                //trafiono na bombe!
                try
                {
                    przycisk.BackgroundImage = Image.FromFile(Logika.ObrazBomba);
                    przycisk.Text = "";
                }
                catch (Exception)
                {
                    //MessageBox.Show("Ostrzeżenie", "Coś poszło nie tak...");
                    przycisk.Text = "KABUM!";
                    przycisk.BackColor = Logika.KolorBomba;
                    przycisk.Font = new Font(FontFamily.GenericSerif, 7, FontStyle.Regular);
                }

                if (!Logika.ReadOnly)
                {
                    MessageBox.Show("Niestety - przegrałeś!", "Koniec gry");
                    Logika.Zablokowana = true;
                }

                return;
            }
            
            //nie trafiono na bombe
            int ilebomb = 0;

            int[] mozliweIndeksy;

            if (numer % Logika.Kolumny == 0)
            {
                //lezy skrajnie z lewej strony
                mozliweIndeksy = new int[] {
                                            numer - Logika.Kolumny,
                                            numer + Logika.Kolumny,
                                            numer + 1,
                                            numer + Logika.Kolumny + 1,
                                            numer - Logika.Kolumny + 1,
                                           };
            }
            else if ((numer + 1) % Logika.Kolumny == 0)
            {
                //lezy skrajnie z prawej strony
                mozliweIndeksy = new int[] {
                                            numer - Logika.Kolumny,
                                            numer + Logika.Kolumny,
                                            numer - 1,
                                            numer + Logika.Kolumny - 1,
                                            numer - Logika.Kolumny - 1,
                                       };
            }
            else
            {
                //lezy na srodku planszy
                mozliweIndeksy = new int[] {
                                            numer - Logika.Kolumny,
                                            numer + Logika.Kolumny,
                                            numer - 1,
                                            numer + 1,
                                            numer + Logika.Kolumny - 1,
                                            numer + Logika.Kolumny + 1,
                                            numer - Logika.Kolumny + 1,
                                            numer - Logika.Kolumny - 1,
                                       };

            }

            foreach (var indeks in mozliweIndeksy)
            {
                if (indeks >= 0 && indeks < Logika.WartosciPol.Length && Logika.WartosciPol[indeks] == Wartosci.BOMBA)
                    ilebomb++;
            }

            if (ilebomb > 0)
            {
                if (ilebomb == 1)
                    przycisk.ForeColor = Color.Blue;
                else if (ilebomb == 2)
                    przycisk.ForeColor = Color.Green;
                else if (ilebomb == 3)
                    przycisk.ForeColor = Color.Red;

                przycisk.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                przycisk.Text = ilebomb.ToString();
            }

            if (ilebomb == 0)
            {
                foreach (var indeks in mozliweIndeksy)
                {
                    if (indeks >= 0 && indeks < Logika.WartosciPol.Length)
                        PoleClick(Logika.Pola[indeks], EventArgs.Empty);
                }
            }

            przycisk.BackColor = Logika.KolorBezpieczne;

        }

        private void zapiszGręToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapisGry zapis = new ZapisGry();
            zapis.Zapisz();
        }

        private void wczytajGręToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapisGry zapis = new ZapisGry();
            zapis.Wczytaj();
        }

        private void najlepszeWynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighscoresForm dlg1 = new HighscoresForm();
            dlg1.Show();
        }
    }
}
