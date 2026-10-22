
using System.Windows;
using Lab4_1_IvanovAV_BPI_24_01.Helper;
using Lab4_1_IvanovAV_BPI_24_01.ViewModel;
using Lab4_1_IvanovAV_BPI_24_01.Model;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace Lab4_1_IvanovAV_BPI_24_01.View
{
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();

            PersonViewModel vmPerson = new PersonViewModel();
            RoleViewModel vmRole = new RoleViewModel();

            List<Role> roles = new List<Role>();

            foreach (Role r in vmRole.ListRole)
            {
                roles.Add(r);
            }

            ObservableCollection<PersonDPO> persons =
                new ObservableCollection<PersonDPO>();

            FindRole finder;

            foreach (var p in vmPerson.ListPerson)
            {
                finder = new FindRole(p.RoleId);

                Role rol = roles.Find(
                    new Predicate<Role>(finder.RolePredicate));

                persons.Add(new PersonDPO
                {
                    Id = p.Id,
                    Role = rol.NameRole,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Birthday = p.Birthday
                });
            }

            lvEmployee.ItemsSource = persons;
        }
    }
}
