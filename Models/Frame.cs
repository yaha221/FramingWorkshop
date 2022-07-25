using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FramingWorkshop
{
    // Сущность "Багет"
    public class Frame :INotifyPropertyChanged
    {
        private string title;
        private float correction;
        private float price;
        private int amountClip;

        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public float Correction
        {
            get { return correction; }
            set
            {
                correction = value;
                OnPropertyChanged("Correction");
            }        
        }

        public float Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public  int AmountClip
        {
            get { return amountClip; }
            set
            {
                amountClip = value;
                OnPropertyChanged("AmountClip");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
