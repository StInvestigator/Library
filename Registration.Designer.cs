namespace Library
{
    partial class Registration
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
            button2 = new Button();
            button1 = new Button();
            TBPassword = new TextBox();
            label3 = new Label();
            TBName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            TBMonth = new TextBox();
            TBYear = new TextBox();
            TBDay = new TextBox();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(26, 252);
            button2.Name = "button2";
            button2.Size = new Size(96, 45);
            button2.TabIndex = 18;
            button2.Text = "Вихід";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += OnExitClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(147, 252);
            button1.Name = "button1";
            button1.Size = new Size(190, 45);
            button1.TabIndex = 17;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnConfirmClick;
            // 
            // TBPassword
            // 
            TBPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBPassword.Location = new Point(133, 71);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(190, 33);
            TBPassword.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(35, 71);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 14;
            label3.Text = "Пароль";
            // 
            // TBName
            // 
            TBName.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBName.Location = new Point(133, 20);
            TBName.Name = "TBName";
            TBName.Size = new Size(190, 33);
            TBName.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 10;
            label1.Text = "Ім'я";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(79, 132);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 20;
            label4.Text = "Дата народження";
            // 
            // TBMonth
            // 
            TBMonth.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBMonth.Location = new Point(133, 177);
            TBMonth.Name = "TBMonth";
            TBMonth.Size = new Size(57, 33);
            TBMonth.TabIndex = 22;
            // 
            // TBYear
            // 
            TBYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBYear.Location = new Point(212, 177);
            TBYear.Name = "TBYear";
            TBYear.Size = new Size(96, 33);
            TBYear.TabIndex = 23;
            // 
            // TBDay
            // 
            TBDay.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBDay.Location = new Point(54, 177);
            TBDay.Name = "TBDay";
            TBDay.Size = new Size(57, 33);
            TBDay.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(111, 185);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 25;
            label2.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(190, 185);
            label5.Name = "label5";
            label5.Size = new Size(16, 25);
            label5.TabIndex = 26;
            label5.Text = ".";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 330);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(TBDay);
            Controls.Add(TBYear);
            Controls.Add(TBMonth);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TBPassword);
            Controls.Add(label3);
            Controls.Add(TBName);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private Label label4;
        private TextBox TBPassword;
        private Label label3;
        private TextBox TBName;
        private Label label1;
        private TextBox TBMonth;
        private TextBox TBYear;
        private TextBox TBDay;
        private Label label2;
        private Label label5;
    }
}