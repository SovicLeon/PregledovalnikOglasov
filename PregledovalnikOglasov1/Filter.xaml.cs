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

namespace PregledovalnikOglasov1
{
    /// <summary>
    /// Interaction logic for Filter.xaml
    /// </summary>
    public partial class Filter : UserControl
    {
        public Filter()
        {
            InitializeComponent();
            fuelBox.ItemsSource = Enum.GetValues(typeof(FuelTypes));
        }

        public delegate void FilterChanged(object sender, String filter);
        public event FilterChanged OnFilterChanged;

        private void brandBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == brandBox && brandBox.SelectedItem is String s)
            {
                String filter = s;
                OnFilterChanged?.Invoke(this, filter);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
