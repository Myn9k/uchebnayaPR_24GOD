using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Auto_parts_warehouse
{
    public partial class WareHouse : Window
    {
        ApplicationContext db;
        public int Roots_ID { get; set; }
        public int User_ID {  get; set; }
        public WareHouse()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            db = new ApplicationContext();
            DataContext = this;

        }
        public void GetIdUser(int id)
        {
            User users = db.Users.Where(u => u.id == id).FirstOrDefault();
            LoginName.Text = users.Login;
            User_ID = users.id;
        }
        public void GetRootIdUser(int Root_id)
        {
            User users = db.Users.Where(u => u.id == User_ID && u.Root_id == Root_id).FirstOrDefault();
            Roots_ID = users.Root_id;
            if (Root_id == 3)
            {
                AdminPanel.Visibility = Visibility.Visible;
                MenagerPanel.Visibility = Visibility.Visible;

            }
            else if(Root_id == 3 || Root_id == 2)
            {
                MenagerPanel.Visibility = Visibility.Visible;
            }
            else if (Root_id != 3 )
            {
                AdminPanel.Visibility = Visibility.Hidden;
            }

            else
            {
                AdminPanel.Visibility = Visibility.Hidden;
                MenagerPanel.Visibility = Visibility.Hidden;
            }
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CardsPage());
        }

        private void AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AdminPage());
        }

        private void BtnBack_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void MenagerPanel_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ManagerPage());
        }
    }
}
