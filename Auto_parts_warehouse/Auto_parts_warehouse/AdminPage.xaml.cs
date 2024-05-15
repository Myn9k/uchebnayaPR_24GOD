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
    public partial class AdminPage : Page
    {
        ApplicationContext db;
        public AdminPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass1 = passbox1.Text.Trim();
            string root = rootbox.Text.Trim();


            if (login.Length < 1)
            {
                TextBoxLogin.ToolTip = "Это поле введено не корректно";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass1.Length < 1)
            {
                passbox1.ToolTip = "Это поле введено не корректно";
                passbox1.Background = Brushes.DarkRed;
            }

            else if (root != "1" && root != "2" && root != "3")
            {
                rootbox.ToolTip = "Это поле введено не корректно";
                rootbox.Background = Brushes.DarkRed;
            }

            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                passbox1.ToolTip = "";
                passbox1.Background = Brushes.Transparent;
                rootbox.ToolTip = "";
                rootbox.Background = Brushes.Transparent;
                int root_id = 1;

                if (root == "1") root_id = 1;
                if (root == "2") root_id = 2;
                if (root == "3") root_id = 3;
                User user = new User(login, pass1, root_id);

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show($"{user.Login} добавлен");

            }
        }
    }
}
