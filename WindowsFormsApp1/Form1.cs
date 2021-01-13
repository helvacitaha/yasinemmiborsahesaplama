using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float arapara,ilkpara;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "bitir")
            {
                float simdikiartisyuzde = Convert.ToSingle(textBox1.Text);
                arapara = arapara + (arapara / 100) * simdikiartisyuzde;
                
                
            }
            else
            {
                float kazanc = arapara - ilkpara;
                MessageBox.Show("Yasin Emminin Kazancı Tam Tamına " + kazanc + " Türk Lirası!!!"+Environment.NewLine+"Yasin Emminin Şu Anki Parası "+arapara+" Türk Lirası!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Text = " ";
            button2.Show();
            button1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ilkpara = Convert.ToSingle(textBox2.Text);
            arapara = ilkpara;
            button2.Hide();
            button1.Show();
        }
    }
}
