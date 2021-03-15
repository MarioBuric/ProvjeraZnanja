using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buricMarioProvjeraZnanja
{
    public partial class Form1 : Form
    {
        public void upis()
        {
            foreach (Osoba covik in  Program.Ljudovi)
            {
                richTextBox1.AppendText(covik.ToString());

            }
            richTextBox1.Refresh();
        }
        List<Osoba> lista = new List<Osoba>();
        FormaUnos unos = new FormaUnos();


        public Form1(List<Osoba> listaOsoba)
        {
            InitializeComponent();
            this.lista = listaOsoba;
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            FormaUnos f2 = new FormaUnos();
            f2.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Program.Ljudovi.Clear();
            
        }
    }
}
