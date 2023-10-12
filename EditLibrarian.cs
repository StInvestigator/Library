using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditLibrarian : Form
    {
        public Librarian librarian;
        public EditLibrarian()
        {
            InitializeComponent();
        }

        private void OnConfirmClick(object sender, MouseEventArgs e)
        {
            if (TBAge.Text != "" && TBName.Text != "" && TBSalary.Text != "" && TBPassword.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(TBAge.Text) < 16 || Convert.ToInt32(TBAge.Text) > 200 || Convert.ToDouble(TBSalary.Text) < 1)
                    {
                        throw new Exception("Wrong input");
                    }
                    if (AdminPanel.usersList.Find(x => x.name == TBName.Text).name != TBName.Text && AdminPanel.librariansList.Find(x => x.name == TBName.Text).name != TBName.Text && TBName.Text != "Admin")
                    {
                        librarian = new Librarian(TBName.Text, TBPassword.Text, Convert.ToInt32(TBAge.Text), Convert.ToDouble(TBSalary.Text));
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        TBName.Text = "";
                        MessageBox.Show("Your name is already registered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    TBAge.Text = ""; TBName.Text = ""; TBSalary.Text = ""; TBPassword.Text = "";
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
