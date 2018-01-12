using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Salad
{
    public partial class Form1 : Form
    {
        private Papper[] pappers;
        private Salt salt;
        private WaterTap waterTap;
        private Knife knife;
        private Pan pan;
        private Stove stove;
        private Tomato_Sauce[] sauce;

        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
        }
        private void ButtonPapperAdd_Click(object sender, EventArgs e)
        {


            if (pappers == null)
            {
                Papper t = new Papper();


                pappers = new Papper[Convert.ToInt32(numericUpDown1.Value)];
                for (int i = 0; i < Convert.ToInt32(numericUpDown1.Value); i++)
                {

                    pappers[i] = new Papper();
                }

                MessageBox.Show("Перец взяли", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Перец уже есть", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < pappers.Length; ++i)
            {
                if (pappers[i].Dirty > 0)
                {
                    MessageBox.Show("Забыли помыть перец", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pappers[i].Havent_Cut)
                {
                    MessageBox.Show("Забыли порезать перец", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Можно поджарить перец", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonSaltAdd_Click(object sender, EventArgs e)
        {
            Salt salt = new Salt();
            salt.CountSalt = Convert.ToInt32(numericUpDown2.Value);
            if (salt.CountSalt > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Соль взяли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сколько соли добавить? Забыли указать!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonSauceAdd_Click(object sender, EventArgs e)
        {

            if (sauce == null)
            {
                Tomato_Sauce t = new Tomato_Sauce();
                sauce = new Tomato_Sauce[Convert.ToInt32(numericUpDown2.Value)];



                for (int i = 0; i < Convert.ToInt32(numericUpDown2.Value); i++)
                {
                    sauce[i] = new Tomato_Sauce();
                }

                MessageBox.Show("Томатный соус взяли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Соус уже есть", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }
        }



        private void ButtonWash_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value > 0)

            {

                if (!waterTap.State)

                {

                    MessageBox.Show("Кран закрыт, воды нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }

                pappers = new Papper[Convert.ToInt32(numericUpDown1.Value)];

                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));

                for (int i = 0; i < pappers.Length; ++i)

                {

                    pappers[i] = new Papper();

                }

                for (int i = 0; i < pappers.Length; ++i)

                {

                    pappers[i].Dirty = 0;

                }

                numericUpDown1.Enabled = false;

                radioButton2.Checked = true;

                MessageBox.Show("Перцы помыли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {

                MessageBox.Show("Нет перца, мыть нечего", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {
            if (pappers == null)
            {
                MessageBox.Show("Нет перца, резать нечего", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pappers.Length == 0)
            {
                MessageBox.Show("Нет перца, резать нечего", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < pappers.Length; ++i)
            {
                if (pappers[i].Dirty > 0)
                {
                    MessageBox.Show("Забыли помыть перец", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < pappers.Length; ++i)
            {
                knife.Cut(pappers[i]);
            }

            MessageBox.Show("Порезали перец", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonCook_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            if (!pan.ReadyToGo)
            {
                MessageBox.Show("Что то забыли сделать, перец жарить рано", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Плита выключена, жарить не на чем", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pan.IsReady() == false)
                stove.Cook();
            if (stove.Pan.IsReady())
            {
                ButtonGetRez.Enabled = true;
                MessageBox.Show("Пожарили!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Салат не получился", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButtonGetRez_Click(object sender, EventArgs e)
        {
            pappers = pan.GetSalad();
            MessageBox.Show("Немного остынет, и можно подавать! Хороший салат!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BowlSalt_Click(object sender, EventArgs e)
        {

            pan.AddSalt(salt);

            MessageBox.Show("Добавили соль", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BowlSauce_Click(object sender, EventArgs e)
        {
            if (sauce == null)
            {
                MessageBox.Show("Томатного соуса нет, добавить нечего", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sauce.Length == 0)
            {
                MessageBox.Show("Томатного соуса нет, добавить нечего", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < sauce.Length; ++i)
            {
                pan.AddSauce(sauce[i]);
            }
            MessageBox.Show("Томатный соус на сковороде", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BowlPapper_Click(object sender, EventArgs e)
        {
            if (pappers == null)
            {
                MessageBox.Show("Сколько перца добавить? Забыли указать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pappers.Length == 0)
            {
                MessageBox.Show("Сколько перца добавить? Забыли указать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < pappers.Length; ++i)
            {
                if (pappers[i].Dirty > 0)
                {
                    MessageBox.Show("Перец забыли помыть", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < pappers.Length; ++i)
            {
                if (pappers[i].Havent_Cut)
                {
                    MessageBox.Show("Забыли порезать перец", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < pappers.Length; ++i)
            {
                pan.AddPappers(pappers[i]);
            }
            MessageBox.Show("Перец на сковороде", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = !stove.State;
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Плита включена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonCook.Enabled = true;
            }
            else MessageBox.Show("Плита выключена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pappers.Length; ++i)
            {
                pappers[i].Mixed = true;
            }
            MessageBox.Show("Перемешали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
