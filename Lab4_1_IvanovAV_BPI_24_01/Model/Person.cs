
using System;
using Lab4_1_IvanovAV_BPI_24_01.ViewModel;

namespace Lab4_1_IvanovAV_BPI_24_01.Model
{
    public class Person
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person() { }

        public Person(int id, int roleId, string firstName,
            string lastName, DateTime birthday)
        {
            this.Id = id;
            this.RoleId = roleId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public Person CopyFromPersonDPO(PersonDpo personDpo)
        {
            RoleViewModel vmRole = new RoleViewModel();

            foreach (var role in vmRole.ListRole)
            {
                if (role.NameRole == personDpo.RoleName)
                {
                    this.RoleId = role.Id;
                    break;
                }
            }

            this.Id = personDpo.Id;
            this.FirstName = personDpo.FirstName;
            this.LastName = personDpo.LastName;
            this.Birthday = personDpo.Birthday;

            return this;
        }
    }
}
