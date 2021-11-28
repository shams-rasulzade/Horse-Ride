using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lehnetegelesen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int a1 =pictureBox1.Left, a2= pictureBox2.Left, a3= pictureBox3.Left;//soldan mesafeler
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int m1 = pictureBox1.Width, m2 = pictureBox2.Width, m3 = pictureBox3.Width;
            pictureBox1.Left += random.Next(5, 15);
            pictureBox2.Left += random.Next(5, 15);
            pictureBox3.Left += random.Next(5, 15);
            int finish = label5.Left;

            if (pictureBox1.Width + pictureBox1.Left > pictureBox2.Width + pictureBox2.Left && pictureBox1.Width + pictureBox1.Left> pictureBox3.Width + pictureBox3.Left)
            {
                label6.Text = "1. Rider is ahead";
            }

            if (pictureBox2.Width + pictureBox2.Left > pictureBox1.Width + pictureBox1.Left && pictureBox2.Width + pictureBox2.Left > pictureBox3.Width + pictureBox3.Left)
            {
                label6.Text = "2. Rider is ahead";
            }

            if (pictureBox3.Width + pictureBox3.Left > pictureBox2.Width + pictureBox2.Left && pictureBox3.Width + pictureBox3.Left > pictureBox2.Width + pictureBox2.Left)
            {
                label6.Text = "3. Rider is ahead";
            }

            if (pictureBox1.Width + pictureBox1.Left == pictureBox2.Width + pictureBox2.Left )
            {
                label6.Text = "1. and 2. Rider are draw";
            }

            if (pictureBox1.Width + pictureBox1.Left == pictureBox3.Width + pictureBox3.Left)
            {
                label6.Text = "1. and 3. Rider are draw";
            }

            if (pictureBox2.Width + pictureBox2.Left == pictureBox3.Width + pictureBox3.Left)
            {
                label6.Text = "3. and 2. Rider are draw";
            }

            if (pictureBox1.Width + pictureBox1.Left == pictureBox2.Width + pictureBox2.Left&& pictureBox1.Width + pictureBox1.Left == pictureBox3.Width + pictureBox3.Left&& pictureBox2.Width + pictureBox2.Left == pictureBox3.Width + pictureBox3.Left)
            {
                label6.Text = "All Riders are ahead";
            }

            if (pictureBox1.Width + pictureBox1.Left >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. Rider Win");
            }

            if (pictureBox2.Width + pictureBox2.Left >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. Rider Win");
            }

            if (pictureBox3.Width + pictureBox3.Left >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. Rider Win");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
