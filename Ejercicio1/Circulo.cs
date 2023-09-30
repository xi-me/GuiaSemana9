using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Circulo : FiguraGeometrica
    {
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Radio { get => radio; set => radio = value; }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }
    }
}
