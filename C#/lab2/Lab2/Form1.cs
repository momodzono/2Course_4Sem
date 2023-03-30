using Microsoft.VisualBasic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab2
{
    partial class Form1 : Form
    {
        public static List<Bank> bank = new List<Bank>();
        double progressValue = 14.3;
        int progressBarMaxValue = 100;
        bool numb = true, type = true, dateopen = true, msm = true, inter = true, balan = true, click = true;

        [DllImport(".dll")]
        static extern void Bank_SelectedIndexChanged(IntPtr hMnd);

        public Bank newBank = new Bank();
        Owner ow = new();
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = newBank.ToString();
            using (StreamWriter ms = new StreamWriter("DataBase.txt", false)) { }

            
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxNum.Text;
            string pattern = "[^0-9]"; // регулярное выражение для поиска всех символов, кроме цифр
            string replacement = ""; // заменяем найденные символы на пустую строку
            string result = Regex.Replace(input, pattern, replacement);
            textBoxNum.Text = result;

            if (textBoxNum.Text.Length > 0 && numb)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                numb = false;
                chekBar();
            }

            if (textBoxNum.Text.Length == 0 && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                numb = true;
            }
        }

        private void chekBar()
        {
            if (progressBar1.Value >= 96)
            {
                progressBar1.Value = 100;
            }   
        }

        private void textBoxNum_Leave(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "")
            {
                progressBar1.Text = newBank.ToString();
            }

            else
            {
                if (Convert.ToInt64(textBoxNum.Text) > int.MaxValue)
                {
                    MessageBox.Show("Слишком большое значение для номера", "Ошибка");
                }
                else
                {
                    newBank.num = Convert.ToInt32(textBoxNum.Text);
                    progressBar1.Text = newBank.ToString();
                }
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            Bank_SelectedIndexChanged(textBox3.Handle);
            ButSave.Focus();
        }

        private void comboBoxType_Leave(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "")
            {
                textBox3.Text = newBank.ToString();
                if (progressBar1.Value != 0) progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                type = true;
                chekBar();
            }
            else
            {
                if (comboBoxType.Text == "Срочный") newBank.type_ = Bank.type.Срочный;
                if (comboBoxType.Text == "Накопительный") newBank.type_ = Bank.type.Накопительный;
                if (comboBoxType.Text == "Сберегательный") newBank.type_ = Bank.type.Сберегательный;
                if (comboBoxType.Text == "До_востребования") newBank.type_ = Bank.type.До_востребования;

                textBox3.Text = newBank.ToString();
            }
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text.Length > 0 && type)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                type = false;
                chekBar();
            }

            if (comboBoxType.Text == "" && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                type = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text.Length > 0 && dateopen)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                dateopen = false;
                chekBar();
            }

            if (dateTimePicker1.Text == "" && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                dateopen = true;
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            newBank.DateofOpen = Convert.ToString(dateTimePicker1.Value.Day + "." + dateTimePicker1.Value.Month + "." + dateTimePicker1.Value.Year);
            textBox3.Text = newBank.ToString();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //приводим отправителя к элементу типа radioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton1.Checked == true) 
            {
                newBank.sms = Convert.ToString(radioButton1.Text);
                textBox3.Text = newBank.ToString();
            }
            if(radioButton1.Checked == false)
            {
                newBank.sms = Convert.ToString(radioButton2.Text);
                textBox3.Text = newBank.ToString();
            }
        }
        private void RadioButton1_Leave(object sender, EventArgs e)
        {
            if (radioButton1.Text.Length > 0 && msm)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                msm = false;
                chekBar();
            }

            if (radioButton1.Text.Length == 0 && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                msm = true;
            }
        }

        private void RadioButton2_Leave(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && msm)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                msm = false;
                chekBar();
            }

            if (radioButton2.Text.Length == 0 && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                msm = true;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && click)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                click = false;
                chekBar();
            }

            if (checkBox1.Text == "" && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                click = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // Проверка, что элемент выбран
            {

                string selectedItem = listBox1.SelectedItem.ToString(); // Получение выбранного элемента
                                                                           // Действия, которые необходимо выполнить при выборе элемента
                if (selectedItem == "Включено") newBank.intern = Bank.internet.Включено;
                if (selectedItem == "Выключено") newBank.intern = Bank.internet.Выключено;

                textBox3.Text = newBank.ToString();
            }

            else
            {
                textBox3.Text = newBank.ToString();
            }

            if (listBox1.Text.Length > 0 && inter)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                inter = false;
                chekBar();
            }

            if (listBox1.Text == "" && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                inter = true;
            }
        }

        private void Balans_TextChanged(object sender, EventArgs e)
        {
            string input = Balans.Text;
            string pattern = "[^0-9]"; // регулярное выражение для поиска всех символов, кроме цифр
            string replacement = ""; // заменяем найденные символы на пустую строку
            string result = Regex.Replace(input, pattern, replacement);
            Balans.Text = result;

            if (Balans.Text.Length > 0 && balan)
            {
                progressBar1.Value += (int)(progressValue / (double)progressBarMaxValue * 100);
                balan = false;
                chekBar();
            }

            if (Balans.Text.Length == 0 && progressBar1.Value != 0)
            {
                progressBar1.Value -= (int)(progressValue / (double)progressBarMaxValue * 100);
                balan = true;
            }
        }

        private void Balans_Leave(object sender, EventArgs e)
        {
            if (Balans.Text == "")
            {
                textBox3.Text = newBank.ToString();
            }

            else
            {
                if (Convert.ToInt64(Balans.Text) > int.MaxValue)
                {
                    MessageBox.Show("Слишком большое значение для Баланса", "Ошибка");
                }
                else
                {
                    newBank.balans = Convert.ToInt32(Balans.Text);
                    textBox3.Text = newBank.ToString();
                }
            }
        }

        private void ButSer_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new(typeof(Bank));
            newBank.owners = Form2.owners;
            using (FileStream fs = new("Bank.xml", FileMode.OpenOrCreate))
            {
                newBank.owners = Form2.owners;
                xmlSerializer.Serialize(fs, newBank);
            }
        }

        private void ButDeser_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new(typeof(Bank));
            using (FileStream fs = new("Bank.xml", FileMode.Open))
            {
                Bank newBan = (Bank)serializer.Deserialize(fs);
                MessageBox.Show(newBan.ToString(), "Информация");
            }
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                using (StreamWriter ms = new StreamWriter("DateBase.txt", true))
                {
                    newBank.owners = Form2.owners;
                    ms.WriteLine(newBank.ToString());
                    ms.WriteLine("--------------------------------------------");
                }
                MessageBox.Show("Информация сохранена!", "Сообщение");

                foreach (Control control in this.Controls)
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                        textBox.Text = "";
                    }

                    if (control is System.Windows.Forms.ComboBox Comb)
                    {
                        Comb.Text = "";
                    }

                    if (control is System.Windows.Forms.ListBox)
                    {
                        System.Windows.Forms.ListBox lb = (System.Windows.Forms.ListBox)control;
                        lb.Text = "";
                    }
                }

                listBox1.Text = Convert.ToString(Bank.internet.Включено);
                dateTimePicker1.Value = DateTime.Now;
                newBank.owners = Form2.owners;
                Form2.owners.Clear();
                bank.Add(newBank);
                newBank.returnToTheDefaultValue();
                textBox3.Text = newBank.ToString();
            }

            else
            {
                MessageBox.Show("Вы не подтвердили соглашение с правилами!", "Ошибка");
            }
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    textBox.Text = "";
                }

                if (control is System.Windows.Forms.ComboBox Comb)
                {
                    Comb.Text = "";
                }

                if (control is System.Windows.Forms.ListBox)
                {
                    System.Windows.Forms.ListBox lb = (System.Windows.Forms.ListBox)control;
                    lb.Text = "";
                }
            }

            listBox1.Text = Convert.ToString(Bank.internet.Включено);
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            textBox3.Text = "";
        }

        private void ButOwner_Click(object sender, EventArgs e)
        {
            Form2 owners = new Form2(textBox3);
            owners.Show();
        }
    }
}