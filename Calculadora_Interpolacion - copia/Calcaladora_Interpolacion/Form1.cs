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
            groupBoxDatos.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDatos.Enabled = false;
                txtPunto.Enabled = false;
                groupBoxDatos.Visible = true;
                numeroDatos = Convert.ToInt32(txtDatos.Value);
                punto = Convert.ToDouble(txtPunto.Value);
                DatosB = new double[numeroDatos, numeroDatos];
                DatosX = new double[numeroDatos];
                DatosFX = new double[numeroDatos];
                btnAceptar.Enabled = false;
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
                    DatosX[i] = Convert.ToDouble(txtValorX.Value);
                    DatosFX[i] = Convert.ToDouble(txtValorFx.Value);
                    i++;
                    if (i == numeroDatos)
                    {
                        MessageBox.Show("Último dato capturado. Presione Calcular", "Dato capturado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtValorX.Enabled = false;
                        txtValorFx.Enabled = false;
                        btnCalcular.Enabled = true;
                        btnAgregar.Enabled = false;
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
                btnCalcular.Enabled = false;
                int a = numeroDatos, q = numeroDatos;
                double fx = 0.0, b = 1, resta1 = 0.0, resta2 = 0.0, div = 0.0;
                for (int i = 0; i < numeroDatos; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (i == 0)
                        {
                            DatosB[i, j] = DatosFX[j];
                        }
                    }
                    a--;
                }

                for (int i = 0; i < numeroDatos; i++)
                {
                    if (i != 0)
                    {
                        for (int j = 0; j < q; j++)
                        {
                            resta1 = ((DatosB[i - 1, j + 1]) - (DatosB[i - 1, j]));
                            resta2 = ((DatosX[i + j]) - (DatosX[j]));
                            div = resta1 / resta2;
                            DatosB[i, j] = div;
                        }
                    }
                    q--;
                }

                for (int i = 0; i < numeroDatos; i++)
                {
                    if (i == 0)
                    {
                        fx = DatosFX[0];
                    }
                    else
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

