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
            // Properties.Settings.Default.Brand = new StringCollection();
            for (int i = 0; i < Properties.Settings.Default.Brand.Split(' ').Length; i++)
            {
                brandView.Items.Add(Properties.Settings.Default.Brand.Split(' ')[i]);
            }
            
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            brandView.Items.Add(brandInput.Text);
            Properties.Settings.Default.Brand = Properties.Settings.Default.Brand + " " + brandInput.Text;
            Properties.Settings.Default.Save();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            var num = brandView.SelectedItems.Count;
            List<String> newBrandList = Properties.Settings.Default.Brand.Split(' ').ToList();
            while (num > 0)
            {
                newBrandList.RemoveAll(x => x.Equals(brandView.SelectedItem.ToString()));
                brandView.Items.Remove(brandView.SelectedItem);
                num--;
            }
            Properties.Settings.Default.Brand = string.Join(" ",newBrandList);
            Properties.Settings.Default.Save();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if(brandInput.Text != "")
            {
                List<String> newBrandList = Properties.Settings.Default.Brand.Split(' ').ToList();
                int index = brandView.SelectedIndex;
                ListViewItem newItem = new ListViewItem();
                newBrandList[index] = brandInput.Text;
                newItem.Content = brandInput.Text;
                brandView.Items[index] = newItem;
                Properties.Settings.Default.Brand = string.Join(" ", newBrandList);
                Properties.Settings.Default.Save();
            }
        }
    }
}
