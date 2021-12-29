using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arabaclasss
{
    public partial class Form1 : Form
    {
        Araba a = new Araba();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.marka =textBox1.Text;
            a.model = textBox2.Text;
            a.plaka = textBox3.Text;
            a.yil =  dateTimePicker1.Value.Year;
            listBox1.Items.Add(a.marka+"  "+a.model+"   "+a.plaka+"    "+a.yil);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.hizartti();
            MessageBox.Show("Hızınız:" +a.hiz);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.hizazalt();
            MessageBox.Show("Hızınız:" + a.hiz);
        }

    }
}
