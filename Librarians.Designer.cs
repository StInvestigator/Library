namespace Library
{
    partial class Librarians
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
            LBLibrarians = new ListBox();
            BAdd = new Button();
            BDelete = new Button();
            BEdit = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // LBLibrarians
            // 
            LBLibrarians.FormattingEnabled = true;
            LBLibrarians.ItemHeight = 15;
            LBLibrarians.Location = new Point(191, 12);
            LBLibrarians.Name = "LBLibrarians";
            LBLibrarians.Size = new Size(597, 424);
            LBLibrarians.TabIndex = 0;
            // 
            // BAdd
            // 
            BAdd.BackColor = Color.GreenYellow;
            BAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BAdd.Location = new Point(28, 25);
            BAdd.Name = "BAdd";
            BAdd.Size = new Size(136, 47);
            BAdd.TabIndex = 1;
            BAdd.Text = "Додати";
            BAdd.UseVisualStyleBackColor = false;
            BAdd.MouseClick += BAddClick;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.IndianRed;
            BDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BDelete.Location = new Point(28, 203);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(136, 47);
            BDelete.TabIndex = 2;
            BDelete.Text = "Звільнити";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.MouseClick += OnKickClick;
            // 
            // BEdit
            // 
            BEdit.BackColor = Color.Gold;
            BEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BEdit.Location = new Point(28, 114);
            BEdit.Name = "BEdit";
            BEdit.Size = new Size(136, 47);
            BEdit.TabIndex = 3;
            BEdit.Text = "Змінити";
            BEdit.UseVisualStyleBackColor = false;
            BEdit.MouseClick += OnChangeClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(28, 373);
            button1.Name = "button1";
            button1.Size = new Size(136, 47);
            button1.TabIndex = 4;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnExitClick;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 446);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Керування бібліотекарями";
            // 
            // Librarians
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BEdit);
            Controls.Add(BDelete);
            Controls.Add(BAdd);
            Controls.Add(LBLibrarians);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Librarians";
            Text = "Бібліотекарі";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LBLibrarians;
        private Button BAdd;
        private Button BDelete;
        private Button BEdit;
        private Button button1;
        private GroupBox groupBox1;
    }
}