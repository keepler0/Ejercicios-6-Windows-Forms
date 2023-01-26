using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio1GradosSexagesimalesARadianes : Form
    {
        //definicion de las variables
        //voy a definir variables generales asi poder usarlos en todo el codigo
        private double radianes,GradosSexagesimales;
        private int contador;

        public Ejercicio1GradosSexagesimalesARadianes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //------------------------Manejador de eventos del Calcularbutton----------------------
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (GradosSexagesimales>0)
                {
                    contador++;
                    radianes = conversor(GradosSexagesimales);
                    RadianesTextBox.Text = radianes.ToString();
                    //MessageBox.Show(radianes.ToString(), "Equivalente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //acontinuacion estamos insertando datos a una grilla para insertar el historial del los procesos
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(HistorialDataGridView);
                    r.Cells[colGSexagesimal.Index].Value = GradosSexagesimales;
                    r.Cells[colRadianes.Index].Value = radianes;
                    HistorialDataGridView.Rows.Add(r);
                }
                else
                {
                    errorProvider1.SetError(GSexagesimalesTextBox, "El valor debe ser mayor a 0");
                }
                
            }
        }
        //++++++++++++++++++++++Se crea una funcion para LimpiarControles()++++++++++++++++
        private void limpiarControles()
        {
            GSexagesimalesTextBox.Clear();
            RadianesTextBox.Clear();
            GSexagesimalesTextBox.Focus();
        }
        //++++++++++++++++++++++++ Funcion para obtener la conversion+++++++++++++++++++++ 
        private double conversor(double radianes) => GradosSexagesimales * 0.0174532925;



        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!double.TryParse(GSexagesimalesTextBox.Text, out GradosSexagesimales))
            {
                valido = false;
                errorProvider1.SetError(GSexagesimalesTextBox, "Error. El dato ingresado debe ser solo Números");
            }
            return valido;

        }
        //----------------------------Manejador de eventos del boton HISTORIAL------------------------
        private void HistorialButton_Click(object sender, EventArgs e)
        {

            if (HistorialButton.BackColor == Color.Transparent)
            {
                this.Width = 850;
                HistorialButton.BackColor = Color.Orange;
            }
            else
            {
                this.Width = 441;
                HistorialButton.BackColor = Color.Transparent;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void Ejercicio1GradosSexagesimalesARadianes_Load(object sender, EventArgs e)
        {

        }

        //-------------------------Manejador de eventos del boton SALIR------------------------
        private void SalirButton_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            //lo siguiente en comentario era para mostrar los resultados muestra una una ventana previa al SiNo del SalirButton

            if (contador==0)
            {
                MessageBox.Show($"No se realizaron conversiones.", "Cantidad de conversiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            else
            {
                if (contador == 1)
                {
                    MessageBox.Show($"Se realizó 1 conversion.", "Cantidad de conversiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"Se realizaron {contador} conversiones.", "Cantidad de conversiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            DialogResult dr = MessageBox.Show("Está seguro de cerrar la aplicacion?", "confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }
    }
}
