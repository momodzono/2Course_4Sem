namespace Lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Владелец";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 1;
            textBox1.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "ФИО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 3;
            label3.Text = "Дата рождения:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Leave += DateTimePicker1_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
            label4.TabIndex = 5;
            label4.Text = "Паспортные данные:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 256);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 6;
            label5.Text = "Номер паспорта:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 7;
            textBox2.Leave += textBox2_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 308);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 8;
            label6.Text = "Дата выдачи:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(128, 303);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 27);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Leave += DateTimePicker2_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 361);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 10;
            label7.Text = "Кем был выдан:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 361);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 11;
            textBox3.Leave += TextBox3_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 172);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 12;
            label8.Text = "Пол:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(58, 172);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Муж.";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton1.Leave += RadioButton1_Leave;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(128, 172);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Жен.";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.Leave += RadioButton2_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 420);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 15;
            label9.Text = "Адрес прописки:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 469);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 16;
            label10.Text = "Номер телфона:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 417);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 27);
            textBox4.TabIndex = 17;
            textBox4.Leave += TextBox4_Leave;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 469);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 27);
            textBox5.TabIndex = 18;
            textBox5.TextChanged += TextBox5_TextChanged;
            textBox5.Leave += TextBox5_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(128, 519);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 569);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}