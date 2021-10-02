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

namespace CarService.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
            ComboSortBy.SelectedIndex = 0;
            ComboDicount.SelectedIndex = 0;
        }

        private void BtnCreateService_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrEditServicePage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }
        private void ComboDicount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }
        private void UpdateServices()
        {
            var services = App.Context.Services.ToList();

            if(ComboSortBy.SelectedIndex == 0)
            {
                services = services.OrderBy(p => p.CostWithDiscount).ToList();
            }
            else
            {
                services = services.OrderByDescending(p => p.CostWithDiscount).ToList();
            }
            
            if (ComboDicount.SelectedIndex == 1)
            {
                services = services.Where(p => p.Discount >= 0 && p.Discount < 0.05).ToList();
            }
            else if (ComboDicount.SelectedIndex == 2)
            {
                services = services.Where(p => p.Discount >= 0.05 && p.Discount < 0.15).ToList();
            }
            else if (ComboDicount.SelectedIndex == 3)
            {
                services = services.Where(p => p.Discount >= 0.15 && p.Discount < 0.30).ToList();
            }
            else if(ComboDicount.SelectedIndex == 4)
            {
                services = services.Where(p => p.Discount >= 0.30 && p.Discount < 0.70).ToList();
            }
            else if(ComboDicount.SelectedIndex == 5)
            {
                services = services.Where(p => p.Discount >= 0.70 && p.Discount < 1).ToList();
            }

            services = services.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            lViewServices.ItemsSource = services;
        }

        
    }
}
