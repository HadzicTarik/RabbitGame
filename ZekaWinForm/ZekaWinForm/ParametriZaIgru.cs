using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZekaWinForm
{
    public partial class ParametriZaIgru : Form
    {
        public ParametriZaIgru()
        {
            InitializeComponent();
            lblTitle.Location = new Point(this.Width/2 - lblTitle.Width/2, 15);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int unosDimenzijaMatrice, unosTrajanjaIgre;
            bool proveraDimenzijaMatrice = int.TryParse(tbDimenzijeMatrice.Text, out unosDimenzijaMatrice);
            bool proveraTrajanjaIgre = int.TryParse(tbVrijemeTrajanjaIgre.Text, out unosTrajanjaIgre);
            if((proveraDimenzijaMatrice == true) && (proveraTrajanjaIgre == true))
            {
                RabitGame rabitGame = new RabitGame(unosDimenzijaMatrice, unosTrajanjaIgre);
                rabitGame.ShowDialog();

                tbDimenzijeMatrice.Clear();
                tbVrijemeTrajanjaIgre.Clear();
                tbDimenzijeMatrice.Focus();
            }
            else
            {
                MessageBox.Show("Greška! Polja ne smiju biti prazna i moraju biti cijeli brojevi");
                tbDimenzijeMatrice.Clear();
                tbVrijemeTrajanjaIgre.Clear();
                tbDimenzijeMatrice.Focus();
            }
        }
    }
}
