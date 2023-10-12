using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public struct Book : IComparable<Book>
    {
        public int ID;
        public string title;
        public string description;
        public string author;
        public int Year;
        public Book(int ID, string title, string description, string author, int Year)
        {
            this.ID = ID;
            this.title = title;
            this.description = description;
            this.author = author;
            this.Year = Year;
        }

        public int CompareTo(Book other)
        {
            return ID.CompareTo(other.ID);
        }

        public override string ToString()
        {
            return $"ID - {ID} Назва - {title} Автор - {author} Рік написання - {Year} р.";
        }
    }
    public struct Librarian
    {
        public string name;
        public string password;
        public int age;
        public double salary;
        public Librarian(string name, string password, int age, double salary)
        {
            this.name = name;
            this.password = password;
            this.age = age;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"Ім'я - {name}\t Вік - {age} р.\t Зарплатня - {salary}$";
        }
    }
    public struct User
    {
        public string name;
        public string password;
        public int age;
        public DateTime dateOfBirth;
        public List<Book> books;
        public User(string name, string password, int age, DateTime dateOfBirth)
        {
            this.name = name;
            this.password = password;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
            books = new List<Book>();
        }
        public override string ToString()
        {
            return $"Ім'я - {name}\t Вік - {age} р.\t Дата народження - {dateOfBirth.Day}.{dateOfBirth.Month}.{dateOfBirth.Year}\t Кількість книжок: {books.Count}";
        }
    }


    public partial class AdminPanel : Form
    {
        static public List<Librarian> librariansList = new List<Librarian>();
        static public List<User> usersList = new List<User>();
        static public List<Book> books = new List<Book>();
        LoginForm loginForm;

        public AdminPanel(LoginForm lf)
        {
            InitializeComponent();
            loginForm = lf;
        }

        private void OnExitClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void FClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Visible = true;
        }

        private void OnLibrariansClick(object sender, MouseEventArgs e)
        {
            Librarians libr = new Librarians();
            libr.Show();
        }

        private void OnUsersClick(object sender, MouseEventArgs e)
        {
            Users users = new Users();
            users.Show();
        }
    }
}
