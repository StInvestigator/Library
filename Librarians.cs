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
    public partial class Librarians : Form
    {
        public Librarians()
        {
            InitializeComponent();
            foreach (var item in AdminPanel.librariansList)
            {
                LBLibrarians.Items.Add(item);
            }
        }

        private void OnExitClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void BAddClick(object sender, MouseEventArgs e)
        {
            EditLibrarian editLibrarian = new EditLibrarian();
            if (editLibrarian.ShowDialog() == DialogResult.OK)
            {
                AdminPanel.librariansList.Add(editLibrarian.librarian);
                LBLibrarians.Items.Add(editLibrarian.librarian);
                editLibrarian.Close();
            }
        }

        private void OnChangeClick(object sender, MouseEventArgs e)
        {
            if (LBLibrarians.SelectedIndex == -1) { return; }
            EditLibrarian editLibrarian = new EditLibrarian();
            if (editLibrarian.ShowDialog() == DialogResult.OK)
            {
                AdminPanel.librariansList[LBLibrarians.SelectedIndex] = editLibrarian.librarian;
                LBLibrarians.Items[LBLibrarians.SelectedIndex] = editLibrarian.librarian;
                editLibrarian.Close();
            }
        }

        private void OnKickClick(object sender, MouseEventArgs e)
        {
            if (LBLibrarians.SelectedIndex == -1) { return; }
            AdminPanel.librariansList.Remove(AdminPanel.librariansList[LBLibrarians.SelectedIndex]);
            LBLibrarians.Items.RemoveAt(LBLibrarians.SelectedIndex);
        }
    }
}
