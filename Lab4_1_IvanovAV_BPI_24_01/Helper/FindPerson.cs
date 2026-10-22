
using Lab4_1_IvanovAV_BPI_24_01.Model;

namespace Lab4_1_IvanovAV_BPI_24_01.Helper
{
    public class FindPerson
    {
        int id;

        public FindPerson(int id)
        {
            this.id = id;
        }

        public bool PersonPredicate(Person person)
        {
            return person.Id == id;
        }
    }
}
