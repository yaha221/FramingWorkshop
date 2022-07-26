using FramingWorkshop.Controller;

namespace FramingWorkshop.Models
{
    // Сущность "Переферия" (стекло,лепестки,скобы)
    internal class Periphery : ViewModel
    {
        private string title;
        private double price;

        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set => Set(ref title, value);
        }

        public double Price
        {
            get { return price; }
            set => Set(ref price, value);            
        }       
    }
}
