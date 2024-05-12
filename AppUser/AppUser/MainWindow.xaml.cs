using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppUser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        AuthWindows authWin = new AuthWindows();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass1 = passbox1.Password.Trim();
            string pass2 = passbox2.Password.Trim();
            string email = TextBoxEmail.Text.Trim().ToLower();
            string birthday = birthdayDatePicker.Text.Trim();
            string fio = TextBoxFIO.Text.Trim();

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Это поле введено не корректно";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass1.Length < 5)
            {
                passbox1.ToolTip = "Это поле введено не корректно";
                passbox1.Background = Brushes.DarkRed;
            }
            else if (pass2.Length < 5)
            {
                passbox2.ToolTip = "Это поле введено не корректно";
                passbox2.Background = Brushes.DarkRed;
            }
            else if (pass1 != pass2)
            {
                passbox2.ToolTip = "Это поле введено не корректно";
                passbox2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Это поле введено не корректно";
                TextBoxEmail.Background = Brushes.DarkRed;
            }
            else if (birthday.Length < 5 || !birthday.Contains("."))
            {
                birthdayDatePicker.ToolTip = "Это поле введено не корректно";
                birthdayDatePicker.Background = Brushes.DarkRed;
            }
            else if (fio.Length < 5 || !fio.Contains(" "))
            {
                TextBoxFIO.ToolTip = "Это поле введено не корректно";
                TextBoxFIO.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                passbox1.ToolTip = "";
                passbox1.Background = Brushes.Transparent;
                passbox2.ToolTip = "";
                passbox2.Background = Brushes.Transparent;
                TextBoxEmail.ToolTip = "";
                TextBoxEmail.Background = Brushes.Transparent;
                birthdayDatePicker.ToolTip = "";
                birthdayDatePicker.Background = Brushes.Transparent;
                TextBoxFIO.ToolTip = "";
                TextBoxFIO.Background = Brushes.Transparent;
                User user = new User(login, pass1, email, birthday, fio);

                db.Users.Add(user);
                db.SaveChanges();
                authWin.Show();
                this.Close();

            }
        }

        private void AuthButton(object sender, RoutedEventArgs e)
        {
            authWin.Show();
            this.Close();
        }
    }
}
