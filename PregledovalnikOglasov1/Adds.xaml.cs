using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PregledovalnikOglasov1
{
    /// <summary>
    /// Interaction logic for Adds.xaml
    /// </summary>
    /// 
    public enum FuelTypes
    {
        Bencin, Dizel, Hibrid, Elektrika
    }
    public partial class Adds : Window
    {
        //MainWindow mainWindow = new MainWindow();
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        int editIndex = 0;
        //public event EventHandler<CarItem> newCarItemAdded;
        public Adds()
        {
            InitializeComponent();
            fuelBox.ItemsSource = Enum.GetValues(typeof(FuelTypes));
            if (mainWindow.selectedIndex >= 0)
            {
                brandBox.SelectedItem = mainWindow.carItems[mainWindow.selectedIndex].Brand;
                yearInput.Text = mainWindow.carItems[mainWindow.selectedIndex].Year.ToString();
                distanceInput.Text = mainWindow.carItems[mainWindow.selectedIndex].Distance.ToString();
                fuelBox.SelectedItem = mainWindow.carItems[mainWindow.selectedIndex].Fuel;
                priceInput.Text = mainWindow.carItems[mainWindow.selectedIndex].Price.ToString();
                detailsInput.Text = mainWindow.carItems[mainWindow.selectedIndex].Details;
                carImage.Source = new BitmapImage(new Uri(mainWindow.carItems[mainWindow.selectedIndex].ImageSrc));
                addButton.Visibility = Visibility.Collapsed;
                editIndex = mainWindow.selectedIndex;
                this.Title = "Urejanje oglasa";
            } else
            {
                editButton.Visibility = Visibility.Collapsed;
                this.Title = "Dodajanje oglasa";
            }
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int year = 0;
            if (int.TryParse(yearInput.Text, out year))
            {
                year = int.Parse(yearInput.Text);
            }
            else
            {
                year = 0;
            }
            int distance = 0;
            if (int.TryParse(distanceInput.Text, out distance))
            {
                distance = int.Parse(distanceInput.Text);
            }
            else
            {
                distance = 0;
            }
            int price = 0;
            if (int.TryParse(priceInput.Text, out price))
            {
                price = int.Parse(priceInput.Text);
            }
            else
            {
                price = 0;
            }
            CarItem carItem = new CarItem
            {
                Brand = brandBox.SelectedItem == null ? "Znamka" : brandBox.SelectedItem.ToString(),
                Year = year,
                Distance = distance,
                Fuel = fuelBox.SelectedItem == null ? FuelTypes.Dizel : (FuelTypes)fuelBox.SelectedItem,
                Price = price,
                Details = detailsInput.Text == null ? "Opis" : detailsInput.Text,
                ImageSrc = carImage.Source == null ? "abc" : carImage.Source.ToString()
            };
            mainWindow.carItems.Add(carItem);
            //newCarItemAdded?.Invoke(this, mainWindow.carItems.Last());
            this.Close();
        }

        private void Image_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.bmp, *.gif)|*.png;*.jpg;*.bmp;*.gif";

            // show the OpenFileDialog and get the result
            var result = openFileDialog.ShowDialog();

            // if the user selected a file, open it
            if (result == true)
            {
                // set the source of the image to the selected file
                carImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.carItems[editIndex].Brand = brandBox.SelectedItem.ToString();
            mainWindow.carItems[editIndex].Year = int.Parse(yearInput.Text);
            mainWindow.carItems[editIndex].Distance = int.Parse(distanceInput.Text);
            mainWindow.carItems[editIndex].Fuel = (FuelTypes)fuelBox.SelectedItem;
            mainWindow.carItems[editIndex].Price = int.Parse(priceInput.Text);
            mainWindow.carItems[editIndex].Details = detailsInput.Text;
            mainWindow.carItems[editIndex].ImageSrc = carImage.Source.ToString();
            this.Close();
        }
    }
}
