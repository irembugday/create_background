using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int red;
            int green;
            int blue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(textBox1.Text);
            int green = Convert.ToInt32(textBox2.Text);
            int blue = Convert.ToInt32(textBox3.Text);

            this.BackColor = Color.FromArgb(red, green, blue);




        }
    }
}
