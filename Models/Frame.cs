using FramingWorkshop.Controller;

namespace FramingWorkshop
{
    // Сущность "Багет"
    internal class Frame :ViewModel
    {
        private string title;
        private float correction;
        private float price;
        private int amountClip;

        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set => Set(ref title, value);

        }

        public float Correction
        {
            get { return correction; }
            set => Set(ref correction, value);      
        }

        public float Price
        {
            get { return price; }
            set => Set(ref price, value);

        }

        public  int AmountClip
        {
            get { return amountClip; }
            set => Set(ref amountClip, value);

        }
    }
}
