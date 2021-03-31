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
    /// Interaction logic for Vehicle_In.xaml
    /// </summary>
    public partial class Vehicle_In : UserControl
    {
        public Vehicle_In()
        {
            InitializeComponent();
        }


        private void bnt4_Click_1(object sender, RoutedEventArgs e)
        {
            EvenNotifier.RaisePageChanged("vehicleSlot");
        }

        private void txt3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
