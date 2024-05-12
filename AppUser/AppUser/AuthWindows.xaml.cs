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
    public partial class AuthWindows : Window
    {
        ApplicationContext db;
        public AuthWindows()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass1 = passbox1.Password.Trim();
            db = new ApplicationContext();

            List<User> users = db.Users.ToList();
            string strUser = "";

            foreach (User user in users)
            {
                if (login != user.Login)
                {
                    TextBoxLogin.ToolTip = "Такого Логина не существует";
                    TextBoxLogin.Background = Brushes.DarkRed;
                }
                else if (pass1 != user.Pass)
                {
                    passbox1.ToolTip = "Такого Пароля не существует";
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
                        if (authUser.Pass == "Admin" && authUser.Login == "Admin")
                        {
                            CabinetAdmin cabinetAdmin = new CabinetAdmin();
                            cabinetAdmin.Show();
                            this.Close();
                        }
                        else
                        {
                            CabinetUser cabinetUser = new CabinetUser();
                            cabinetUser.GetIdUser(authUser.id);
                            cabinetUser.Show();
                            this.Close();
                        }
                    }
                }
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
