using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Filter.xaml
    /// </summary>
    public partial class Filter : UserControl
    {

        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        bool fuelSet = false;
        bool searchSet = false;
        public Filter()
        {
            InitializeComponent();
            fuelBox.ItemsSource = Enum.GetValues(typeof(FuelTypes));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchInput.Text != "" && mainWindow.listView != null)
            {
                searchSet = true;
                setFilter();
            } else if (mainWindow.listView != null)
            {
                searchSet = false;
                if (!fuelSet && !searchSet)
                {
                    mainWindow.listView.ItemsSource = mainWindow.carItems;
                }                
            }
        }

        private void fuelBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fuelBox.SelectedItem != null && mainWindow.listView != null)
            {
                fuelSet = true;
                setFilter();
            }
            else if (mainWindow.listView != null)
            {
                fuelSet = false;
                if (!fuelSet && !searchSet)
                {
                    mainWindow.listView.ItemsSource = mainWindow.carItems;
                }
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            searchInput.Text = "";
            fuelBox.Text = "";
            fuelSet = false;
            searchSet = false;
        }

        private void setFilter()
        {
            if (!fuelSet)
            {
                ObservableCollection<CarItem> filteredCollection = new ObservableCollection<CarItem>(mainWindow.carItems.Where(x => x.ToString().ToUpper().Contains(searchInput.Text.ToUpper())));
                mainWindow.listView.ItemsSource = filteredCollection;
                mainWindow.listView.Items.Refresh();
            } else if (!searchSet)
            {
                ObservableCollection<CarItem> filteredCollection = new ObservableCollection<CarItem>(mainWindow.carItems.Where(x => x.Fuel.Equals(fuelBox.SelectedItem)));
                mainWindow.listView.ItemsSource = filteredCollection;
                mainWindow.listView.Items.Refresh();
            } else
            {
                ObservableCollection<CarItem> filteredCollection = new ObservableCollection<CarItem>(mainWindow.carItems.Where(x => x.ToString().ToUpper().Contains(searchInput.Text.ToUpper()) && x.Fuel.Equals(fuelBox.SelectedItem)));
                mainWindow.listView.ItemsSource = filteredCollection;
                mainWindow.listView.Items.Refresh();
            }
        }
    }
}