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

namespace targilKita5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { private double carPosition;
        public MainWindow()
        {
            InitializeComponent();
            carPosition = picCar.Margin.Left;
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            picWarning.Visibility = Visibility.Hidden;
            MessageBox.Show("Brakes!!!");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            carPosition -= 80;
            picCar.Margin = new Thickness(carPosition,282, 0, 0);
        }

        private void ButtonSlow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("slowing down!");
            picWarning.Visibility = Visibility.Visible;
            carPosition -= 40;
            picCar.Margin = new Thickness(carPosition,282, 0, 0);
        }
    }
}
