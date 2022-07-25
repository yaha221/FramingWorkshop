using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FramingWorkshop.Models
{
    // Сущность "Подвесы"
    public class Hanger :INotifyPropertyChanged
    {
        private string title;
        private float price;
        private int screws;

        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("TitleH");
            }
        }

        public float Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("PriceH");
            }
        }

        public int Screws
        {
            get { return screws; }
            set
            {
                screws = value;
                OnPropertyChanged("Screws");
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
