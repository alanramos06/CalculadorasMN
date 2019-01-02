using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcaladora_Interpolacion
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int numeroDatos = 0, i = 0;
        double punto = 0.0;
        public double[,] DatosB;
        public double[] DatosX;
        public double[] DatosFX;

        public Form1()
        {
            InitializeComponent();
            groupBoxDatos.Visible = false; //Se inicializa el groupBox invisible para que no sea modificado
            btnCalcular.Enabled = false; //Se inicializa el botón de calcular como inhabil para que no se use antes de tiempo
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDatos.Enabled = false; //Se bloquea la caja de la cantidad de datos para que no sea modificada
                txtPunto.Enabled = false; //Se bloquea la caja del punto que se busca para que no sea modificada
                groupBoxDatos.Visible = true; //El groupBox se hace visible
                numeroDatos = Convert.ToInt32(txtDatos.Value); //Se captura el número de datos
                punto = Convert.ToDouble(txtPunto.Value); //Se captura el punto que se busca
                DatosB = new double[numeroDatos, numeroDatos]; //Se inicializa la matriz para guardar los datos
                DatosX = new double[numeroDatos]; //Se inicializa el vector de los valores de X
                DatosFX = new double[numeroDatos]; //Se inicializa el vector de los valores de la función de X
                btnAceptar.Enabled = false; //El botón aceptar se bloquea
            }
            catch
            {
                MessageBox.Show("Ingresó algún dato erróneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < numeroDatos)
                {
                    DatosX[i] = Convert.ToDouble(txtValorX.Value); //Se agrega el valor de X al vector
                    DatosFX[i] = Convert.ToDouble(txtValorFx.Value); //Se agrega el valor de la función de X al vector
                    i++;
                    if (i == numeroDatos)
                    {
                        MessageBox.Show("Último dato capturado. Presione Calcular", "Dato capturado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtValorX.Enabled = false; //Si es el último dato se bloquea la caja de las X
                        txtValorFx.Enabled = false; //Si es el último dato se bloquea la caja de la función de X
                        btnCalcular.Enabled = true; //El botón calcular se activa
                        btnAgregar.Enabled = false; //El botón agregar de bloquea
                    }
                    else
                    {
                        MessageBox.Show("Dato número " + i + " capturado. Continúe", "Dato capturado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingresó algún dato erróneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                btnCalcular.Enabled = false; //Se bloquea el botón calcular
                int a = numeroDatos, q = numeroDatos-1; //Se inicializan dos variables de control
                double fx = 0.0, b = 1, resta1 = 0.0, resta2 = 0.0, div = 0.0; //Se inicializan variables para las operaciones
                    for (int j = 0; j < a; j++) //Ciclo para guardar los valores de la función de X en la matriz
                    {
                        int i = 0;
                        DatosB[i, j] = DatosFX[j];
                    }

                //Ciclo para sacar las b y guardarlas donde corresponde dentro de la matriz
                for (int i = 1; i < numeroDatos+1; i++) //La i se inicializa en 1 para protejer las funciones de X
                {
                        for (int j = 0; j < q; j++)
                        {
                            resta1 = ((DatosB[i - 1, j + 1]) - (DatosB[i - 1, j]));
                            resta2 = ((DatosX[i + j]) - (DatosX[j]));
                            div = resta1 / resta2;
                            DatosB[i, j] = div;
                        }
                    q--; //Se decrementa q porque en cada iteración obtenemos una b menos
                }

                for (int i = 0; i < numeroDatos; i++) //Ciclo para resolver la fórmula final
                {
                    if (i == 0) //Si i es igual a 0 es la primera iteración, por lo que sólo se suma la primera función
                    {
                        fx = DatosFX[0];
                    }
                    else //En el resto de los casos se aplica la fórmula y se va sumando a la variable del resultado
                    {
                        b = b * (punto - DatosX[i - 1]);
                        fx = fx + (DatosB[i, 0] * b);
                    }
                }
                txtResultado.Text = Convert.ToString(fx);
            }
            catch
            {
                MessageBox.Show("Error en el procesamiento. Vuelva a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

