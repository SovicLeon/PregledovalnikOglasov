using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregledovalnikOglasov1
{
    public class CarItem : INotifyPropertyChanged
    {
        private string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
                OnPropertyChanged("Brand");
            }
        }

        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }

        private int _distance;
        public int Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = value;
                OnPropertyChanged("Distance");
            }
        }

        private FuelTypes _fuel;
        public FuelTypes Fuel
        {
            get
            {
                return _fuel;
            }
            set
            {
                _fuel = value;
                OnPropertyChanged("Fuel");
            }
        }

        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        private string _details;
        public string Details
        {
            get
            {
                return _details;
            }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        private string _imageSrc;
        public string ImageSrc
        {
            get
            {
                return _imageSrc;
            }
            set
            {
                _imageSrc = value;
                OnPropertyChanged("ImageSrc");
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return "Znamka: " + Brand + "\nLetnik: " + Year + "\nKilometri: " + Distance + "\nGorivo: " + Fuel + "\nCena: " + Price + "\nOpis: " + Details;
        }
    }
}
