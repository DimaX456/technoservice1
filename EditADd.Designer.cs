namespace TecnoService
{
    partial class EditADd
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
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            comboBox4 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 97);
            label3.Name = "label3";
            label3.Size = new Size(234, 15);
            label3.TabIndex = 6;
            label3.Text = "Оборудование, которое требует ремонта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 126);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 8;
            label4.Text = "Тип неисправности";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(292, 147);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(132, 47);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 155);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 10;
            label5.Text = "Описание проблемы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 208);
            label6.Name = "label6";
            label6.Size = new Size(174, 15);
            label6.TabIndex = 12;
            label6.Text = "Клиент, который подал заявку";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(292, 238);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 246);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 14;
            label7.Text = "Статус заявки ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 63);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата добовления";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(292, 55);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 16;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(292, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(47, 324);
            button1.Name = "button1";
            button1.Size = new Size(114, 59);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(292, 118);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(292, 89);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 270);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 21;
            label1.Text = "Мастер ";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(292, 270);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 22;
            // 
            // button2
            // 
            button2.Location = new Point(270, 324);
            button2.Name = "button2";
            button2.Size = new Size(132, 59);
            button2.TabIndex = 23;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditADd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(button2);
            Controls.Add(comboBox4);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditADd";
            Text = "Изменить ";
            Load += EditADd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private ComboBox comboBox4;
        private Button button2;
    }
}