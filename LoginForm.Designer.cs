namespace Library
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            TBLogin = new TextBox();
            TBPassword = new TextBox();
            BLogin = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(20, 79);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // TBLogin
            // 
            TBLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBLogin.Location = new Point(131, 26);
            TBLogin.Name = "TBLogin";
            TBLogin.Size = new Size(317, 33);
            TBLogin.TabIndex = 2;
            // 
            // TBPassword
            // 
            TBPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBPassword.Location = new Point(131, 71);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(317, 33);
            TBPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            BLogin.BackColor = SystemColors.ActiveCaption;
            BLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BLogin.Location = new Point(272, 126);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(176, 41);
            BLogin.TabIndex = 4;
            BLogin.Text = "Увійти";
            BLogin.UseVisualStyleBackColor = false;
            BLogin.MouseClick += OnLoginClick;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(20, 126);
            button1.Name = "button1";
            button1.Size = new Size(92, 41);
            button1.TabIndex = 5;
            button1.Text = "Вийти";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnExitClick;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(131, 126);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 6;
            button2.Text = "Реєстрація";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += OnRegisterClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 196);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BLogin);
            Controls.Add(TBPassword);
            Controls.Add(TBLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вхід";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TBLogin;
        private TextBox TBPassword;
        private Button BLogin;
        private Button button1;
        private Button button2;
    }
}