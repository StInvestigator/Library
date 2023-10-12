namespace Library
{
    partial class EditBook
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
            TBDescriprion = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            TBAuthor = new TextBox();
            label2 = new Label();
            TBName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            TBYear = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // TBDescriprion
            // 
            TBDescriprion.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBDescriprion.Location = new Point(164, 65);
            TBDescriprion.Name = "TBDescriprion";
            TBDescriprion.Size = new Size(190, 33);
            TBDescriprion.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(24, 73);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 22;
            label6.Text = "Опис";
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(24, 236);
            button2.Name = "button2";
            button2.Size = new Size(116, 45);
            button2.TabIndex = 20;
            button2.Text = "Вихід";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += OnExit;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(164, 236);
            button1.Name = "button1";
            button1.Size = new Size(190, 45);
            button1.TabIndex = 19;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += OnConfirmClick;
            // 
            // TBAuthor
            // 
            TBAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBAuthor.Location = new Point(164, 114);
            TBAuthor.Name = "TBAuthor";
            TBAuthor.Size = new Size(190, 33);
            TBAuthor.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(24, 122);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 14;
            label2.Text = "Автор";
            // 
            // TBName
            // 
            TBName.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBName.Location = new Point(164, 13);
            TBName.Name = "TBName";
            TBName.Size = new Size(190, 33);
            TBName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 12;
            label1.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(24, 174);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 16;
            label3.Text = "Рік написання";
            // 
            // TBYear
            // 
            TBYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TBYear.Location = new Point(164, 166);
            TBYear.Name = "TBYear";
            TBYear.Size = new Size(190, 33);
            TBYear.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(360, 174);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 24;
            label4.Text = "рік";
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 298);
            Controls.Add(label4);
            Controls.Add(TBDescriprion);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TBYear);
            Controls.Add(label3);
            Controls.Add(TBAuthor);
            Controls.Add(label2);
            Controls.Add(TBName);
            Controls.Add(label1);
            Name = "EditBook";
            Text = "EditBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBDescriprion;
        private Label label6;
        private Button button2;
        private Button button1;
        private TextBox TBAuthor;
        private Label label2;
        private TextBox TBName;
        private Label label1;
        private Label label3;
        private TextBox TBYear;
        private Label label4;
    }
}