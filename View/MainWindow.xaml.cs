using System.Windows;
using FramingWorkshop.Controller;

namespace FramingWorkshop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new FramingWorkshopVM();
        }
    }
}
