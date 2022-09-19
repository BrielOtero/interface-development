using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_exercise
{
    internal class Executive : Person, IGoosePasta
    {
        private string departmentName;
        private double profit;
        private int dependents;
        private double winPasta;

        public int Dependents
        {
            get => dependents;
            set
            {
                switch (value)
                {
                    case < 10:
                        profit = 2;
                        break;
                    case >= 11 and <= 50:
                        profit = 3.5;
                        break;
                    case > 50:
                        profit = 4;
                        break;
                }
                dependents = value;
            }
        }

        public override double TaxAuthorities()
        {
            return 0.3 * winPasta;
        }

        public static Executive operator --(Executive executive)
        {
            if (executive.profit >= 0)
            {
                executive.profit = executive.profit - 1;

            }
            return executive;
        }

        public override void ShowValues()
        {
            base.ShowValues();
            Console.WriteLine("Department Menu: {0}\nProfit: {1}\nDependents: {2}\n", departmentName, profit, dependents);
        }

        public override void InsertValues()
        {
            base.InsertValues();
            Console.WriteLine("Insert the Department Menu: ");
            departmentName = Console.ReadLine();

            Console.WriteLine("Insert the Dependents: ");
            dependents = Convert.ToInt32(Console.ReadLine());


        }



        double IGoosePasta.WinPasta(double profitEUR)
        {
            if (profitEUR < 0)
            {
                Executive e = this;
                e--;

                winPasta = 0;
                return winPasta;
            }

            winPasta = (profit * profitEUR) / 100;
            return winPasta;
        }

    }
}
}
