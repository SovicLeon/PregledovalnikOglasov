﻿using System;
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
    enum FuelTypes
    {
        Bencin, Dizel, Hibrid, Elektrika
    }
    public partial class Adds : Window
    {
        //MainWindow mainWindow = new MainWindow();
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        //public event EventHandler<CarItem> newCarItemAdded;
        public Adds()
        {
            InitializeComponent();
            fuelBox.ItemsSource = Enum.GetValues(typeof(FuelTypes));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            CarItem carItem = new CarItem
            {
                Brand = brandBox.SelectedItem.ToString(),
                Year = int.Parse(yearInput.Text),
                Distance = int.Parse(distanceInput.Text),
                Fuel = fuelBox.SelectedItem.ToString(),
                Price = int.Parse(priceInput.Text),
                Details = fuelBox.SelectedItem.ToString(),
                ImageSrc = "/Citroen.jpg"
            };
            mainWindow.carItems.Add(carItem);
            //newCarItemAdded?.Invoke(this, mainWindow.carItems.Last());
            this.Close();
        }
    }
}