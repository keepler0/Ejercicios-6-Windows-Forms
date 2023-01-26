using System.Text;

namespace Ejercicio_1
{// separadores: manejador de evemtos= "-------------"
 // separadores: funcion para el manejador de eventos= "+++++++++++++++"
 //uso esto para poder indentificarlos
    public partial class opBasicasForm : Form
    {
        //definicion de las variables
        //Se definen variables a nivel del form para poder usarlas en otros procesos del codigo
        private int num1;
        private int num2;
        public int sumar,contadorSuma;
        public int restar,contadorResta;
        public int producto, contadorProducto,contadorDivision;
        public double division;
        int contador;
        
        public opBasicasForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void SalirButton_Click(object sender, EventArgs e)
        {
            //aqui se controla los eventos al precionar el boton SALIR la cual modificaremos para que cierre la aplicacion
            StringBuilder sb = new StringBuilder();

            // // Determina singular o plural de las operaciones CONTADOR GENERAL
            contador = (totalContador());
            if (contador == 0)
            {
                sb.AppendLine("No se realizaron operaciones");
            }
            else
            {
                if (contador == 1)
                {
                    sb.AppendLine("Se realizo 1 operación");
                }
                else
                {
                    sb.AppendLine($"Se realizaron {contador} operaciones en total");
                }
            }
            if (contadorSuma>=1 || contadorResta>=1 || contadorProducto>=1 || contadorDivision>=1)
            {
                // Determina singular o plural de las operaciones RESTA

                if (contadorResta>=1)
                {
                    if (contadorResta == 1)
                    {
                        sb.AppendLine("Se realizó una resta");
                    }
                    else
                    {
                        sb.AppendLine($"Se realizó {contadorResta} restas");
                    } 
                }


                // Determina singular o plural de las operaciones SUMA

                if (contadorSuma>=1)
                {
                    if (contadorSuma == 1)
                    {
                        sb.AppendLine("Se realizó una suma");
                    }
                    else
                    {
                        sb.AppendLine($"Se realizó {contadorSuma} sumas");
                    } 
                }


                // Determina singular o plural de las operaciones MULTIPLICACIÓN

                if(contadorProducto>=1)
                {    if(contadorProducto == 1)
                    {
                        sb.AppendLine("Se realizó una multiplicación");
                    }
                else
                    {
                        sb.AppendLine($"Se realizó {contadorProducto} multiplicaciones");
                    } 
                }

                // Determina singular o plural de las operaciones DIVISION

                if (contadorDivision>=1)
                {
                    if (contadorDivision == 1)
                    {
                        sb.AppendLine("Se realizó una división");
                    }
                    else
                    {
                        sb.AppendLine($"Se realizó {contadorDivision} divisiones");
                    } 
                }
            }
            else
            {
                sb.AppendLine(" ");
            }
            

           
            
            MessageBox.Show(sb.ToString(),"Estadisticas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
           
            DialogResult dr=MessageBox.Show("Esta seguro que quiere cerrar la aplicacion?", "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();

        }

        private int totalContador() => (contadorDivision + contadorProducto + contadorResta + contadorSuma);
      

        //-----------------manejador de evemtos del sumarButton-------------------
        private void SumaButton_Click(object sender, EventArgs e)
        {
            
            
            if (validarDatos())
            {
                //num1 = int.Parse(num1TxtBox.Text);
                //num2 = int.Parse(num2TxtBox.Text);
                sumar = resuladoSuma(num1, num2);
                
                contadorSuma++;
                MessageBox.Show(sumar.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiador de texto
                LimpiarControles(); 
            }
        }

        //++++++++++++++++++++++++funcion para obtener el resultado de la suma+++++++++++++++++++++
        private int resuladoSuma(int num1, int num2)=>num1 + num2;
       




        //la siguiente funcion validara los datos que se ingresen en los text box
        private bool validarDatos()
        {
            bool valido = true;
            ErroresErrorProvider.Clear();
            if (!int.TryParse(num1TxtBox.Text,out num1))
            {
                valido = false;
                ErroresErrorProvider.SetError(num1TxtBox,"Dato ingresado erroneo");
                num1TxtBox.SelectAll();
                num1TxtBox.Focus();
            }
            if (!int.TryParse(num2TxtBox.Text,out num2))
            {
               
                valido = false;
                ErroresErrorProvider.SetError(num2TxtBox, "Dato ingresado erroneo");
                num2TxtBox.SelectAll();
                num2TxtBox.Focus();
            }
            return valido;
        }
        //manejador de eventos Boton Restar
        private void RestaButton_Click(object sender, EventArgs e)
        {
            
           
            if (validarDatos())
            {
                restar = resuladoResta(num1, num2);
                contadorResta++;

                MessageBox.Show(restar.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiador de texto
                LimpiarControles();
            }
        }

        private void LimpiarControles()
        {
            num1TxtBox.Clear();
            num2TxtBox.Clear();
            num1TxtBox.Focus();
            ErroresErrorProvider.Clear();
        }

        //+++++++++++funcion para la operacion de la resta++++++++++++++++++
        private int resuladoResta(int num1, int num2) => num1 - num2;

        //------------------------------manejador de eventos Boton multiplicacion-------------------------------------
        private void ProductoButton_Click(object sender, EventArgs e)
        {
            
            
            if (validarDatos())
            {
                producto = resuladoProducto(num1, num2);
                
                contadorProducto++;
                MessageBox.Show(producto.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiador de texto
                LimpiarControles();
            }
        }
        //++++++++++++++++++++++++++++funcion para obtener el producto+++++++++++++++++++++++++++++++
        private int resuladoProducto(int num1, int num2) => num1 * num2;

        //----------------------manejador de eventos boton de division---------------------------
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            {
                if (validarDatos())
                {

                    if (num2 == 0)
                    {
                        ErroresErrorProvider.SetError(num2TxtBox, "No se puede dividir con CERO");
                    }
                    else
                    {
                        division = resuladoDivision(num1, num2);

                        contadorDivision++;
                        MessageBox.Show(division.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //limpiador de texto
                        LimpiarControles();
                    }
                }
            }
        }  
        //++++++++++++++++++++funcion para obtener division++++++++++++++++++
        private double resuladoDivision(int num1, int num2) => num1 / num2;

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}