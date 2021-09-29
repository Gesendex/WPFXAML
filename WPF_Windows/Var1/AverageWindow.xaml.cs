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

namespace Var1
{
    /// <summary>
    /// Логика взаимодействия для AverageWindow.xaml
    /// </summary>
    public partial class AverageWindow : Window
    {
        public AverageWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbAnswer.Text = ((int.Parse(tbValue1.Text) + int.Parse(tbValue2.Text)) / 2.0).ToString();
        }
    }
}
