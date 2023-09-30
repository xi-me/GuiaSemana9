using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Alumno
    {
        private string nombre;
        private int edad;
        private double[] calificaciones;

        public Alumno(string nombre, int edad, double[] calificaciones)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.calificaciones = calificaciones;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double[] Calificaciones { get => calificaciones; set => calificaciones = value; }
        
        public double CalcularPromedio()
        {
            return this.calificaciones.Sum() / this.calificaciones.Length;
        }
    }
}
