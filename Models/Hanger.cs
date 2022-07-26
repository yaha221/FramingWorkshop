using FramingWorkshop.Controller;

namespace FramingWorkshop.Models
{
    // Сущность "Подвесы"
    internal class Hanger :ViewModel
    {
        private string title;
        private float price;
        private int screws;

        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set => Set(ref title, value);
        }

        public float Price
        {
            get { return price; }
            set => Set(ref price, value);
        }

        public int Screws
        {
            get { return screws; }
            set => Set(ref screws, value);
        }        
    }
}
