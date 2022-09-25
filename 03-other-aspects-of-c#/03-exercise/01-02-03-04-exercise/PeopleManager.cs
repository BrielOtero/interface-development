using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_exercise
{
    internal class PeopleManager
    {

       public List<Person> people = new List<Person>();

        int Position(int age)
        {

            Person p = people.Find(x => age > x.Age);

            if (p != null)
            {
                return people.IndexOf(p);
            }
            else
            {
                return -1;
            }

        }

        int Position(string surname)
        {
            Person p = people.Find(x =>  x.Surname.Contains(surname));

            if (p != null)
            {
                return people.IndexOf(p);
            }
            else
            {
                return -1;
            }

        }

        bool Delete(int min, int max)
        {
            return false;
        }
    }

}
