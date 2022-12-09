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
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            brandView.Items.Add(brandInput.Text);
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            var num = brandView.Items.Count;
            while (num > 0)
            {
                brandView.Items.Remove(brandInput.Text);
                num--;
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int index = brandView.SelectedIndex;
            ListViewItem newItem = new ListViewItem();
            newItem.Content = brandInput.Text;
            brandView.Items[index] = newItem;
        }
    }
}
