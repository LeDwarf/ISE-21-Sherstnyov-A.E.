using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxPassengers;
        int weight;

        private ITransport inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            maxSpeed = 150;
            maxPassengers = 4;
            weight = 1500;
            button1.BackColor = color;
            button1.BackColor = dopColor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button1.BackColor = color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button2.BackColor = dopColor;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxMaxSpeed.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBoxPassengers.Text, out maxPassengers))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }


        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveCat(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Boat(maxSpeed, maxPassengers, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawCat(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Cat(maxSpeed, maxPassengers, weight, color, checkBox1.Checked, checkBox2.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawCat(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

