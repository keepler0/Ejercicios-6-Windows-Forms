using System.ComponentModel.DataAnnotations;

namespace Ejercicio4
{
    public partial class convTempFRM : Form
    {
        private int celsius;
        private double fahrenheit;
        private double reaumur;
        private int contador;
        public convTempFRM()

        {
            InitializeComponent();
        }

        private void convertirButton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                contador++;
                fahrenheit = conversorFahrenheit(celsius, fahrenheit);
                reaumur = conversorReaumur(celsius, reaumur);
                reaumurTextBox.Text = reaumur.ToString();
                fahrenheitTextBox.Text = fahrenheit.ToString();
            }

        }

        private double conversorReaumur(int celsius, double reaumur) => 0.8 * celsius;

        private static double conversorFahrenheit(int celsius, double fahrenheit) => 1.8 * celsius + 32;

        private bool validarDatos()
        {
            bool valido = true;
            if (!int.TryParse(celsiusTextBox.Text, out celsius))
            {
                valido = false;
                errorProvider1.SetError(celsiusTextBox, "El dato ingresado es invalido");
                celsiusTextBox.SelectAll();
                celsiusTextBox.Focus();
            }
            return valido;
        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            celsiusTextBox.Clear();
            reaumurTextBox.Clear();
            fahrenheitTextBox.Clear();
            celsiusTextBox.Focus();
        }
        private void salirButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Desea cerrar la aplicacion?", "Cerrar aplicacion",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2);
            if (d == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }



        private void convTempFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}