using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btcinfo
{
    public partial class SetInfo : Form
    {
        public SetInfo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.Default.a = textBox1.Text;
            config.Default.Save();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            config.Default.b = textBox2.Text;
            config.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            config.Default.c = textBox3.Text;
            config.Default.Save();
        }

    }
}
