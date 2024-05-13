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
    public partial class EditPage : Window
    {
        private User _currentUser = new User();
        private ApplicationContext _db;

        public EditPage(User selectedUser, ApplicationContext db)
        {
            InitializeComponent();

            if (selectedUser != null)
                _currentUser = selectedUser;

            DataContext = _currentUser;
            _db = db;
        }

        private void BtnSave_click(object sender, RoutedEventArgs e)
        {
            try
            {
                _db.SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
