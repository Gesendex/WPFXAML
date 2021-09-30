using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

namespace Var2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bitmap bitmap;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* OpenFileDialog fileDialog = new OpenFileDialog();

             if ((bool)fileDialog.ShowDialog())
             {
                 using (StreamReader fileStream = new StreamReader(fileDialog.FileName))
                 {
                     rtbText.AppendText(fileStream.ReadToEnd());
                 }
             }*/
            OpenFileDialog fileDialog = new OpenFileDialog();

            if ((bool)fileDialog.ShowDialog())
            {
                Background = new ImageBrush(new BitmapImage(new Uri(fileDialog.FileName)));
                bitmap = new Bitmap(fileDialog.FileName);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /* SaveFileDialog saveFileDialog = new SaveFileDialog();
             if ((bool)saveFileDialog.ShowDialog())
             {
                 using (StreamWriter fileStream = new StreamWriter(saveFileDialog.FileName))
                 {
                     TextRange doc = new TextRange(rtbText.Document.ContentStart, rtbText.Document.ContentEnd);
                     fileStream.Write(doc.Text);
                 }
             }*/
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if ((bool)saveFileDialog.ShowDialog())
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}
