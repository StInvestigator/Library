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
    public partial class LibrarianPanel : Form
    {
        LoginForm loginForm;
        public LibrarianPanel(Librarian librarian, LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            foreach (var item in AdminPanel.books)
            {
                LBBooks.Items.Add(item);
            }
        }
        private void FClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Visible = true;
        }
        private void OnExit(object sender, MouseEventArgs e)
        {
            Close();
        }
        private void BAddClick(object sender, MouseEventArgs e)
        {
            EditBook editBook = new EditBook();
            if (editBook.ShowDialog() == DialogResult.OK)
            {
                AdminPanel.books.Add(editBook.book);
                LBBooks.Items.Add(editBook.book);
                editBook.Close();
            }
        }

        private void BChangeClick(object sender, MouseEventArgs e)
        {
            if (LBBooks.SelectedIndex == -1) { return; }
            EditBook editBook = new EditBook();
            if (editBook.ShowDialog() == DialogResult.OK)
            {
                AdminPanel.books[LBBooks.SelectedIndex] = editBook.book;
                LBBooks.Items[LBBooks.SelectedIndex] = editBook.book;
                editBook.Close();
            }
        }

        private void BDeleteClick(object sender, MouseEventArgs e)
        {
            if (LBBooks.SelectedIndex == -1) { return; }
            AdminPanel.books.Remove(AdminPanel.books[LBBooks.SelectedIndex]);
            LBBooks.Items.Remove(LBBooks.Items[LBBooks.SelectedIndex]);
        }
    }
}
