using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Empleado
    {
        private string nombre;
        private double salario;
        private string tipo;

        public Empleado(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public double CalcularSalarioTotal(double salario)
        {
            this.salario = salario;
            double dIsss, dAfp, dRenta, totalDescuentos;
            dIsss = 0.003 * this.salario;
            dAfp = 0.0775 * this.salario;

            if (this.salario > 472 && this.salario < 895.25)
            {
                dRenta = 0.1;
            }
            else if (this.salario >= 895.25 && this.salario < 2038.11)
            {
                dRenta = 0.2;
            }
            else if (this.salario > 2038.11)
            {
                dRenta = 0.3;
            }
            else
            {
                dRenta = 0;
            }
            totalDescuentos = dIsss + dAfp + dRenta;
            return this.salario -= totalDescuentos;
        }

        public double CalcularSalarioTotal(double salario, int cantidadHoras)
        {
            this.salario = salario * cantidadHoras;

            double dIsss, dAfp, dRenta, totalDescuentos;
            dIsss = 0.003 * this.salario;
            dAfp = 0.0775 * this.salario;

            if (this.salario > 472 && this.salario < 895.25)
            {
                dRenta = 0.1;
            }
            else if (this.salario >= 895.25 && this.salario < 2038.11)
            {
                dRenta = 0.2;
            }
            else if (this.salario > 2038.11)
            {
                dRenta = 0.3;
            }
            else
            {
                dRenta = 0;
            }

            totalDescuentos = dIsss + dAfp + dRenta;
            return this.salario -= totalDescuentos;
        }
    }
}
