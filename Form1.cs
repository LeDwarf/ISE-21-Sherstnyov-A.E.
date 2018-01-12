﻿using System;
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
		Parking parking;
		public Form1()
		{
			InitializeComponent();
			parking = new Parking(5);
            for(int i = 1; i<6; i++)
            {
                listBox1.Items.Add("Уровень"+i);
            }
            listBox1.SelectedIndex = parking.getCurrentLevel;
			Draw();
		}



		private void Draw()
		{
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBox1.Image = bmp;
            }		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var cat = new Boat(100, 4, 1000, dialog.Color);
				int place = parking.PutCatInParking(cat);
				Draw();
				MessageBox.Show("Ваше место: " + place);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var cat = new Cat(100, 4, 1000, dialog.Color, true, true, dialogDop.Color);
					int place = parking.PutCatInParking(cat);
					Draw();
					MessageBox.Show("Ваше место: " + place);
				}
			}
		}

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    ITransport car = parking.GetCatInParking(Convert.ToInt32(maskedTextBox1.Text));
                    if (car != null)
                    {//если удалось забрать, то отрисовываем
                        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.setPosition(5, 5);
                        car.drawCat(gr);
                        pictureBox1.Image = bmp;
                        Draw();
                    }
                    else
                    {//иначесообщаемобэтом
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }
                }
            }
        }    

        private void button4_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }


    }
}

