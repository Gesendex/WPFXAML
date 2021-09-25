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

namespace WPF_Var1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isSum = true;
        private int sum = 0;
        private int mul = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bCalculate_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(tbA.Text);
            int b = Int32.Parse(tbB.Text);
            int c = Int32.Parse(tbC.Text);
            sum = 0;
            mul = 1;

            sum += a + b + c;
            mul *= a * b * c;
            
            if(isSum)
            {
                tbAnswer.Text = "Сумма: " + sum;
            }
            else
            {
                tbAnswer.Text = "Произведение: " + mul;
            }
        }

        private void bChange_Click(object sender, RoutedEventArgs e)
        {
            isSum = !isSum;
            if (isSum)
            {
                tbAnswer.Text = "Сумма: " + sum;
            }
            else
            {
                tbAnswer.Text = "Произведение: " + mul;
            }
        }
    }
}
