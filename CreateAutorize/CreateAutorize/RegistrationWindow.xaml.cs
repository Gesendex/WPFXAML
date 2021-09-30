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

namespace CreateAutorize
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    
    public partial class RegistrationWindow : Window
    {
        Model1Container db = new Model1Container();
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            if (login.Text == "" || password.Password == "" || lastName.Text == "" || firstName.Text == "" || middleName.Text == "")
            {
                MessageBox.Show("Ошибка пустые поля");
                return;
            }
            if(db.Users.Select(item => item.Login).Contains(login.Text))
            {
                MessageBox.Show("Такой логин существует в системе");
                return;
            }
            Users newUser = new Users()
            {
                Login = login.Text,
                Password = password.Password,
                LastName = lastName.Text,
                FirstName = firstName.Text,
                MiddleName = middleName.Text
            };
            db.Users.Add(newUser);
            db.SaveChanges();
            MessageBox.Show("Вы успешно зарегестрировались");
            AuthorizationWindow aw = new AuthorizationWindow();
            aw.Show();
            Close();
        }
        

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow aw = new AuthorizationWindow();
            aw.Show();
            Close();
        }
    }
}