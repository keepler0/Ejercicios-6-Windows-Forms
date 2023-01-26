using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace Ejercicio3ConversionKmsMillaYardas
{
    public partial class conversorFrm : Form
    {
        public int kms;
        public double millas, yardas;
        public conversorFrm()
        {
            InitializeComponent();
       
        }

        private void KmsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void KmsLabel_Click(object sender, EventArgs e)
        {

        }

        private void convertirButton_Click(object sender, EventArgs e)
        {
            //introduci funciones para verificar los datos ingresados y otros dos para la conversion
            verificarDatos();
            millas=conversionMillas(millas);
            yardas=conversionYardas(yardas);
      
            MillasTextBox.Text = millas.ToString();
            YardasTextBox.Text = yardas.ToString();

            limpiarControles();

            
            //aqui creamos las celdas y filas de la DataGridView
            if (kms>0)
            {
                DataGridViewRow r = crearCeldas();
                r.Cells[colKms.Index].Value = kms;
                r.Cells[colMillas.Index].Value = millas;
                r.Cells[colYardas.Index].Value = yardas;
                ConversionesDataGridView.Rows.Add(r);
            }
            

        }

        private DataGridViewRow crearCeldas()
        {
            var r = new DataGridViewRow();
            r.CreateCells(ConversionesDataGridView);
            return r;
        }

        private double conversionYardas(double yardas)=>(kms)* 1093.6133;


        private double conversionMillas(double millas) => kms * (0.621371192);

        private void resetButton_Click(object sender, EventArgs e)
        {
            KmsTextBox.Clear();
            MillasTextBox.Clear();
            YardasTextBox.Clear();
            ConversionesDataGridView.Rows.Clear();
            KmsTextBox.Focus();
            errorProvider.Clear();
        }

        private void limpiarControles()
        {
            KmsTextBox.Clear();
            KmsTextBox.Focus();
        }

        private void conversorFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro de cerrar la aplicacion?", "cerrar aplicación",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void historialButton_Click(object sender, EventArgs e)
        {
            
            if (historialButton.BackColor == Color.Transparent)
            {
                this.Width = 665;
                historialButton.BackColor = Color.Orange;
            }
            else
            {
                this.Width = 310;
                historialButton.BackColor = Color.Transparent;
            }
            
        }

        private bool verificarDatos()
        {
            errorProvider.Clear();
            //esta bicondicional va a verificar si el dato ingresado es un numero o no en el caso de falso esto retornara un error provider
            bool valido=true;
            if (!int.TryParse(KmsTextBox.Text, out kms))
            {
                valido = false;
                errorProvider.SetError(KmsTextBox, "Valor incorrecto");
                limpiarControles();
            }
            return valido;
        }
    }
}
