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

namespace Auto_parts_warehouse.Windows
{
    public partial class EditPage : Window
    {
        private Towar _currentTowar = new Towar();
        private ApplicationContext _db;
        public EditPage(Towar selectedTowar, ApplicationContext db)
        {
            InitializeComponent();

            if (selectedTowar != null)
                _currentTowar = selectedTowar;

            DataContext = _currentTowar;
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

        private void ChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\sort\repozitor\uchebnayaPR_24GOD\Auto_parts_warehouse\Auto_parts_warehouse\Images\"; // Путь к папке с изображениями
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                ImagesBox.Text = openFileDialog.FileName;
            }
        }
    }
}
