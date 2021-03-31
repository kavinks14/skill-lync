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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            EvenNotifier.PageChanged += EventNotifier_PageChange;
        }

        private void EventNotifier_PageChange(string pageName)
        {
            switch (pageName)
            {
                case "vehicleSlot":
                    this.LoginPage.Visibility = Visibility.Collapsed;
                    this.Vehicle_In.Visibility = Visibility.Collapsed;
                    this.Vehicle_Out.Visibility = Visibility.Collapsed;
                    this.ViewSlot.Visibility = Visibility.Collapsed;
                    this.Receipt.Visibility = Visibility.Collapsed;
                    this.vehicleSlot.Visibility = Visibility.Visible;
                    break;
                case "LoginPage":
                    this.vehicleSlot.Visibility = Visibility.Collapsed;
                    this.Vehicle_In.Visibility = Visibility.Collapsed;
                    this.Vehicle_Out.Visibility = Visibility.Collapsed;
                    this.ViewSlot.Visibility = Visibility.Collapsed;
                    this.Receipt.Visibility = Visibility.Collapsed;
                    this.LoginPage.Visibility = Visibility.Visible;
                    break;
                case "Vehicle_In":
                    this.vehicleSlot.Visibility = Visibility.Collapsed;
                    this.Vehicle_Out.Visibility = Visibility.Collapsed;
                    this.ViewSlot.Visibility = Visibility.Collapsed;
                    this.LoginPage.Visibility = Visibility.Collapsed;
                    this.Receipt.Visibility = Visibility.Collapsed;
                    this.Vehicle_In.Visibility = Visibility.Visible;
                    break;
                case "Vehicle_Out":
                    this.vehicleSlot.Visibility = Visibility.Collapsed;
                    this.Vehicle_In.Visibility = Visibility.Collapsed;
                    this.ViewSlot.Visibility = Visibility.Collapsed;
                    this.LoginPage.Visibility = Visibility.Collapsed;
                    this.Receipt.Visibility = Visibility.Collapsed;
                    this.Vehicle_Out.Visibility = Visibility.Visible;
                    break;
                case "ViewSlot":
                    this.vehicleSlot.Visibility = Visibility.Collapsed;
                    this.Vehicle_In.Visibility = Visibility.Collapsed;
                    this.Vehicle_Out.Visibility = Visibility.Collapsed;
                    this.LoginPage.Visibility = Visibility.Collapsed;
                    this.Receipt.Visibility = Visibility.Collapsed;
                    this.ViewSlot.Visibility = Visibility.Visible;
                    break;
                case "Receipt":
                    this.Vehicle_Out.Visibility = Visibility.Collapsed;
                    this.vehicleSlot.Visibility = Visibility.Collapsed;
                    this.Vehicle_In.Visibility = Visibility.Collapsed;
                    this.LoginPage.Visibility = Visibility.Collapsed;
                    this.ViewSlot.Visibility = Visibility.Collapsed;
                    this.Receipt.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

    }
}
