namespace Library
{
    partial class EditLibrarian
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
            TBName = new TextBox();
            TBAge = new TextBox();
            label2 = new Label();
            TBSalary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            TBPassword = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // TBName
            // 
            TBName.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBName.Location = new Point(157, 22);
            TBName.Name = "TBName";
            TBName.Size = new Size(190, 33);
            TBName.TabIndex = 1;
            // 
            // TBAge
            // 
            TBAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBAge.Location = new Point(157, 123);
            TBAge.Name = "TBAge";
            TBAge.Size = new Size(190, 33);
            TBAge.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(36, 131);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 2;
            label2.Text = "Вік";
            // 
            // TBSalary
            // 
            TBSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBSalary.Location = new Point(157, 175);
            TBSalary.Name = "TBSalary";
            TBSalary.Size = new Size(190, 33);
            TBSalary.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(36, 183);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 4;
            label3.Text = "Зарплатня";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(353, 183);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 6;
            label4.Text = "$";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(157, 245);
            button1.Name = "button1";
            button1.Size = new Size(190, 45);
            button1.TabIndex = 7;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnConfirmClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(36, 245);
            button2.Name = "button2";
            button2.Size = new Size(96, 45);
            button2.TabIndex = 8;
            button2.Text = "Вихід";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += OnExit;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(353, 131);
            label5.Name = "label5";
            label5.Size = new Size(39, 25);
            label5.TabIndex = 9;
            label5.Text = "y.o.";
            // 
            // TBPassword
            // 
            TBPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBPassword.Location = new Point(157, 74);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(190, 33);
            TBPassword.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(36, 82);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 10;
            label6.Text = "Пароль";
            // 
            // EditLibrarian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 333);
            Controls.Add(TBPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(TBSalary);
            Controls.Add(label3);
            Controls.Add(TBAge);
            Controls.Add(label2);
            Controls.Add(TBName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditLibrarian";
            Text = "Дані бібліотекаря";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBName;
        private TextBox TBAge;
        private Label label2;
        private TextBox TBSalary;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox TBPassword;
        private Label label6;
    }
}