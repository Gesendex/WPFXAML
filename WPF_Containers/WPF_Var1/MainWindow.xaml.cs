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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(tbValue.Text, out int value);
            tbResult.Text = "";
            if (value % 3 == 0)
                tbResult.Text += "Заданное число кратно 3.\n";
            else
                tbResult.Text += "Заданное число кратно 3.\n";

            if (value % 2 == 0)
                tbResult.Text += "Заданное число чётное.\n";
            else
                tbResult.Text += "Заданное число не четное.\n";
            
            tbResult.Text += "Произведение цифр: " + ((tbValue.Text[0] - 48) * (tbValue.Text[1] - 48)) + "\n";
            tbResult.Text += "Сумма цифр: " + ((tbValue.Text[0] - 48) + (tbValue.Text[1] - 48));
        }
    }
}
