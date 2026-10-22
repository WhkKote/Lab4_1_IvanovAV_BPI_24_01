
using System.Windows;
using Lab4_1_IvanovAV_BPI_24_01.Helper;
using Lab4_1_IvanovAV_BPI_24_01.View;

namespace Lab4_1_IvanovAV_BPI_24_01.ViewModel
{
    public class MainWindowViewModel
    {
        private RelayCommand openEmployee;

        public RelayCommand OpenEmployee
        {
            get
            {
                return openEmployee ??
                    (openEmployee = new RelayCommand(obj =>
                    {
                        WindowEmployee wnEmployee =
                            new WindowEmployee
                            {
                                Title = "Сотрудники"
                            };

                        wnEmployee.ShowDialog();
                    }));
            }
        }

        private RelayCommand openRole;

        public RelayCommand OpenRole
        {
            get
            {
                return openRole ??
                    (openRole = new RelayCommand(obj =>
                    {
                        WindowRole wnRole = new WindowRole
                        {
                            Title = "Должности"
                        };

                        wnRole.ShowDialog();
                    }));
            }
        }

        private RelayCommand exitApp;

        public RelayCommand ExitApp
        {
            get
            {
                return exitApp ??
                    (exitApp = new RelayCommand(obj =>
                    {
                        Application.Current.Shutdown();
                    }));
            }
        }
    }
}
