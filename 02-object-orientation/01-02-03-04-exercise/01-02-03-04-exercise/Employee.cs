using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace _01_02_03_04_exercise
{
    internal class Employee : Person
    {
        private double salary;
        private int irpf;
        private string phoneNumber;

        public double Salary
        {
            get => salary;

            set
            {
                switch (value)
                {
                    case < 600:
                        irpf = 7;
                        break;
                    case >= 600 and <= 3000:
                        irpf = 15;
                        break;
                    case > 3000:
                        irpf = 20;
                        break;
                }

                salary = value;
            }
        }

        public int Irpf { get => irpf; set => irpf = value; }
        public string PhoneNumber
        {
            get
            {
                return "+34" + phoneNumber;
            }
            set => phoneNumber = value;
        }

        public override void showValues()
        {
            base.showValues();
            Console.WriteLine("Salary: {0}\nIrpf: {1}\nPhone Number: {2}\n", Salary, Irpf, PhoneNumber);
        }

        public override void showValues(int show)
        {
           
            Console.WriteLine("Salary: {0}\nIrpf: {1}\nPhone Number: {2}\n", Salary, Irpf, PhoneNumber);
        }

        public override double TaxAuthorities()
        {
            return (Irpf * Salary) / 100;
        }
    }
}
