using Microsoft.Win32;
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
using Auto_parts_warehouse.Classes;
using Auto_parts_warehouse.Windows;

namespace Auto_parts_warehouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Window
    {
        private ApplicationContext db;
        public AddPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void BtnSave_click(object sender, RoutedEventArgs e)
        {
            string title = TitleBox.Text.Trim();
            string description = DescriptionBox.Text.Trim();
            string image = ImagesBox.Text.Trim();
            string price = PriceBox.Text.Trim();


            if (title.Length < 1)
            {
                TitleBox.ToolTip = "Это поле введено не корректно";
                TitleBox.Background = Brushes.DarkRed;
            }
            else if (description.Length < 1)
            {
                DescriptionBox.ToolTip = "Это поле введено не корректно";
                DescriptionBox.Background = Brushes.DarkRed;
            }

            else if (image.Length < 1)
            {
                ImagesBox.ToolTip = "Это поле введено не корректно";
                ImagesBox.Background = Brushes.DarkRed;
            }
            else if (price.Length < 1)
            {
                PriceBox.ToolTip = "Это поле введено не корректно";
                PriceBox.Background = Brushes.DarkRed;
            }

            else
            {
                TitleBox.ToolTip = "";
                TitleBox.Background = Brushes.Transparent;
                DescriptionBox.ToolTip = "";
                DescriptionBox.Background = Brushes.Transparent;
                ImagesBox.ToolTip = "";
                ImagesBox.Background = Brushes.Transparent;
                PriceBox.ToolTip = "";
                PriceBox.Background = Brushes.Transparent;

                Towar towar = new Towar(title, description, image, price);

                db.Towars.Add(towar);
                db.SaveChanges();
                MessageBox.Show($"{towar.Title} добавлен");
            }
        }
        private void ChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @""; // Путь к папке с изображениями
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                ImagesBox.Text = openFileDialog.FileName;
            }
        }
    }
}
