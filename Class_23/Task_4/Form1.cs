using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        string gender; string exp; string graphic; string info; string category;
        public Form1()
        {
            InitializeComponent();

            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day);
            }
            string[] months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }
            for (int age = 1990; age <= 2010; age++)
            {
                comboBox3.Items.Add(age);
            }
            string[] places = new string[] { "Гродно", "Витебск", "Могилев", "Брест", "Минск", "Гомель" };

            foreach (string place in places)
            {
                comboBox4.Items.Add(place);
            }
            string[] mobs = new string[] { "МТС", "Билайн", "МегаФон", "А1", "life :)" };

            foreach (string mob in mobs)
            {
                comboBox5.Items.Add(mob);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "ФИО: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\r\nПол: " + $"{gender}" + "\r\nДата рождения: " + " День: " + comboBox1.Text + " Месяц: " + comboBox2.Text + " Год: " + comboBox3.Text + "\r\nМесто проживания: " + comboBox4.Text + "\r\nАдрес электронной почты: " + textBox4.Text + "\r\nМобильный телефон: " + comboBox5.Text + " " + textBox5.Text + "\r\nОпыт работы: " + $"{exp}" + "Объем заработной платы: От " + numericUpDown1.Value + " До " + numericUpDown2.Value + "\r\nПредпочтительный график работы: " + $"{graphic}" + "\r\nДругие сведения: " + $"{info}" + "\r\nКатегория прав: " + $"{category}.";
            textBox6.Text = output.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                exp = radioButton4.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                exp = radioButton3.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                exp = radioButton5.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                exp = radioButton6.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                exp = radioButton7.Text;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                graphic = radioButton9.Text;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                graphic = radioButton8.Text;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                graphic = radioButton10.Text;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                graphic = radioButton11.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                info += checkBox1.Text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                info += checkBox2.Text;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                category += checkBox3.Text;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                category += checkBox4.Text;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                category += checkBox5.Text;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                category += checkBox6.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = null;
        }
    }
}
