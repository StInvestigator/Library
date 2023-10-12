namespace Library
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLoginClick(object sender, MouseEventArgs e)
        {
            if (TBLogin.Text != "" && TBPassword.Text != "")
            {
                if (TBLogin.Text == "Admin" && TBPassword.Text == "Admin")
                {
                    AdminPanel adminPanel = new AdminPanel(this);
                    adminPanel.Show();
                }
                else if (AdminPanel.usersList.Find(x => x.name == TBLogin.Text && x.password == TBPassword.Text).age != 0)
                {
                    User us = AdminPanel.usersList.Find(x => x.name == TBLogin.Text && x.password == TBPassword.Text);
                    UserPanel userPanel = new UserPanel(us, this);
                    userPanel.Show();
                }
                else if (AdminPanel.librariansList.Find(x => x.name == TBLogin.Text && x.password == TBPassword.Text).age != 0)
                {
                    Librarian lib = AdminPanel.librariansList.Find(x => x.name == TBLogin.Text && x.password == TBPassword.Text);
                    LibrarianPanel librarianPanel = new LibrarianPanel(lib, this);
                    librarianPanel.Show();
                }
                else
                {
                    MessageBox.Show("Wrong login or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Visible = false;
            TBLogin.Text = ""; TBPassword.Text = "";
        }

        private void OnExitClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void OnRegisterClick(object sender, MouseEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}