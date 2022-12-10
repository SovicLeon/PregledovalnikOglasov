using System.Collections.Generic;
using System.ComponentModel;

namespace PregledovalnikOglasov1
{
    public class ObservableList<T> : List<T>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public new void Add(T item)
        {
            base.Add(item);
            OnPropertyChanged("Count");
            OnPropertyChanged("Item[]");
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            OnPropertyChanged("Count");
            OnPropertyChanged("Item[]");
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
