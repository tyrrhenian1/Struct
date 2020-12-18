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

namespace Struct
{
 
    public struct Train
    {
        public string number;
        public DateTime? arrival;
        public DateTime? departure;
        public string direction;
        public string distance;
    }
    public partial class MainWindow : Window
    {
        Train[] trains;
        int i = 0;
        int count;
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                try
                {
                    count = int.Parse(Count.Text);
                    trains = new Train[count];
                    AddTrain();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                AddTrain();
            }
                if (i == count)
                {
                    Add.IsEnabled = false;
                }
            }
        public void AddTrain()
        {
            if (i < count)
            {
                WindowTrains window = new WindowTrains();
                if (window.ShowDialog() == true)
                {
                    Train z = new Train();
                    z.number = window.getNumber();
                    z.arrival = window.getArrival();
                    z.departure = window.getDeparture();
                    z.direction = window.getDirection();
                    z.distance = window.getDistance();
                    trains[i] = z;
                    Trains.Items.Add(z.number);
                }
                i++;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = false;
        }

        private void Count_TextChanged(object sender, TextChangedEventArgs e)
        {
            Add.IsEnabled = true;
        }

        private void Trains_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string f = Trains.SelectedItems[0].ToString();
            Train z;
            for (int i = 0; i < count; i++)
            {
                if (trains[i].number.ToString().Equals(f))
                {
                    z = trains[i];
                    WindowTrains w = new WindowTrains(z);
                    w.Show();
                    break;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Trains.Items.Clear();
            for (int i = 0; i < count; i++) Trains.Items.Add(trains[i].number +  "                  " + rnd.Next(50,201).ToString() + "км/ч");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Trains.Items.Clear();
            for (int i = 0; i < count; i++) Trains.Items.Add(trains[i].number);
        }
    }
    }
