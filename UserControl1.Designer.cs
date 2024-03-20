namespace TecnoService
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 58);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата добовления ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 24);
            label3.Name = "label3";
            label3.Size = new Size(234, 15);
            label3.TabIndex = 2;
            label3.Text = "Оборудование, которое требует ремонта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 58);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 3;
            label4.Text = "Тип неосиправности";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 24);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 4;
            label5.Text = "Описание проблемы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 58);
            label6.Name = "label6";
            label6.Size = new Size(171, 15);
            label6.TabIndex = 5;
            label6.Text = "Клиент который подал заявку";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 106);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 6;
            label7.Text = "Сатус заявки ";
            // 
            // button1
            // 
            button1.Location = new Point(22, 157);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 7;
            button1.Text = "Изменить ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 157);
            button2.Name = "button2";
            button2.Size = new Size(114, 46);
            button2.TabIndex = 8;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 106);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(715, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label label8;
    }
}
