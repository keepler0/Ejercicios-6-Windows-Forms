namespace Ejercicios5
{
    public partial class superficiePerimetroFRM : Form
    {
        private int ladoMayor;
        private int ladoMenor;
        private int perimetro;
        private int superficie;
        public superficiePerimetroFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                
                if (ladoMayor<0 || ladoMenor < 0)
                {
                    MessageBox.Show("Los valores ingresados no debe ser menor a cero","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    
                    perimetro = calcularPerimetro(ladoMayor, ladoMenor);
                    superficie = calcularSuperficie(ladoMayor, ladoMenor);
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dataGridView1);
                
                
                    r.Cells[colLadoMayor.Index].Value = ladoMayor;
                    r.Cells[colLadoMenor.Index].Value = ladoMenor;
                    r.Cells[colPerimetro.Index].Value = perimetro;
                    r.Cells[colSuperficie.Index].Value = superficie;
                    dataGridView1.Rows.Add(r);
                }
                limpiarControles();
            }
        }

     

        private int calcularSuperficie(int ladoMayor, int ladoMenor) => ladoMenor * ladoMayor;
       

        private int calcularPerimetro(int ladoMayor, int ladoMenor) => (2 * ladoMayor) + (2 * ladoMenor);
       

        private bool verificarDatos()
        {
            bool validar = true;
            if (!int.TryParse(ladoMayortTextBox.Text, out ladoMayor))
            {
                validar = false;
                errorProvider.SetError(ladoMayortTextBox, "El dato ingresado es incorrecto");
                ladoMayortTextBox.Focus();
                ladoMayortTextBox.SelectAll();
                /*IMPORTANTE DEFINIR QUE EL FOCUS SEA TEXTBOX QUE ESTADANDO EL ERROR POR QUE AHORA 
                 ESTA DANDO FOCUS SOLO AL LADOMENORTEXTBOX CORREGIR ESO*/

            }
            if (!int.TryParse(LadoMenorTextBox.Text, out ladoMenor))
            {
                validar = false;
                errorProvider.SetError(LadoMenorTextBox, "El dato ingresado es incorrecto");
                LadoMenorTextBox.Focus();
                LadoMenorTextBox.SelectAll();
            }
            return validar;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarControles();
            dataGridView1.Rows.Clear();
        }

        private void limpiarControles()
        {
            ladoMayortTextBox.Clear();
            LadoMenorTextBox.Clear();
            ladoMayortTextBox.Focus();
            errorProvider.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void superficiePerimetroFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Está seguro de cerrar la aplicacion?", "cerrando aplicacion",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            
           
        }
    }
}