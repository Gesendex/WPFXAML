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

namespace WindowInteracting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewWindow _window = new NewWindow();
        public MainWindow()
        {
            InitializeComponent();
            // Стартуем окна как немодальные.
            NewWindow w1 = new NewWindow();
            w1.Show();
            Window2 w2 = new Window2();
            w2.Show();

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Отображаем второе окно как немодальное.
            _window.Show();
            // Делаем первую кнопку не активной.
            buttonShow.IsEnabled = false;
            // Вторую кнопку, для обновления дочернего окна, делаем активной.
            buttonUpdate.IsEnabled = true;
        }
        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Вызываем пользовательский метод, который обновляет значения Label в дочернем окне.
            _window.UpdateWindow("Hello world dadada");
            buttonUpdate.IsEnabled = false;
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Перебираем все окна текущего приложения.
            for (int i = 0; i < Application.Current.Windows.Count; ++i)
            {
                Window temp = Application.Current.Windows[i];
                // Если окно производное от интерфейса IInteractiveWindow вызываем метод UpdateWindow().
                if (temp is IInteractiveWindow)
                {
                    (temp as IInteractiveWindow).UpdateWindow("Hello world");
                }
            }
        }


    }
}
