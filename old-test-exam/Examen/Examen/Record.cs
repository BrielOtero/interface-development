using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Examen
{
    internal class Record
    {
        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }
        private int _edad;
        public int Edad
        {
            get => _edad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _edad = value;
            }
        }
        private int _puntuacion;
        public int Puntuacion { get => _puntuacion; set => _puntuacion = value; }

        public Record(string nombre, int edad, int puntuacion)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Puntuacion = puntuacion;
        }

        public override string ToString()
        {
            return $"Nombre:{Nombre} | Edad:{Edad} | Puntuacion:{Puntuacion}";
        }
    }
}
