namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtEdad.Clear();
        }

        public void AgregarAlumno()
        {
            double[] calificaciones = new double[4];
            string nombre = this.txtNombre.Text;
            int edad = int.Parse(this.txtEdad.Text);

            calificaciones[0] = double.Parse(this.txtNota1.Text);
            calificaciones[1] = double.Parse(this.txtNota2.Text);
            calificaciones[2] = double.Parse(this.txtNota3.Text);
            calificaciones[3] = double.Parse(this.txtNota4.Text);

            Alumno alumno = new(nombre, edad, calificaciones);
            alumnos.Add(alumno);
        }

        public void MostrarPromedios()
        {
            string message = "";

            foreach (Alumno alumno in alumnos)
            {
                message += $"\nNombre de alumno: {alumno.Nombre}\t\t Nota promedio: {alumno.CalcularPromedio():N2}";
            }

            MessageBox.Show($"Promedio de calificaciones de alumnos registrados: \n{message}");
        }

        private void btnAgregaryMostrar_Click(object sender, EventArgs e)
        {
            AgregarAlumno();
            MostrarPromedios();
            ClearForm();
        }
    }
}