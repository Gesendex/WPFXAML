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
    /// Логика взаимодействия для ManageAgentWindow.xaml
    /// </summary>
    public partial class ManageAgentWindow : Window
    {
        public ManageAgentWindow()
        {
            InitializeComponent();
            LbAgents.ItemsSource = App.Context.PersonSet_Agent.ToList();
            LbAgents.SelectedIndex = 0;
            
        }

        private void LbAgents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var curAgent = LbAgents.SelectedItem as PersonSet_Agent;
            if(curAgent != null)
            {
                TbFirstName.Text = curAgent.PersonSet.FirstName;
                TbMiddleName.Text = curAgent.PersonSet.MiddleName;
                TbLastName.Text = curAgent.PersonSet.LastName;
                TbDealShare.Text = curAgent.DealShare.ToString();
                DgDemands.ItemsSource = curAgent.DemandSets.ToList();
                DgSupplies.ItemsSource = curAgent.SupplySets.ToList();
            }
        }
    }
}
