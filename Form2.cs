using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KardeslerKuafor
{
    public partial class Form2 : Form
    {

       // public String sifre;

       /* public bool karsilastir(String sifre)
        {
            if (this.sifre == sifre)
                return true;
            else return false;
        }*/

        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (karsilastir(sifre) == true)
            {
                String sifre;
                sifre = textBox1.Text;
                if (sifre == "123")
                {
                    /*Form2 f2 = new Form2();
                    f2.Close();*/
                    yonArayuzu yon = new yonArayuzu();
                    yon.Show();
                    this.Hide();
                    this.Close();
                }

                else
                    MessageBox.Show("Şifre hatalı. Lütfen tekrar deneyiniz.");

                
                //f2.hide();

            }
           // else hataMesaji();
            
        }

        /*public void hataMesaji()
        {
            //text ciksin, hatalı sifre desin
        }*/

        /*private object GetTextBox1_TextChanged()
        {
            return GetTextBox1_TextChanged;
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Form2 f2 = new Form2();
            f2.Close();*/
            //f2.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
