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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            foreach (var item in AdminPanel.usersList)
            {
                LBUsers.Items.Add(item);
            }
        }

        private void OnExitClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void OnDeleteClick(object sender, MouseEventArgs e)
        {
            if (LBUsers.SelectedIndex == -1) { return; }
            AdminPanel.usersList.Remove(AdminPanel.usersList[LBUsers.SelectedIndex]);
            LBUsers.Items.Remove(LBUsers.Items[LBUsers.SelectedIndex]);
        }
    }
}
