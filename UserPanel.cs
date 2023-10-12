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
    public partial class UserPanel : Form
    {
        User user;
        LoginForm loginForm;
        public UserPanel(User user, LoginForm loginForm)
        {
            InitializeComponent();
            this.user = user;
            this.loginForm = loginForm;
            AdminPanel.books.Sort();
            user.books.Sort();
            foreach (var item in AdminPanel.books)
            {
                LBOurBooks.Items.Add(item);
            }
            foreach (var item in user.books)
            {
                LBYourBooks.Items.Add(item);
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

        private void OnTakeButton(object sender, MouseEventArgs e)
        {
            if (LBOurBooks.SelectedIndex == -1) { return; }
            user.books.Add(AdminPanel.books[LBOurBooks.SelectedIndex]);
            LBYourBooks.Items.Add(AdminPanel.books[LBOurBooks.SelectedIndex]);
            AdminPanel.books.RemoveAt(LBOurBooks.SelectedIndex);
            LBOurBooks.Items.RemoveAt(LBOurBooks.SelectedIndex);
        }

        private void OnReturnButton(object sender, MouseEventArgs e)
        {
            if (LBYourBooks.SelectedIndex == -1) { return; }
            AdminPanel.books.Add(user.books[LBYourBooks.SelectedIndex]);
            LBOurBooks.Items.Add(user.books[LBYourBooks.SelectedIndex]);
            user.books.RemoveAt(LBYourBooks.SelectedIndex);
            LBYourBooks.Items.RemoveAt(LBYourBooks.SelectedIndex);
        }

        private void MyBookInfo(object sender, MouseEventArgs e)
        {
            BookInfo(LBYourBooks);
        }
        private void OurBookInfo(object sender, MouseEventArgs e)
        {
            BookInfo(LBOurBooks);
        }

        private void BookInfo(ListBox LB)
        {
            if (LB.SelectedIndex == -1) { return; }
            Book? b = LB.Items[LB.SelectedIndex] as Book?;
            if (b != null)
            {
                string desc = "";
                for (int i = 0; i < b.Value.description.Length; i++)
                {
                    if (i % 40.0 == 0 && i != 0)
                    {
                        desc += "\n       ";
                    }
                }
                MessageBox.Show($"Назва книги - \"{b.Value.title}\"\nОпис - {b.Value.description}", "Опис книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
