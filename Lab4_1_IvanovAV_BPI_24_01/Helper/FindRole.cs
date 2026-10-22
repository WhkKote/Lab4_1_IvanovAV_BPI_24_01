
using System.Windows;
using Lab4_1_IvanovAV_BPI_24_01.Model;

namespace Lab4_1_IvanovAV_BPI_24_01.Helper
{
    public class FindRole
    {
        int id;

        public FindRole(int id)
        {
            this.id = id;
        }

        public bool RolePredicate(Role role)
        {
            return role.Id == id;
        }
    }
}
