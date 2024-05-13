using MahApps.Metro.Controls;
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
    public partial class CabinetAdmin : Window
    {
        ApplicationContext db;

        public CabinetAdmin()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            DGridUSER.ItemsSource = users;
        }


        private void BtnEdit_click(object sender, RoutedEventArgs e)
        {
            User selectedUser = (sender as Button).DataContext as User;
            EditPage editPage = new EditPage(selectedUser, db);
            editPage.ShowDialog();
        }
    }
}
