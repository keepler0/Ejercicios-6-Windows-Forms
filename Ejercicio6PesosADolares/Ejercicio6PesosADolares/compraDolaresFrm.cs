using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6PesosADolares
{
    public partial class compraDolaresFrm : Form
    {
        public decimal pesos;
        public decimal dolares;
        public decimal cotizacionUsd;
        public decimal totalPesos;
        public decimal impPais=0.3M;
        public decimal impGanancias=0.35M;
        public int totalEnBanco = 50000;
        public compraDolaresFrm()
        {
            InitializeComponent();
            dolaresRestantesTextBox.Text= totalEnBanco.ToString();
        }

        private void comprarButton_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                dolaresRestantesTextBox.Text=compraDolares().ToString();
                pesos=dolaresAPesos();
                calculoImpuestoPais();
                calculoImpuestoGanancias();
                totalPesos=totalCompra();
                totalAPagarTextBox.Text = totalPesos.ToString();
                limpiarControles();
                llenarDGV();
            }
        }

        private void llenarDGV()
        {
            DataGridViewRow dgv=new DataGridViewRow();
            dgv.CreateCells(operacionesDataGridView);
            dgv.Cells[colDolares.Index].Value = dolares;
            dgv.Cells[colDolaresAPeso.Index].Value = pesos;
            dgv.Cells[colImpGanancias.Index].Value = calculoImpuestoGanancias();
            dgv.Cells[colImpPais.Index].Value = calculoImpuestoPais();
            dgv.Cells[colTotal.Index].Value = totalPesos;
            operacionesDataGridView.Rows.Add(dgv);
        }

        private void limpiarControles()
        {
            dolaresTextBox.Clear();
            cotizacionOficialTextBox.Clear();
            dolaresTextBox.Focus();
            errorProvider.Clear();
        }

        private decimal totalCompra() => calculoImpuestoPais() + calculoImpuestoGanancias() + dolaresAPesos();

        private decimal dolaresAPesos() => dolares * cotizacionUsd;

        private decimal calculoImpuestoGanancias() => pesos * impGanancias;

        private decimal calculoImpuestoPais() => pesos * impPais;
       

        private decimal compraDolares() => totalEnBanco - dolares;

        private bool verificarDatos()
        {
            bool valido = true;
            if (!decimal.TryParse(dolaresTextBox.Text,out dolares))
            {
                errorProvider.Clear();
                valido = false;
                errorProvider.SetError(dolaresTextBox, "Error: dato invalido");
                dolaresTextBox.Focus();
            }
            else
            {
                if (dolares<=0 || dolares>200)
                {
                    if (dolares<=0)
                    {
                        errorProvider.Clear();
                        valido = false;
                        errorProvider.SetError(dolaresTextBox, "Error: El valor debe ser mayor a Cero");
                        dolaresTextBox.Focus();
                    }
                    if (dolares > 200)
                    {
                        errorProvider.Clear();
                        valido = false;
                        errorProvider.SetError(dolaresTextBox, "Error: El maximo a comprar es hasta u$d200");
                        dolaresTextBox.SelectAll();
                        dolaresTextBox.Focus();
                    }
                }
            }
            if (!decimal.TryParse(cotizacionOficialTextBox.Text, out cotizacionUsd))
            {
                errorProvider.Clear();
                valido = false;
                errorProvider.SetError(cotizacionOficialTextBox, "Error: dato invalido");
                cotizacionOficialTextBox.Focus();
            }
            else
            {
                if (cotizacionUsd == 0)
                {
                    errorProvider.Clear();
                    valido = false;
                    errorProvider.SetError(cotizacionOficialTextBox, "Error: El valor debe ser mayor a Cero");
                    cotizacionOficialTextBox.SelectAll();
                    cotizacionOficialTextBox.Focus();
                }
            }
            return valido;
        }

        private void mostrarListaButton_Click(object sender, EventArgs e)
        {
            //datosGuardadosFrm datosGuardadosFrm = new datosGuardadosFrm();
            //datosGuardadosFrm.ShowDialog(this);
            if (mostrarListaButton.BackColor == Color.Transparent)
            {
                this.Width = 954;
                mostrarListaButton.BackColor = Color.Orange;
            }
            else
            {
                this.Width = 403;
                mostrarListaButton.BackColor = Color.Transparent;
            }
        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            limpiarControles();
            operacionesDataGridView.Rows.Clear();
            totalAPagarTextBox.Clear();
            dolaresRestantesTextBox.Text=totalEnBanco.ToString();
            
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cerrar la aplicacion?", "cerrando aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
