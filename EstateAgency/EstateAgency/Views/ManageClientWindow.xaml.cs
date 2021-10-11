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

namespace EstateAgency.Views
{
    /// <summary>
    /// Логика взаимодействия для ManageClientWindow.xaml
    /// </summary>
    public partial class ManageClientWindow : Window
    {
        public ManageClientWindow()
        {
            InitializeComponent();
            LbClients.ItemsSource = App.Context.PersonSet_Client.ToList();
            LbClients.SelectedIndex = 0;
        }

        private void LbClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currClient = LbClients.SelectedItem as PersonSet_Client;
            if (currClient != null)
            {
                TbFirstName.Text = currClient.PersonSet.FirstName;
                TbMiddleName.Text = currClient.PersonSet.MiddleName;
                TbLastName.Text = currClient.PersonSet.LastName;
                TbEmail.Text = currClient.Email;
                TbPhone.Text = currClient.Phone;
                DgDemands.ItemsSource = currClient.DemandSets.ToList();
                DgSupplies.ItemsSource = currClient.SupplySets.ToList();
            }
        }
    }
}
