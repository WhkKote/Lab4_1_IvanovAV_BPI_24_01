
using System.Windows;
using Lab4_1_IvanovAV_BPI_24_01.Model;
using Lab4_1_IvanovAV_BPI_24_01.ViewModel;

namespace Lab4_1_IvanovAV_BPI_24_01.View
{
    public partial class WindowNewEmployee : Window
    {
        public WindowNewEmployee()
        {
            InitializeComponent();

            RoleViewModel vmRole = new RoleViewModel();
            CbRole.ItemsSource = vmRole.ListRole;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is PersonDpo person)
            {
                foreach (Role role in CbRole.Items)
                {
                    if (role.NameRole == person.RoleName)
                    {
                        CbRole.SelectedItem = role;
                        break;
                    }
                }
            }

            if (CbRole.SelectedIndex < 0 &&
                CbRole.Items.Count > 0)
            {
                CbRole.SelectedIndex = 0;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
