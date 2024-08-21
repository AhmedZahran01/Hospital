using System.ComponentModel;

namespace Hospital.DataObjects
{
    public partial class Item : INotifyPropertyChanged
    {
          // Item class for update changes and staff state and staff actions

        public int Id { get; set; }

      
        private string itemName = string.Empty;
        public string ItemName
        {
            get { return itemName; }
            set
            {
                if (itemName != value)
                {
                    itemName = value;
                    OnPropertyChanged(nameof(ItemName));
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
