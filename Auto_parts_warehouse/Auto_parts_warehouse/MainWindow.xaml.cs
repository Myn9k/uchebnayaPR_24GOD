using Auto_parts_warehouse.Classes;
using Auto_parts_warehouse.Windows;
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

namespace Auto_parts_warehouse
{
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {

            WareHouse wareHouse;
            string login = TextBoxLogin.Text.Trim();
            string pass1 = passbox1.Password.Trim();
            db = new ApplicationContext();

            List<User> users = db.Users.ToList();

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
                        wareHouse = new WareHouse()
                        {
                            Roots_ID = authUser.Root_id,
                            User_ID = authUser.id
                        };
                        wareHouse.GetIdUser(authUser.id);
                        wareHouse.GetRootIdUser(authUser.Root_id);
                        wareHouse.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
