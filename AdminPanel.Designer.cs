namespace Library
{
    partial class AdminPanel
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
            BLibrarians = new Button();
            BUsers = new Button();
            BExit = new Button();
            SuspendLayout();
            // 
            // BLibrarians
            // 
            BLibrarians.BackColor = SystemColors.ActiveCaption;
            BLibrarians.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BLibrarians.Location = new Point(12, 12);
            BLibrarians.Name = "BLibrarians";
            BLibrarians.Size = new Size(150, 60);
            BLibrarians.TabIndex = 0;
            BLibrarians.Text = "Бібліотекарі";
            BLibrarians.UseVisualStyleBackColor = false;
            BLibrarians.MouseClick += OnLibrariansClick;
            // 
            // BUsers
            // 
            BUsers.BackColor = Color.RosyBrown;
            BUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BUsers.Location = new Point(188, 12);
            BUsers.Name = "BUsers";
            BUsers.Size = new Size(150, 60);
            BUsers.TabIndex = 1;
            BUsers.Text = "Користувачі";
            BUsers.UseVisualStyleBackColor = false;
            BUsers.MouseClick += OnUsersClick;
            // 
            // BExit
            // 
            BExit.BackColor = Color.IndianRed;
            BExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BExit.Location = new Point(360, 12);
            BExit.Name = "BExit";
            BExit.Size = new Size(89, 60);
            BExit.TabIndex = 2;
            BExit.Text = "Вихід";
            BExit.UseVisualStyleBackColor = false;
            BExit.MouseClick += OnExitClick;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 88);
            Controls.Add(BExit);
            Controls.Add(BUsers);
            Controls.Add(BLibrarians);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Адмін панель";
            FormClosed += FClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button BLibrarians;
        private Button BUsers;
        private Button BExit;
    }
}