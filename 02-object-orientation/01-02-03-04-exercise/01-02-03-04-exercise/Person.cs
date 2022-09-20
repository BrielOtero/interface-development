using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

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
        public string Dni
        {
            get
            {
                int rest = Convert.ToInt16(dni) % 23;
                string lettersDni = "TRWAGMYFPDXBNJZSQVHLCKE";

                return lettersDni[rest].ToString();
            }

            set
            {
                dni = value.Substring(0, value.Length - 1);
            }
        }

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


        public virtual void ShowValues()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\nDni: {3}\n", Name, Surname, Age, Dni);
        }


        public virtual void InsertValues()
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


