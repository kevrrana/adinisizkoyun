using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adinisizkoyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarHesaplama_Click(object sender, EventArgs e)
        {
            double satisfiyati, alisfiyati, toplamkar;
            alisfiyati = Convert.ToDouble(txtAlisFiyati.Text);
            satisfiyati = Convert.ToDouble(txtSatisFiyati.Text);

            toplamkar = satisfiyati - alisfiyati;
            lblToplamKar.Text = "Toplam Kar: " + toplamkar;
        }
    }
}
