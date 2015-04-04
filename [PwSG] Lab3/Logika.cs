using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace _PwSG__Lab3
{
    public enum Wartosci
    {
        PUSTE,
        BOMBA,
    };

    public enum Widok
    {
        ZASLONIETE,
        ODSLONIETE,
        FLAGA
    };

    public static class Logika
    {
        public static bool Zablokowana { get; set; }
        public static bool ReadOnly { get; set; }
        public static DateTime Czas { get; set; }

        public static int Wiersze
        {
            get { return Properties.Ustawienia.Default.Wiersze;  }
            set { Properties.Ustawienia.Default.Wiersze = value;
            Properties.Ustawienia.Default.Save(); }
        }
        public static int Kolumny
        {
            get { return Properties.Ustawienia.Default.Kolumny; }
            set { Properties.Ustawienia.Default.Kolumny = value; Properties.Ustawienia.Default.Save(); }
        }
        public static int Prawdopodobienstwo
        {
            get { return Properties.Ustawienia.Default.Prawdopodobienstwo; }
            set { Properties.Ustawienia.Default.Prawdopodobienstwo = value; Properties.Ustawienia.Default.Save(); }
        }

        public static Color KolorBomba
        {
            get { return Properties.Ustawienia.Default.KolorBomba; }
            set { Properties.Ustawienia.Default.KolorBomba = value; Properties.Ustawienia.Default.Save(); }
        }
        public static Color KolorFlaga
        {
            get { return Properties.Ustawienia.Default.KolorFlaga; }
            set { Properties.Ustawienia.Default.KolorFlaga = value; Properties.Ustawienia.Default.Save(); }
        }
        public static Color KolorBezpieczne
        {
            get { return Properties.Ustawienia.Default.KolorBezpieczne; }
            set { Properties.Ustawienia.Default.KolorBezpieczne = value; Properties.Ustawienia.Default.Save(); }
        }
        public static Color KolorNieodkryte
        {
            get { return Properties.Ustawienia.Default.KolorNieodkryte; }
            set { Properties.Ustawienia.Default.KolorNieodkryte = value; Properties.Ustawienia.Default.Save(); }
        }

        public static string ObrazBomba
        {
            get { return Properties.Ustawienia.Default.ObrazBomba; }
            set { Properties.Ustawienia.Default.ObrazBomba = value; Properties.Ustawienia.Default.Save(); }
        }
        public static string ObrazFlaga
        {
            get { return Properties.Ustawienia.Default.ObrazFlaga; }
            set { Properties.Ustawienia.Default.ObrazFlaga = value; Properties.Ustawienia.Default.Save(); }
        }

        public static System.Collections.Generic.List<Wygrana> Wyniki
        {
            get { return Properties.HighScore.Default.Wyniki; }
            set { Properties.HighScore.Default.Wyniki = value; Properties.HighScore.Default.Save(); Properties.HighScore.Default.Reload(); }
        }

        public static Button[] Pola { get; set; }
        public static Wartosci[] WartosciPol { get; set; }
        public static Widok[] OdkrytePole { get; set; }


        public static Form1 MainForm { get; set; }

    }

    [Serializable]
    public class ZapisGry
    {
        private Wartosci[] _wartosciPol;
        private Widok[] _odkrytePole;
        private int _prawdopodobienstwo;
        private int _kolumny;
        private int _wiersze;
        private bool _zablokowana;
        private DateTime _czasRozpoczecia;
        private DateTime _czasZakonczenia;

        public ZapisGry()
        {
            this._wartosciPol = Logika.WartosciPol;
            this._odkrytePole = Logika.OdkrytePole;
            this._prawdopodobienstwo = Logika.Prawdopodobienstwo;
            this._wiersze = Logika.Wiersze;
            this._kolumny = Logika.Kolumny;
            this._zablokowana = Logika.Zablokowana;
        }

        public void Zapisz()
        {
            _czasRozpoczecia = Logika.Czas;
            _czasZakonczenia = DateTime.Now;

            if (_wartosciPol == null)
                return;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "Pliki (*.saper)|*.saper";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string fileName = saveFileDialog1.FileName;

            var formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public void Wczytaj()
        {
            Logika.Zablokowana = false;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Pliki (*.saper)|*.saper";

            string fileName;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            fileName = openFileDialog1.FileName;

            var formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            ZapisGry z = (ZapisGry) formatter.Deserialize(stream);
            stream.Close();


            if (Logika.Kolumny != z._kolumny || Logika.Wiersze != z._wiersze || Logika.Pola == null)
            {
                Logika.Kolumny = z._kolumny;
                Logika.Wiersze = z._wiersze;
                Logika.MainForm.nowaPlansza();
            }
            else
                Logika.MainForm.zaslonWszystkiePola();

            Logika.Prawdopodobienstwo = z._prawdopodobienstwo;

            Logika.OdkrytePole = z._odkrytePole;
            Logika.WartosciPol = z._wartosciPol;

            if (z._zablokowana)
                Logika.ReadOnly = true;

            for (int i = 0; i < Logika.OdkrytePole.Length; ++i)
            {
                if (Logika.OdkrytePole[i] == Widok.ODSLONIETE)
                {
                    Logika.OdkrytePole[i] = Widok.ZASLONIETE;
                    Logika.MainForm.PoleClick(Logika.Pola[i], EventArgs.Empty);
                }
                else if (Logika.OdkrytePole[i] == Widok.FLAGA)
                {
                    Logika.OdkrytePole[i] = Widok.ZASLONIETE;
                    var mouse = new MouseEventArgs(MouseButtons.Right, 0, 0, 0, 0);
                    Logika.MainForm.PoleClick(Logika.Pola[i], mouse);
                }
            }

            Logika.ReadOnly = false;
            Logika.Zablokowana = z._zablokowana;

            if (Logika.Zablokowana)
                MessageBox.Show("Wygrana - wyłącznie odczyt, nie możesz zapisać wyniku!", "Koniec gry");

            Logika.Czas = DateTime.Now - (z._czasZakonczenia - z._czasRozpoczecia);         

        }

    }

}
