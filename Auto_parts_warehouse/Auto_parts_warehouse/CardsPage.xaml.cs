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
    public partial class CardsPage : Page
    {
        ApplicationContext db;
        public CardsPage()
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

        private void Buy(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Покупка прошла успешно");
        }

    }
}
