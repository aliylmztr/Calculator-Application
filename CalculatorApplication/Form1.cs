using System;
using System.Windows.Forms;
using Matematik;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        MatematikIslemleri matematikIslemleri = new MatematikIslemleri();
        public Form1()
        {
            InitializeComponent();
        }       

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);
            int toplam = matematikIslemleri.toplama(sayi1, sayi2);

            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_cikartma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);
            int cikartma = matematikIslemleri.cikartma(sayi1, sayi2);

            lbl_sonuc.Text = cikartma.ToString();
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);
            int carpma = matematikIslemleri.carpma(sayi1, sayi2);

            lbl_sonuc.Text = carpma.ToString();
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_sayi1.Text);
            double sayi2 = Convert.ToDouble(txt_sayi2.Text);
            double bolme = matematikIslemleri.bolme(sayi1, sayi2);

            lbl_sonuc.Text = bolme.ToString();
        }
    }
}
