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
    /// <summary>
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        ApplicationContext db;
        public ManagerPage()
        {
            InitializeComponent();
            db = new ApplicationContext();

            List<User> users = db.Users.ToList();
            List<Towar> towar = db.Towars.ToList();

            UpdateTours();
        }
        private void UpdateTours()
        {
            List<Towar> towar = db.Towars.ToList();


            towar = towar.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            LViewTowar.ItemsSource = towar.ToList();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTours();
        }
        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTours();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            Towar selectedTowar = (sender as Button).DataContext as Towar;
            EditPage editPage = new EditPage(selectedTowar, db);
            editPage.ShowDialog();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddPage addPage = new AddPage();
            addPage.ShowDialog();
        }
    }
}
