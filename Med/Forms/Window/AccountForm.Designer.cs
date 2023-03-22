namespace Med.Forms.Window
{
    partial class AccountForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Аккаунт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 40);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Роль";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(319, 217);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 11;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(416, 217);
            button2.Name = "button2";
            button2.Size = new Size(91, 37);
            button2.TabIndex = 12;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(207, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 9);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 15;
            label5.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(105, 23);
            textBox3.TabIndex = 14;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 266);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MaximumSize = new Size(574, 460);
            Name = "AccountForm";
            ShowIcon = false;
            Text = "Аккаунты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox3;
    }
}