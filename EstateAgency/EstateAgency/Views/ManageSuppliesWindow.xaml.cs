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
    /// Логика взаимодействия для ManageSuppliesWindow.xaml
    /// </summary>
    public partial class ManageSuppliesWindow : Window
    {
        public ManageSuppliesWindow()
        {
            InitializeComponent();
            DgSupplies.ItemsSource = App.Context.SupplySets.ToList();
            DgSupplies.SelectedIndex = 0;
            CbAgent.ItemsSource = App.Context.PersonSet_Agent.ToList(); 
            CbClient.ItemsSource = App.Context.PersonSet_Client.ToList();
        }

        private void DgSupplies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var curSupp = (sender as DataGrid).SelectedItem as SupplySet;
            if(curSupp.RealEstateSet.RealEstateSet_Apartment != null)
            {
                SpHouse.Visibility = Visibility.Collapsed;
                SpAppart.Visibility = Visibility.Visible;
                TbTotalArea.Text = curSupp.RealEstateSet.RealEstateSet_Apartment.TotalArea.ToString();
                TbRooms.Text = curSupp.RealEstateSet.RealEstateSet_Apartment.Rooms.ToString();
                TbFloor.Text = curSupp.RealEstateSet.RealEstateSet_Apartment.Floor.ToString();
            }
            else if(curSupp.RealEstateSet.RealEstateSet_House != null)
            {
                SpHouse.Visibility = Visibility.Visible;
                SpAppart.Visibility = Visibility.Collapsed;
                TbTotalArea.Text = curSupp.RealEstateSet.RealEstateSet_House.TotalArea.ToString();
                TbFloors.Text = curSupp.RealEstateSet.RealEstateSet_House.TotalFloors.ToString();
            }
            else
            {
                TbTotalArea.Text = curSupp.RealEstateSet.RealEstateSet_Land.TotalArea.ToString();
            }
            TbAgent.Text = curSupp.PersonSet_Agent.PersonSet.FullName;
            TbClient.Text = curSupp.PersonSet_Client.PersonSet.FullName;
            TbPrice.Text = curSupp.Price.ToString();
            TbRealEstate.Text = curSupp.RealEstateSet.Info;
            TbCity.Text = curSupp.RealEstateSet.Address_City;
            TbHouse.Text = curSupp.RealEstateSet.Address_House;
            TbStreet.Text = curSupp.RealEstateSet.Address_Street;
            TbNumber.Text = curSupp.RealEstateSet.Address_Number;
            TbLongtitude.Text = curSupp.RealEstateSet.Coordinate_longitude.ToString();
            TbLatitude.Text = curSupp.RealEstateSet.Coordinate_latitude.ToString();
        }
    }
}
