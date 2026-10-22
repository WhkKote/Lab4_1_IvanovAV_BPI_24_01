
using System.Windows;
using Lab4_1_IvanovAV_BPI_24_01.ViewModel;

namespace Lab4_1_IvanovAV_BPI_24_01.View
{
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            DataContext = new RoleViewModel();
        }
    }
}
