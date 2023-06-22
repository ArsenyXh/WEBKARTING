using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form10().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form9().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }
    }
}
