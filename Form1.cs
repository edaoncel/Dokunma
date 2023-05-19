using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dokunmaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("kaldınız");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("kaldınız");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("kaldınız");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("kaldınız");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("kazandınız");
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("hile yaptınız");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
