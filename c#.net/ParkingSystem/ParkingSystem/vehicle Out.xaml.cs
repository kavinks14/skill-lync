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

namespace ParkingSystem
{
    /// <summary>
    /// Interaction logic for vehicle_Out.xaml
    /// </summary>
    public partial class vehicle_Out : UserControl
    {
        public vehicle_Out()
        {
            InitializeComponent();
        }

        private void bnt3_Click(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("vehicleSlot");
        }

        private void bnt1_Click(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("Receipt");
        }
    }
}
