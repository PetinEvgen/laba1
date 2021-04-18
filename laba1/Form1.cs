using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        // Задаём переменные
        decimal proem;
        decimal summa, sp;
        decimal stena;
        decimal pol;
        decimal potolok;
        decimal a;
        decimal b;
        decimal h;
        int p=0;
        decimal p1, p2;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Есть проемы?";
            comboBox1.Items.AddRange(new string[] {"Нет","Да" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            numericUpDown1.Text = null;
            numericUpDown2.Text = null;
            numericUpDown3.Text = null;
            numericUpDown4.Text = null;
            numericUpDown5.Text = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void extBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Считываем переменные
            a = numericUpDown1.Value;
            b = numericUpDown2.Value;
            h = numericUpDown3.Value;
            p1 = numericUpDown4.Value;
            p2 = numericUpDown5.Value;


            if ((a > 0) & (b > 0) & (h > 0)) 
                {
                // Делаем расчёт площадей
                stena = 2 * (a + b) * h;
                pol = a * b;
                potolok = a * b;
                proem = p1 * p2;
                if (p == 1)
                {
                    // Итоговый расчёт с учётом проёмов
                    sp =(stena + pol + potolok) - proem;
                    label1.Text = string.Format("{0}  м2", stena);
                    label2.Text = string.Format("{0}  м2", potolok);
                    label3.Text = string.Format("{0}  м2", pol);
                    label8.Text = string.Format("{0}  м2", sp);
                    label16.Text = string.Format("{0}  м2", proem);
                }
                else if (p == 2)
                {
                    // Итоговый расчёт без учёта проёмов
                    summa = stena + pol + potolok;
                    label1.Text = string.Format("{0}  м2", stena);
                    label2.Text = string.Format("{0}  м2", potolok);
                    label3.Text = string.Format("{0}  м2", pol);
                    label8.Text = string.Format("{0}  м2", summa);
                }
                else if (p == 0)
                {
                    MessageBox.Show("Выберите ответ");
                }
            }
            else
            {
                MessageBox.Show("Заполненные не все поля");
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
            // Выбор ответа
                case "Есть проемы?":
                    break;

                case "Нет":
                    numericUpDown4.Visible = false;
                    numericUpDown5.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    p = 2;
                    break;
                case "Да":
                    numericUpDown4.Visible = true;
                    numericUpDown5.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    p = 1;
                   

                    break;
                default:
                   // MessageBox.Show("Выберите ответ 'есть ли проемы?'");
                    break;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}