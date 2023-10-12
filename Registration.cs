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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void OnExitClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void OnConfirmClick(object sender, MouseEventArgs e)
        {
            if (TBName.Text != "" && TBPassword.Text != "" && TBDay.Text != "" && TBMonth.Text != "" && TBYear.Text != "")
            {
                try
                {
                    DateTime time = new DateTime(Convert.ToInt32(TBYear.Text), Convert.ToInt32(TBMonth.Text), Convert.ToInt32(TBDay.Text));
                    User user = new User(TBName.Text, TBPassword.Text,
                        DateTime.Now.Year - time.Year + Convert.ToInt32(DateTime.Now.Day >= time.Day && DateTime.Now.Month >= time.Month), time);
                    if (AdminPanel.usersList.Find(x => x.name == user.name).name != user.name && AdminPanel.librariansList.Find(x => x.name == user.name).name != user.name && user.name != "Admin")
                    {
                        AdminPanel.usersList.Add(user);
                        MessageBox.Show("Success!");
                        Close();
                    }
                    else
                    {
                        TBName.Text = "";
                        MessageBox.Show("Your name is already registered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    TBName.Text = ""; TBPassword.Text = ""; TBDay.Text = ""; TBMonth.Text = ""; TBYear.Text = "";
                    MessageBox.Show("Wrong input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
