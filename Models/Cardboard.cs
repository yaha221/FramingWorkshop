using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FramingWorkshop.Models
{
    // Сущность "Картон"
    public class Cardboard:INotifyPropertyChanged
    {
        private float dense;
        private float price;

        public int Id { get; set; }

        public float Dense
        {
            get { return dense; }
            set
            {
                dense = value;
                OnPropertyChanged("Dense");
            }
        }

        public float Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("PriceCB");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
