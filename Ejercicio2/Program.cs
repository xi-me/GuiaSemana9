namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado("José Jacobo", "Tiempo Completo"));
            empleados.Add(new Empleado("Marcela Muñoz", "Tiempo Completo"));
            empleados.Add(new Empleado("Josue López", "Tiempo Parcial"));
            empleados.Add(new Empleado("Andrea Martínez", "Tiempo Parcial"));
            empleados.Add(new Empleado("Antonio Pérez", "Tiempo Parcial"));

            foreach (Empleado empleado in empleados)
            {
                if (empleado.Tipo == "Tiempo Completo")
                {
                    Console.WriteLine("---------- Empleado de Tiempo Completo ----------");
                    Console.Write($"Ingrese el salario de {empleado.Nombre}: $");
                    double salario = double.Parse(Console.ReadLine());
                    empleado.CalcularSalarioTotal(salario);
                }
                else if (empleado.Tipo == "Tiempo Parcial")
                {
                    Console.WriteLine("---------- Empleado de Tiempo Parcial ----------");
                    Console.Write($"Ingrese el salario por hora de {empleado.Nombre}: $");
                    double salarioxHora = double.Parse(Console.ReadLine());
                    Console.Write("Cantidad de horas trabajadas: ");
                    int cantidadHoras = int.Parse(Console.ReadLine());
                    empleado.CalcularSalarioTotal(salarioxHora, cantidadHoras);
                }
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("---------------- Resumen de salarios ----------------\n");
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"Nombre de empleado: {empleado.Nombre}\nSalario Total: {empleado.Salario:C2}\n");
            }
            Console.ReadKey();
        }
    }
}