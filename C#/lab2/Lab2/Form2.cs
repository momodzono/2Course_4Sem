using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    partial class Form2 : Form
    {
        Owner ow = new Owner();
        public static List<Owner> owners = new List<Owner>();

        private readonly System.Windows.Forms.TextBox form;
        public Form2(System.Windows.Forms.TextBox form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ow.name = textBox1.Text;
        }

        private void DateTimePicker1_Leave(object sender, EventArgs e)
        {
            ow.birthDay = Convert.ToString(dateTimePicker1.Value.Day + "." + dateTimePicker1.Value.Month + "." + dateTimePicker1.Value.Year);
            ow.birthDay = dateTimePicker1.Text;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //приводим отправителя к элементу типа radioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton1.Checked == true)
            {
                ow.sex = Convert.ToString(radioButton1.Text);
                ow.sex = radioButton1.ToString();
            }
            if (radioButton1.Checked == false)
            {
                ow.sex = Convert.ToString(radioButton2.Text);
                ow.sex = radioButton2.ToString();
            }
        }

        private void RadioButton1_Leave(object sender, EventArgs e)
        {
            ow.sex = radioButton1.Text;
        }

        private void RadioButton2_Leave(object sender, EventArgs e)
        {
            ow.sex = radioButton2.Text;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            ow.passport = textBox2.Text;
        }

        private void DateTimePicker2_Leave(object sender, EventArgs e)
        {
            ow.date = Convert.ToString(dateTimePicker2.Value.Day + "." + dateTimePicker2.Value.Month + "." + dateTimePicker2.Value.Year);
            ow.date = dateTimePicker2.Text;
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            ow.vydan = textBox3.Text;
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            ow.adress = textBox4.Text;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            string input = textBox5.Text;
            string pattern = "[^0-9]"; // регулярное выражение для поиска всех символов, кроме цифр
            string replacement = ""; // заменяем найденные символы на пустую строку
            string result = Regex.Replace(input, pattern, replacement);
            textBox5.Text = result;
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                ow.numbt = Convert.ToInt32(textBox5.Text);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля!", "Ошибка");
            }

            else
            {
                owners.Add(ow);
                //ow.returnDefaultValue();

                this.form.Text += ow.ToString();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                radioButton1.Text = "Муж.";
                radioButton2.Text = "Жен.";
            }
        }

    }
}
