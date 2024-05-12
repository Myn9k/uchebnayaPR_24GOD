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
using System.Windows.Forms.DataVisualization.Charting;

namespace Grafiki
{
    public partial class MainWindow : Window
    {
        private PaymentBazePolyakovEntities _context = new PaymentBazePolyakovEntities();
        private bool IsValueShownAsLabel;

        public MainWindow()
        {
            InitializeComponent();
            ChartPayments.ChartAreas.Add(new ChartArea("Main"));
                
            var currentSeries = new Series("Payments");
            {
                IsValueShownAsLabel = true;
            };
            ChartPayments.Series.Add(currentSeries);

            ComboUsers.ItemsSource = _context.Users.ToList();
            ComboChartTypes.ItemsSource = Enum.GetValues(typeof(SeriesChartType));
        }

        private void UpdateChart(object sender, SelectionChangedEventArgs e)
        {
            if(ComboUsers.SelectedItem is Users currentUser &&
                ComboChartTypes.SelectedItem is SeriesChartType currentType)
            {
                Series currentSeries = ChartPayments.Series.FirstOrDefault();
                currentSeries.ChartType = currentType;
                currentSeries.Points.Clear();

                var categoriesList = _context.Categories.ToList();  
                foreach (var category in categoriesList) 
                {
                    currentSeries.Points.AddXY(category.Name, 
                        _context.Payments.ToList().Where(p => p.Users == currentUser
                        && p.Categories == category).Sum(p => p.Price * p.Num));
                }
            }
        }
    }
}
