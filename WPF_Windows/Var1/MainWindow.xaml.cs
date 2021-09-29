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

namespace Var1
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

        private void btSquare_Click(object sender, RoutedEventArgs e)
        {
            Window wSquare = new SquareWindow();
            wSquare.Show();
        }

        private void btAverage_Click(object sender, RoutedEventArgs e)
        {
            Window wAverage = new AverageWindow();
            wAverage.Show();
        }

        private void btList_Click(object sender, RoutedEventArgs e)
        {
            Window wList= new ListWindow();
            wList.Show();
        }

        private void btFile_Click(object sender, RoutedEventArgs e)
        {
            Window wFile = new FileWindow();
            wFile.Show();
        }
    }
}
