using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _8Ball
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

        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private string GetRandomAnswer()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 4);
            switch (a)
            {
                case 0:
                    return "Так и есть";
                case 1:
                    return "Сомневаюсь";
                case 2:
                    return "Никак нет";
            }
            return "нет ответа";
               
        }
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            txtAnswer.Text = GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;

        }
    }
}
