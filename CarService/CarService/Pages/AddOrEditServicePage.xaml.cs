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
    /// Логика взаимодействия для AddOrEditServicePage.xaml
    /// </summary>
    public partial class AddOrEditServicePage : Page
    {
        private Entities.Service _currentService = null;
        public AddOrEditServicePage()
        {
            InitializeComponent();
        }
        public AddOrEditServicePage(Entities.Service service)
        {
            InitializeComponent();
            Title = "Редактировать услугу";
            _currentService = service;
            TBoxTitle.Text = _currentService.Title;
            TBoxCost.Text = _currentService.Cost.ToString("N2");
            TBoxDuration.Text = (_currentService.DurationInSeconds / 60).ToString();
            TBoxDescription.Text = _currentService.Description;
            if(_currentService.Discount > 0)
            {
                TBoxDiscount.Text = (_currentService.Discount.Value * 100).ToString();
            }
            if(_currentService.MainImage !=null)
            {
                ImageService.Source = new ImageSourceConverter().ConvertFrom(_currentService.MainImage) as ImageSource;
            }
        }

        private void BtnSelectImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = CheckErrors();
            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (_currentService == null)
                {
                    var service = new Entities.Service()
                    {
                        Title = TBoxTitle.Text,
                        Cost = decimal.Parse(TBoxCost.Text),
                        DurationInSeconds = int.Parse(TBoxDuration.Text) * 60,
                        Discount = string.IsNullOrWhiteSpace(TBoxDiscount.Text) ? 0 : double.Parse(TBoxDiscount.Text) / 100,
                        Description = TBoxDescription.Text
                    };
                    App.Context.Services.Add(service);
                    App.Context.SaveChanges();
                    MessageBox.Show("Услуга успешно добавлена", "Информационное окно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    _currentService.Title = TBoxTitle.Text;
                    _currentService.Cost = decimal.Parse(TBoxCost.Text);
                    _currentService.DurationInSeconds = int.Parse(TBoxDuration.Text) * 60;
                    _currentService.Discount = string.IsNullOrWhiteSpace(TBoxDiscount.Text) ? 0 : double.Parse(TBoxDiscount.Text) / 100;
                    _currentService.Description = TBoxDescription.Text;
                    App.Context.SaveChanges();
                    //Сообщение о редактировании
                }
                
                NavigationService.GoBack();
            }
        }

        private string CheckErrors()
        {
            StringBuilder errorBuilder = new StringBuilder();

            if(string.IsNullOrWhiteSpace(TBoxTitle.Text))
                errorBuilder.AppendLine("- Название услуги обязательно для заполнения;");

            var serviceFromDB = App.Context.Services.ToList().FirstOrDefault(p => p.Title.ToLower() == TBoxTitle.Text.ToLower());
            if (serviceFromDB != null && serviceFromDB != _currentService)
                errorBuilder.AppendLine("- Такая услуга уже есть в БД;");

            decimal cost = 0;
            if (decimal.TryParse(TBoxCost.Text, out cost) == false || cost <= 0)
                errorBuilder.AppendLine("- Стоимость услуги должна быть положительным числом;");

            int durationInMinutes = 0;
            if (int.TryParse(TBoxDuration.Text, out durationInMinutes) == false || durationInMinutes > 240 || durationInMinutes < 0)
                errorBuilder.AppendLine("- Длительность оказания услуги должна быть положительным числом (не больше, чем 4 часа);");

            if(!string.IsNullOrEmpty(TBoxDiscount.Text))
            {
                int discount = 0;
                if(int.TryParse(TBoxDiscount.Text, out discount) == false || discount <0 ||discount > 100)
                {
                    errorBuilder.AppendLine("- Размер скидки - целое число в диапазое от 0 до 100%;");
                }
            }

            if (errorBuilder.Length > 0)
                errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

            return errorBuilder.ToString();
        }
    }
}
