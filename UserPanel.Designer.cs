namespace Library
{
    partial class UserPanel
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
            BAdd = new Button();
            LBOurBooks = new ListBox();
            BDelete = new Button();
            LBYourBooks = new ListBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(446, 423);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 9;
            button1.Text = "Вихід";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnExit;
            // 
            // BAdd
            // 
            BAdd.BackColor = SystemColors.ActiveCaption;
            BAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BAdd.Location = new Point(6, 361);
            BAdd.Name = "BAdd";
            BAdd.Size = new Size(307, 47);
            BAdd.TabIndex = 6;
            BAdd.Text = "Повернути книгу";
            BAdd.UseVisualStyleBackColor = false;
            BAdd.MouseClick += OnReturnButton;
            // 
            // LBOurBooks
            // 
            LBOurBooks.FormattingEnabled = true;
            LBOurBooks.ItemHeight = 15;
            LBOurBooks.Location = new Point(512, 27);
            LBOurBooks.Name = "LBOurBooks";
            LBOurBooks.Size = new Size(480, 334);
            LBOurBooks.TabIndex = 5;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.PeachPuff;
            BDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            BDelete.Location = new Point(171, 361);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(303, 47);
            BDelete.TabIndex = 7;
            BDelete.Text = "Взяти книгу";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.MouseClick += OnTakeButton;
            // 
            // LBYourBooks
            // 
            LBYourBooks.FormattingEnabled = true;
            LBYourBooks.ItemHeight = 15;
            LBYourBooks.Location = new Point(6, 24);
            LBYourBooks.Name = "LBYourBooks";
            LBYourBooks.Size = new Size(472, 334);
            LBYourBooks.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(LBYourBooks);
            groupBox1.Controls.Add(BAdd);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 414);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ваші книги";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(319, 364);
            button2.Name = "button2";
            button2.Size = new Size(159, 44);
            button2.TabIndex = 7;
            button2.Text = "Опис книги";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += MyBookInfo;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(BDelete);
            groupBox2.Location = new Point(512, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 414);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Наші книги";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(6, 364);
            button3.Name = "button3";
            button3.Size = new Size(159, 44);
            button3.TabIndex = 8;
            button3.Text = "Опис книги";
            button3.UseVisualStyleBackColor = false;
            button3.MouseClick += OurBookInfo;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 479);
            Controls.Add(button1);
            Controls.Add(LBOurBooks);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserPanel";
            Text = "Особистий кабінет";
            FormClosed += FClosed;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button BAdd;
        private ListBox LBOurBooks;
        private Button BDelete;
        private ListBox LBYourBooks;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
    }
}