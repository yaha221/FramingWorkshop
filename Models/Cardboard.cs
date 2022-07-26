using FramingWorkshop.Controller;

namespace FramingWorkshop.Models
{
    // Сущность "Картон"
    internal class Cardboard:ViewModel
    {
        private float dense;
        private float price;

        public int Id { get; set; }

        public float Dense
        {
            get { return dense; }
            set => Set(ref dense, value);

        }

        public float Price
        {
            get { return price; }
            set => Set(ref price, value);
        }
    }
}
