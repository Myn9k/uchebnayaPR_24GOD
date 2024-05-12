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
using System.Windows.Shapes;

namespace AppUser
{
    /// <summary>
    /// Логика взаимодействия для AuthWindows.xaml
    /// </summary>
    public partial class AuthWindows : Window
    {
        public AuthWindows()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass1 = passbox1.Password.Trim();

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
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                passbox1.ToolTip = "";
                passbox1.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Pass == pass1).FirstOrDefault();
                }

                if (authUser != null)
                {
                    CabinetUser cabinetUser = new CabinetUser();
                    cabinetUser.GetIdUser(authUser.id);
                    cabinetUser.Show();
                    this.Close();

                }
                else MessageBox.Show("Данные введены некорректно");
            }
        }

        private void Button_REG_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}
