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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dpStart.SelectedDate = DateTime.Today;
            dpDuration.Text = 0.ToString();
        }

        private void dpEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpEnd.SelectedDate.HasValue &&
                (dpEnd.SelectedDate.Value > dpStart.SelectedDate.Value.AddDays(int.Parse(dpDuration.Text)) || 
                dpEnd.SelectedDate.Value < dpStart.SelectedDate.Value))
            {
                MessageBox.Show("Введена некорректная дата сдачи или срок проекта", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                dpEnd.SelectedDate = null;
            }

        }
    }
}
