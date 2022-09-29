using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exercise
{
    internal class Classroom
    {
        int[,] notes;
        string[] students;

        public int[,] Notes {
            get => notes; 
            set => notes = value; 
        }

        public int this[int columns, int rows]
        {
            set
            {
                notes[columns, rows] = value;
            }

            get
            {
                return notes[columns, rows];

            }
        }

        public Classroom(string[] students)
        {
            this.notes = new int[4, students.Length];
            this.students = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                this.students[i] = students[i].Trim().ToUpper();
            }

            Random random = new Random();

            for (int i = 0; i < this.notes.GetLength(0); i++)
            {
                for (int j = 0; j < this.notes.GetLength(1); j++)
                {
                    this.notes[i, j] = random.Next(11);
                }
            }

        }

        public Classroom(string students)
            : this(students.Split(","))
        {

        }

        public double GetAverageTable()
        {
            double average = 0;

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    average += notes[i, j];
                }
            }

            average /= notes.Length;

            return average;
        }

        public double GetAverageStudent(int index)
        {
            double average = 0;

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                average += notes[i, index];
            }

            average /= notes.GetLength(0);

            return average;
        }

        public double GetAverageSubject(int index)
        {
            double average = 0;

            for (int i = 0; i < notes.GetLength(1); i++)
            {
                average += notes[index, i];
            }

            average /= notes.GetLength(1);

            return average;
        }



        public void GetMaxMinStudent(int index, out int min, out int max)
        {
            max = -1;
            min = -1;

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                if (notes[i, index] > max || max == -1)
                {
                    max = notes[i, index];
                }

                if (notes[i, index] < min || min == -1)
                {
                    min = notes[i, index];
                }
            }
        }

    }
}
