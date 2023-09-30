using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Rectangulo : FiguraGeometrica
    {
        private double baseRectangulo;
        private double alturaRectangulo;

        public Rectangulo(double baseRectangulo, double alturaRectangulo) 
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public double BaseRectangulo { get => baseRectangulo; set => baseRectangulo = value; }
        public double AlturaRectangulo { get => alturaRectangulo; set => alturaRectangulo = value; }

        public override double CalcularArea()
        {
            return this.baseRectangulo * this.alturaRectangulo;
        }
    }
}
