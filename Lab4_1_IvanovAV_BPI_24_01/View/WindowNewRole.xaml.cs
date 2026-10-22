
using System.Windows;

namespace Lab4_1_IvanovAV_BPI_24_01.View
{
    public partial class WindowNewRole : Window
    {
        public WindowNewRole()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender,
            RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
