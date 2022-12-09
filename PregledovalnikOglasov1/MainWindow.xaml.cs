using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace PregledovalnikOglasov1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<CarItem> carItems = new ObservableCollection<CarItem>();
        public MainWindow()
        {
            InitializeComponent();
            carItems.Add(new CarItem
            {
                Brand = "Citroen",
                Year = 2017,
                Distance = 75000,
                Fuel = "bencin",
                Price = 20000,
                Details = "Opis test",
                ImageSrc = "/Citroen.jpg"
            });
            listView.ItemsSource = carItems;
        }

        private void Izhod(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            string[] brands = {"Audi", "BMW", "Citroen"};
            string[] fuels = {"bencin", "diesel", "hibridni pogon", "e-pogon pogon"};
            Random rnd = new Random();
            string newBrand = brands[rnd.Next(0, 3)];
            int newYear = rnd.Next(2000, 2022);
            carItems.Add(new CarItem
            {
                Brand = newBrand,
                Year = newYear,
                Distance = rnd.Next(0, 300000),
                Fuel = fuels[rnd.Next(0, 4)],
                Price = rnd.Next(1000, 50000),
                Details = "To je test opisa",
                ImageSrc = "/" + newBrand + ".jpg",
                Title = newBrand + newYear
            });                            
        }

        private void Odstrani(object sender, RoutedEventArgs e)
        {
            if(carItems.Count > 0 && listView.SelectedItems.Count > 0)
            {
                carItems.Remove((CarItem)listView.SelectedItem);
            }
            else
            {
                MessageBox.Show("Za odstranitev izberite oglas!");
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (carItems.Count > 0 && listView.SelectedItems.Count > 0)
            {
                MessageBox.Show(listView.SelectedItem.ToString());
            }
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
