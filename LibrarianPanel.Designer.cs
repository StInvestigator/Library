namespace Library
{
    partial class LibrarianPanel
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
            BEdit = new Button();
            BDelete = new Button();
            BAdd = new Button();
            LBBooks = new ListBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(20, 374);
            button1.Name = "button1";
            button1.Size = new Size(136, 47);
            button1.TabIndex = 14;
            button1.Text = "Вихід";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnExit;
            // 
            // BEdit
            // 
            BEdit.BackColor = Color.Gold;
            BEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BEdit.Location = new Point(20, 115);
            BEdit.Name = "BEdit";
            BEdit.Size = new Size(136, 47);
            BEdit.TabIndex = 13;
            BEdit.Text = "Змінити";
            BEdit.UseVisualStyleBackColor = false;
            BEdit.MouseClick += BChangeClick;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.IndianRed;
            BDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BDelete.Location = new Point(20, 204);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(136, 47);
            BDelete.TabIndex = 12;
            BDelete.Text = "Видалити";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.MouseClick += BDeleteClick;
            // 
            // BAdd
            // 
            BAdd.BackColor = Color.GreenYellow;
            BAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BAdd.Location = new Point(20, 26);
            BAdd.Name = "BAdd";
            BAdd.Size = new Size(136, 47);
            BAdd.TabIndex = 11;
            BAdd.Text = "Додати";
            BAdd.UseVisualStyleBackColor = false;
            BAdd.MouseClick += BAddClick;
            // 
            // LBBooks
            // 
            LBBooks.FormattingEnabled = true;
            LBBooks.ItemHeight = 15;
            LBBooks.Location = new Point(183, 13);
            LBBooks.Name = "LBBooks";
            LBBooks.Size = new Size(597, 424);
            LBBooks.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 446);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список книг";
            // 
            // LibrarianPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BEdit);
            Controls.Add(BDelete);
            Controls.Add(BAdd);
            Controls.Add(LBBooks);
            Controls.Add(groupBox1);
            Name = "LibrarianPanel";
            Text = "Меню бібліотекаря";
            FormClosed += FClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button BEdit;
        private Button BDelete;
        private Button BAdd;
        private ListBox LBBooks;
        private GroupBox groupBox1;
    }
}