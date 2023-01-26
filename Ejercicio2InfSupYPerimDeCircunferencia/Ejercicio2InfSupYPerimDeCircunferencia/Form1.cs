using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2InfSupYPerimDeCircunferencia
{
    public partial class Ejercicio2Form : Form
    {
        public double superficie;
        public double perimetro;
        public int contador;
        public int radio;

        public Ejercicio2Form()
        {
            InitializeComponent();
        }

        private void RadioLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
           
            if (validarDatos())
            {
                if (validarLimite())
                {
                    contador++;
                    superficie = calcularSup(radio);
                    perimetro = calcularPer(radio);
                    limpiarcontrol();
                    //se informa que pondre una grilla
                    DataGridViewRow r = new DataGridViewRow();
                    //la cual la voy a llenar con la siguiente invocacion
                    r.CreateCells(DatosDataGridView);
                    //envio la informacion a sus respectivas columnas
                    r.Cells[colPerimetro.Index].Value = perimetro;
                    r.Cells[colSuperficie.Index].Value = superficie;
                    //estos datos lo mando a la grilla datagridview
                    DatosDataGridView.Rows.Add(r);
                }
            }
        }
        //funcion para limpiar los controles y volver el focus al lugar donde ingresar datos
        private void limpiarcontrol()
        {
            radioTextBox.Clear();
            radioTextBox.Focus();
        }
        //---------------------------Funcion para calcular el perimetro---------------------------------
        private double calcularPer(int radio) => (2 * (Math.PI) * radio);
        //---------------------------funcion para limitar el valor ingresado-----------------------------
        private bool validarLimite()
        {
            bool limite = true;
            errorProvider1.Clear();
             if (radio> 100)
             {
                limite = false;
                errorProvider1.SetError(radioTextBox, "El valor debe ser menor a 100");
                limpiarcontrol();
             }
            return limite;
        }

        //--------------------------funcion para calcular la superficie-------------------------------
        private double calcularSup(int radio) => ((Math.PI) * (Math.Pow(radio, 2)));
        
        //-------------------------Funcion para Validar los datos ingresados---------------------------
        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(radioTextBox.Text, out radio))
            {
               
                valido = false;
                errorProvider1.SetError(radioTextBox, "El dato ingresado debe ser numeros");
                limpiarcontrol();
            }
            return valido;
        }

        private void Ejercicio2Form_Load(object sender, EventArgs e)
        {

        }

        private void Ejercicio2Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de cerrar el programa?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (contador == 0)
                {
                    MessageBox.Show("No se realizaron conversiones", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (contador == 1)
                    {
                        MessageBox.Show($"Se realizo una conversion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Se realizaron en total de {contador} conversiones", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
