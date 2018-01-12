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
    public partial class Form2 : Form
    {
        ITransport cat = null;
        public ITransport getCat { get { return cat; } }

        private void drawCat()
        {
            if (cat != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                cat.setPosition(5, 5);
                cat.drawCat(gr);
                pictureBox1.Image = bmp;
            }
        }

        private event myDel eventAddCat;
        public void AddEvent(myDel ev)
        {
            if (eventAddCat == null)
            {
                eventAddCat = new myDel(ev);
            }
            else
            {
                eventAddCat += ev;
            }
        }

        public Form2()
        {
            InitializeComponent();
            panelC1.MouseDown += panelColor_MouseDown;
            panelC2.MouseDown += panelColor_MouseDown;
            panelC3.MouseDown += panelColor_MouseDown;
            panelC4.MouseDown += panelColor_MouseDown;
            panelC5.MouseDown += panelColor_MouseDown;
            panelC6.MouseDown += panelColor_MouseDown;
            panelC7.MouseDown += panelColor_MouseDown;
            panelC8.MouseDown += panelColor_MouseDown;

            buttonReset.Click += (object sender, EventArgs e) => { Close(); };
        }       

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            { 
                case "Boat":
                    cat = new Boat(100, 4, 500, Color.White);
                    break;
                case "Cat":
                    cat = new Cat(100, 4, 500, Color.White, true, true, Color.Black);
                    break;
            }
            drawCat();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelC1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelC1_DragDrop(object sender, DragEventArgs e)
        {
            if (cat != null)
            {
                cat.setMainColor((Color)e.Data.GetData(typeof(Color)));
                drawCat();
            }
        }

        private void labelC2_DragDrop(object sender, DragEventArgs e)
        {
            if (cat != null)
            {
                if (cat is Cat)
                {
                    (cat as Cat).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    drawCat();
                }
            }
        }


        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(eventAddCat != null)
            {
                eventAddCat(cat);
            }
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
