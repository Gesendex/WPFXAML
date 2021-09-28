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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dpBirth.DisplayDateStart = DateTime.Now.AddYears(-60);
            dpBirth.DisplayDateEnd = DateTime.Now.AddYears(-18);
        }

        private void dpBirth_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpBirth.SelectedDate < DateTime.Now.AddYears(-60) ||
                dpBirth.SelectedDate > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Введена некорректная дата", "Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                dpBirth.SelectedDate = DateTime.Now.AddYears(-18);
            }
            
        }

    }
}
