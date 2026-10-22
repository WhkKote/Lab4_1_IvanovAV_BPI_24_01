
using System.Windows;
using Lab4_1_IvanovAV_BPI_24_01.ViewModel;

namespace Lab4_1_IvanovAV_BPI_24_01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
