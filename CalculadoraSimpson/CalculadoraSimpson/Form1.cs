using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimpson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            btnCalcular.Enabled = false;
            labUltimoDato.Visible = false;
            gbDatos.Visible = false;
        }
        public double[] FX;
        public double a = 0.0, b = 0.0;
        public int n = 0, i = 0, cont = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtA.Value == txtB.Value)
                {
                    MessageBox.Show("Los valores de 'a' y 'b' no pueden ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    a = Convert.ToDouble(txtA.Value);
                    b = Convert.ToDouble(txtB.Value);
                    n = Convert.ToInt32(txtN.Value);
                    FX = new double[n + 1];
                    btnAceptar.Enabled = false;
                    btnAgregar.Enabled = true;
                    gbDatos.Visible = true;
                    txtN.Enabled = false;
                    txtA.Enabled = false;
                    txtB.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ingresó algún dato erróneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                labUltimoDato.Visible = true;
                if (cont < n)
                {
                    FX[i] = Convert.ToDouble(txtFX.Value);
                    labDato.Text = Convert.ToString(FX[i]);
                    cont++;
                    i++;
                }
                else if (cont == n)
                {
                    MessageBox.Show("Último dato agregado. Presione Calcular", "Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FX[i] = Convert.ToDouble(txtFX.Value);
                    labDato.Text = Convert.ToString(FX[i]);
                    btnCalcular.Enabled = true;
                    btnAgregar.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ingresó algún dato erróneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double h = 0.0, segmento = 0.0, r1 = 0, r2 = 0, suma1 = 0.0, suma2 = 0.0, resultado = 0.0;
                h = (b - a) / n;
                segmento = a + 3*h;

                if (n == 3)
                {
                    //Método de Simpson 3/8 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    r1 = (segmento - a) * (FX[0] + (3 * (FX[1] + FX[2])) + FX[3]) / 8;
                    txtResultado.Text = Convert.ToString(r1);
                }
                else if (n % 2 == 0)
                {
                    //Método de Simpson 1/3 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    for (int i = 1; i < n; i++)
                    {
                        suma1 += FX[i];
                        i++;
                    }

                    for (int i = 2; i < n - 1; i++)
                    {
                        suma2 += FX[i];
                        i++;
                    }

                    r2 = (b - a) * (FX[0] + 4 * suma1 + 2 * suma2 + FX[n]) / (3 * n);
                    txtResultado.Text = Convert.ToString(r2);
                }
                else
                {
                    //Método de Simpson 3/8 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    r1 = (segmento - a) * (FX[0] + (3 * (FX[1] + FX[2])) + FX[3]) / 8;

                    //Método de Simpson 1/3 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    for (int i = 4; i < n; i++)
                    {
                        suma1 += FX[i];
                        i++;
                    }

                    for (int i = 5; i < n - 1; i++)
                    {
                        suma2 += FX[i];
                        i++;
                    }

                    r2 = (b - segmento) * (FX[3] + 4 * suma1 + 2 * suma2 + FX[n]) / (3 * (n - 3));

                    resultado = r1 + r2;
                    txtResultado.Text = Convert.ToString(resultado);
                    btnCalcular.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Error en el procesamiento. Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
