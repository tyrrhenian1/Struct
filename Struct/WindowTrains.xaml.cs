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

namespace Struct
{
    /// <summary>
    /// Логика взаимодействия для WindowTrains.xaml
    /// </summary>
    public partial class WindowTrains : Window
    {
        public WindowTrains(Train z)
        {
            InitializeComponent();
            numberTrain.Text = z.number;
            dateArrival.SelectedDate = z.arrival;
            dateDeparture.SelectedDate = z.departure;
            direction.Text = z.direction;
            distance.Text = z.distance;
        }
        public WindowTrains()
        {
            InitializeComponent();
        }
        public string getNumber()
        {
            return numberTrain.Text;
        }
        public DateTime? getArrival()
        {
            return dateArrival.SelectedDate;
        }
        public DateTime? getDeparture()
        {
            return dateDeparture.SelectedDate;
        }
        public string getDirection()
        {
            return direction.Text.ToString();
        }
        public string getDistance()
        {
            return distance.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
