using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Brand == null)
            {
                Properties.Settings.Default.Brand = new StringCollection();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Brand.Add(brandInput.Text);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            var num = brandView.SelectedItems.Count;
            while (num > 0)
            {
                Properties.Settings.Default.Brand.RemoveAt(brandView.SelectedIndex);
                num--;
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if(brandInput.Text != "" && brandView.SelectedIndex >= 0)
            {
                Properties.Settings.Default.Brand[brandView.SelectedIndex] = brandInput.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }
    }
}
