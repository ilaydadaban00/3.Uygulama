using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2_uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte Sayi1, Sayi2;
            Sayi1=Convert.ToByte(txtSayi1.Text);
            Sayi2=Convert.ToByte(txtSayi2.Text);
            if (Sayi1 > Sayi2)
            {
                MessageBox.Show("1.Sayı 2. sayidan büyüktür.");
            }
            if(Sayi2 == Sayi1)
            {
                MessageBox.Show("sayılar birbirine eşittir.");
            }
            if (Sayi1 <Sayi2) ;
            {
                MessageBox.Show("2.Sayi 1.sayıdan büyüktür.");
            }
        }
    }
}
