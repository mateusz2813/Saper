using System;
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
    public partial class HighscoresForm : Form
    {
        private Tuple<int, ListViewItem> para(int i, ListViewItem s)
        {
            return new Tuple<int, ListViewItem>(i, s);
        }

        public HighscoresForm()
        {
            InitializeComponent();

            if (Logika.Wyniki == null)
                return;

            //zaladuj wyniki
            var lista = new List<Tuple<int, ListViewItem>>();

            foreach (var i in Logika.Wyniki)
                lista.Add(para(i.Czas, i.item()));

            //posortuj wedlug czasu
            lista.Sort((a, b) => a.Item1.CompareTo(b.Item1));

            //dodaj kolejno wyniki
            foreach (var i in lista)
                this.listView1.Items.Add(i.Item2);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
