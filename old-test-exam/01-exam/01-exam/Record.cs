using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exam
{
    internal class Record
    {
        private string nombre;
        private int edad;
        private int puntuacion;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Edad
        {
            set
            {
                if (value >= 0)
                {
                    edad = value;

                }
                else
                {
                    throw new Exception();
                }
            }
            get { return edad; }
        }

        public int Puntuacion
        {

            set { puntuacion = value; }
            get { return puntuacion; }
        }

        public Record(string nombre, int edad, int puntuacion)
        {
            Nombre = nombre;
            Edad = edad;
            Puntuacion = puntuacion;
        }


        public override String ToString()
        {
            return $"Nombre: {this.Nombre} Edad: {this.Edad} Puntuacion: {this.Puntuacion}";
        }
    }
}
