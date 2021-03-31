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
    /// Interaction logic for vehicleSlot.xaml
    /// </summary>
    public partial class vehicleSlot : UserControl
    {
        public vehicleSlot()
        {
            InitializeComponent();
        }

        private void bnt5_Click(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("LoginPage");
        }

        private void Bnt1_Click(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("Vehicle_In");
        }

        private void Bnt2_Click(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("Vehicle_Out");
        }

        private void Bnt4_Click_1(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("ViewSlot");
        }
    }
}
