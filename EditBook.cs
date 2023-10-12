using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class EditBook : Form
    {
        static int ID = 0;
        public Book book;
        public EditBook()
        {
            InitializeComponent();
            ID++;
        }

        private void OnConfirmClick(object sender, MouseEventArgs e)
        {
            if (TBAuthor.Text != "" && TBName.Text != "" && TBYear.Text != "" && TBDescriprion.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(TBYear.Text) > DateTime.Now.Year)
                    {
                        TBYear.Text = "";
                        throw new Exception("Wrong year");
                    }
                    else
                    {
                        book = new Book(ID, TBName.Text, TBDescriprion.Text, TBAuthor.Text, Convert.ToInt32(TBYear.Text));
                        DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    TBAuthor.Text = ""; TBName.Text = ""; TBDescriprion.Text = ""; TBYear.Text = "";
                    MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void OnExit(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
