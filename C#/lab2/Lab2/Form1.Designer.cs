namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNum = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            comboBoxType = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            ButOwner = new Button();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            checkBox1 = new CheckBox();
            label8 = new Label();
            Balans = new TextBox();
            label9 = new Label();
            ButSave = new Button();
            ButClear = new Button();
            progressBar1 = new ProgressBar();
            label10 = new Label();
            textBox3 = new TextBox();
            ButSer = new Button();
            ButDeser = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(114, 34);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(151, 27);
            textBoxNum.TabIndex = 2;
            textBoxNum.TextChanged += textBoxNum_TextChanged;
            textBoxNum.Leave += textBoxNum_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Номер:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 116);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.Leave += dateTimePicker1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 4);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 5;
            label2.Text = "БАНК";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Тип вклада:";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Срочный", "Накопительный", "Сберегательный", "До_востребования" });
            comboBoxType.Location = new Point(114, 75);
            comboBoxType.Margin = new Padding(2, 2, 2, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 26;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            comboBoxType.Leave += comboBoxType_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 116);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "Дата открытия:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 160);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 9;
            label5.Text = "Владелец:";
            // 
            // ButOwner
            // 
            ButOwner.BackColor = SystemColors.ActiveCaption;
            ButOwner.Location = new Point(114, 156);
            ButOwner.Margin = new Padding(2);
            ButOwner.Name = "ButOwner";
            ButOwner.Size = new Size(151, 29);
            ButOwner.TabIndex = 10;
            ButOwner.Text = "Данные владельца";
            ButOwner.UseVisualStyleBackColor = true;
            ButOwner.Click += ButOwner_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 197);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 11;
            label6.Text = "СМС оповещение:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(164, 197);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Подключить";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton1.Leave += RadioButton1_Leave;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(164, 227);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(136, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Не подключать";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.Leave += RadioButton2_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 271);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 15;
            label7.Text = "Интернет-банкинг:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 381);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(281, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Я согласен с условиями услуг банка";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 318);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 17;
            label8.Text = "Баланс:";
            // 
            // Balans
            // 
            Balans.Location = new Point(80, 318);
            Balans.Name = "Balans";
            Balans.Size = new Size(125, 27);
            Balans.TabIndex = 18;
            Balans.TextChanged += Balans_TextChanged;
            Balans.Leave += Balans_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 348);
            label9.Name = "label9";
            label9.Size = new Size(311, 12);
            label9.TabIndex = 19;
            label9.Text = "Для активации счёта, его необходимо пополнить любой доступной суммой";
            // 
            // ButSave
            // 
            ButSave.Cursor = Cursors.Hand;
            ButSave.BackColor = Color.LimeGreen;
            ButSave.Location = new Point(19, 417);
            ButSave.Margin = new Padding(2, 2, 2, 2);
            ButSave.Name = "ButSave";
            ButSave.Size = new Size(107, 36);
            ButSave.TabIndex = 20;
            ButSave.Text = "Сохранить";
            ButSave.UseVisualStyleBackColor = true;
            ButSave.Click += ButSave_Click;
            // 
            // ButClear
            // 
            ButClear.Cursor = Cursors.Hand;
            ButClear.BackColor = Color.Tomato;
            ButClear.Location = new Point(164, 417);
            ButClear.Margin = new Padding(2, 2, 2, 2);
            ButClear.Name = "ButClear";
            ButClear.Size = new Size(101, 36);
            ButClear.TabIndex = 21;
            ButClear.Text = "Очистить";
            ButClear.UseVisualStyleBackColor = true;
            ButClear.Click += ButClear_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(467, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(255, 23);
            progressBar1.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(372, 12);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 23;
            label10.Text = "Заполнено:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Cursor = Cursors.No;
            textBox3.Location = new Point(372, 53);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(350, 324);
            textBox3.TabIndex = 20;
            textBox3.Enter += textBox3_Enter;
            // 
            // ButSer
            // 
            ButSer.Location = new Point(410, 403);
            ButSer.Margin = new Padding(2, 0, 2, 0);
            ButSer.Name = "ButSer";
            ButSer.Size = new Size(139, 29);
            ButSer.TabIndex = 26;
            ButSer.Text = "Сериализация";
            ButSer.UseVisualStyleBackColor = true;
            ButSer.Click += ButSer_Click;
            // 
            // ButDeser
            // 
            ButDeser.Location = new Point(567, 403);
            ButDeser.Margin = new Padding(2, 0, 2, 0);
            ButDeser.Name = "ButDeser";
            ButDeser.Size = new Size(139, 29);
            ButDeser.TabIndex = 27;
            ButDeser.Text = "Десериализация";
            ButDeser.UseVisualStyleBackColor = true;
            ButDeser.Click += ButDeser_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Включено", "Выключено" });
            listBox1.Location = new Point(164, 271);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 24);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 465);
            Controls.Add(listBox1);
            Controls.Add(ButDeser);
            Controls.Add(ButSer);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(progressBar1);
            Controls.Add(ButClear);
            Controls.Add(ButSave);
            Controls.Add(label9);
            Controls.Add(Balans);
            Controls.Add(label8);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(ButOwner);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBoxNum);
            Name = "Form1";
            Text = "Счёт в банке";
            ResumeLayout(false);
            PerformLayout();
        }

       



        #endregion
        private TextBox textBoxNum;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxType;
        private Label label4;
        private Label label5;
        private Button ButOwner;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private CheckBox checkBox1;
        private Label label8;
        private TextBox Balans;
        private Label label9;
        private Button ButSave;
        private Button ButClear;
        private ProgressBar progressBar1;
        private Label label10;
        private TextBox textBox3;
        private Button ButSer;
        private Button ButDeser;
        private ListBox listBox1;
    }
}