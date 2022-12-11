using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
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
using System.Xml.Serialization;

namespace PregledovalnikOglasov1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<CarItem> carItems = new ObservableCollection<CarItem>();
        public int selectedIndex = -1;
        //public ObservableList<CarItem> carItems = new ObservableList<CarItem>();
        public MainWindow()
        {
            InitializeComponent();
            /*carItems.Add(new CarItem
            {
                Brand = "Citroen",
                Year = 2017,
                Distance = 75000,
                Fuel = FuelTypes.Bencin,
                Price = 20000,
                Details = "Opis test",
                ImageSrc = "/Citroen.jpg"
            });*/
            listView.ItemsSource = carItems;
        }

        private void Izhod(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            Adds adds = new Adds();
            adds.ShowDialog();
            /*adds.newCarItemAdded += (s, item) =>
            {
                carItems.Add(item);
            };*/
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
            settings.ShowDialog();
        }

        private void Uredi(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                selectedIndex = listView.SelectedIndex;
                Adds adds = new Adds();
                adds.ShowDialog();
                selectedIndex = -1;
            }
        }

        private void Uvozi(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            // show the OpenFileDialog and get the result
            var result = openFileDialog.ShowDialog();

            if (result == true)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<CarItem>));
                    var lst = (List<CarItem>)xml.Deserialize(sr);
                    if (lst != null)
                    {
                        carItems = new ObservableCollection<CarItem>(lst);
                        listView.ItemsSource = carItems;
                    }
                }
            }
        }

        private void Izvozi(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";

            var result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<CarItem>));
                    xml.Serialize(sw, carItems.ToList());
                }
            }
        }
    }
}
