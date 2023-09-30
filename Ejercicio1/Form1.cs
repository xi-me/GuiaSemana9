namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            this.panelRectangulo.Visible = true;
            this.btnCalcularArea.Visible = true;
            this.panelCirculo.Visible = false;
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            double area;
            if (this.panelRectangulo.Visible)
            {
                double baseRect = double.Parse(this.txtBase.Text);
                double alturaRect = double.Parse(this.txtAltura.Text);
                Rectangulo objRectangulo = new(baseRect, alturaRect);
                area = objRectangulo.CalcularArea();
                MessageBox.Show($"El área del rectángulo es de: {area}");
            }
            else if (this.panelCirculo.Visible)
            {
                double radio = double.Parse(this.txtRadio.Text);
                Circulo objCirculo = new(radio);
                area = objCirculo.CalcularArea();
                MessageBox.Show($"El área del circulo es de: {area:N2}");
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            this.panelCirculo.Visible = true;
            this.panelRectangulo.Visible = false;
            this.btnCalcularArea.Visible = true;
        }
    }
}