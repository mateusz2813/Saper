﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PwSG__Lab3
{
    [Serializable]
    public class Wygrana
    {
        //w xml serializacja tylko publicznych WLASCIWOSCI
        public string Ksywka { get; set; }
        public int Czas { get; set; }
        public string Rozmiar { get; set; }

        public Wygrana(string Ksywka, int Czas, string Rozmiar)
        {
            this.Ksywka = Ksywka;
            this.Czas = Czas;
            this.Rozmiar = Rozmiar;
        }

        public Wygrana() { }

        public ListViewItem item()
        {
            return new ListViewItem(new string[] { Ksywka, Czas.ToString(), Rozmiar });
        }
    }

    public partial class AddNewScoreDialog : Form
    {
        private int _czas;

        public AddNewScoreDialog()
        {
            InitializeComponent();
            _czas = (int)(DateTime.Now - Logika.Czas).TotalSeconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj nowy wynik do listy
            string ksywka = textBox1.Text;
            string rozmiar = Logika.Wiersze.ToString() + "x" + Logika.Kolumny.ToString();
            Wygrana w = new Wygrana(ksywka, this._czas, rozmiar);

            if(Logika.Wyniki==null)
                Logika.Wyniki=new List<Wygrana>();

            Logika.Wyniki.Add(w);

            Properties.Ustawienia.Default.Save();
            Properties.Ustawienia.Default.Reload();
            
            this.Close();
        }

        private void AddNewScoreDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            HighscoresForm dlg1 = new HighscoresForm();
            dlg1.Show();
        }
    }
}
