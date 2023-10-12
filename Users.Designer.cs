namespace Library
{
    partial class Users
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
            button1 = new Button();
            BDelete = new Button();
            LBUsers = new ListBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(20, 374);
            button1.Name = "button1";
            button1.Size = new Size(136, 47);
            button1.TabIndex = 9;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnExitClick;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.LightCoral;
            BDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BDelete.Location = new Point(20, 35);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(136, 47);
            BDelete.TabIndex = 7;
            BDelete.Text = "Видалити";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.MouseClick += OnDeleteClick;
            // 
            // LBUsers
            // 
            LBUsers.FormattingEnabled = true;
            LBUsers.ItemHeight = 15;
            LBUsers.Location = new Point(183, 13);
            LBUsers.Name = "LBUsers";
            LBUsers.Size = new Size(597, 424);
            LBUsers.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 439);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Керування користувачами";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BDelete);
            Controls.Add(LBUsers);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Users";
            Text = "Користувачі";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button BDelete;
        private ListBox LBUsers;
        private GroupBox groupBox1;
    }
}