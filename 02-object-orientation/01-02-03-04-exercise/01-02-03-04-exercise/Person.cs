using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_exercise
{
    abstract class Person
    {
        string name;
        string surname;
        int age;
        string dni;

        public abstract double TaxAuthorities();

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                age = value;
            }
        }
        public string Dni { get => dni; set => dni = value; }

        public Person(string name, string surname, int age, string dni)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Dni = dni;
        }

        public Person()
           : this("", "", 0, "")
        {
        }


        public virtual void ShowPerson()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\nDni: {3}\n", Name, Surname, Age, Dni);
        }

        public virtual void InsertPerson()
        {
            Console.WriteLine("Insert the Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Insert the Surname: ");
            Surname = Console.ReadLine();

            Console.WriteLine("Insert the Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the Dni: ");
            Dni = Console.ReadLine();
        }


    }
}


