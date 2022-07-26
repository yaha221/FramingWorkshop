using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FramingWorkshop.View
{
    /// <summary>
    /// Логика взаимодействия для FrameWindow.xaml
    /// </summary>
    public partial class FrameWindow : Window
    {   
        public Frame Frame { get; private set; }
        public FrameWindow(Frame f)
        {
            InitializeComponent();
            Frame = f;
            this.DataContext = new FrameVM();
        }
        public FrameWindow()
        {
            InitializeComponent();
            this.DataContext = new FrameVM();
        }
    }
}
