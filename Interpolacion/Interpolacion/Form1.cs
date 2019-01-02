using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double calcularB(double fx0, double fx1, double x0, double x1)
        {
            double b1 = 0;
            b1 = (fx1 - fx0) / (x1 - x0);
            return b1;
        }

        public ArrayList DatosX;
        public ArrayList DatosF;
        public ArrayList DatosB;
        public ArrayList DatosB2;
        public ArrayList DatosBR;

        private void Form1_Load(object sender, EventArgs e)
        {
            DatosX = new ArrayList();
            DatosF = new ArrayList();
            DatosB = new ArrayList();
            DatosB2 = new ArrayList();
            DatosBR = new ArrayList();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int x = 0;
            double calcular=0, resta=0, mult=1, res=0, b=0, b2 = 0;
            x = Convert.ToInt32(txtDatos.Text);

            calcular = Convert.ToDouble(txtCalcular.Text);


            DatosBR.Add(Convert.ToDouble(DatosF[0]));

            /*for(int j = x/2; j < x; j--)
            {
                for (int i = 0; i < x-1; i++)
                {
                    b = calcularB(Convert.ToDouble(DatosF[i]), Convert.ToDouble(DatosF[i+1]), Convert.ToDouble(DatosX[i]), Convert.ToDouble(DatosX[i+1]));
                    DatosB.Add(b);
                }
                DatosBR.Add(DatosB[0]);
                x--;
                DatosF.Clear();

                for (int i = 0; i < x-1; i++)
                {
                    b = calcularB(Convert.ToDouble(DatosB[i]), Convert.ToDouble(DatosB[i + 1]), Convert.ToDouble(DatosX[i]), Convert.ToDouble(DatosX[i + 1]));
                    DatosF.Add(b);
                }
                DatosBR.Add(DatosF[0]);
                x--;
                DatosB.Clear();

                

                /*for (int i = 0; i > x; i++)
                {
                    DatosB.Add((Convert.ToDouble(DatosF[i + 1]) - Convert.ToDouble(DatosF[i])) / (Convert.ToDouble(DatosX[i + 1]) - Convert.ToDouble(DatosX[i])));
                }
                DatosBR.Add(Convert.ToDouble(DatosB[0]));

                for (int i = 0; i > x; i++)
                {
                    DatosF.Add((Convert.ToDouble(DatosB[i + 1]) - Convert.ToDouble(DatosB[i])) / (Convert.ToDouble(DatosX[i + 1]) - Convert.ToDouble(DatosX[i])));
                }
                DatosBR.Add(Convert.ToDouble(DatosF[0]));
            }*/

            /*foreach (var item in DatosBR)
            {
                int i = 0;
                resta = calcular - Convert.ToDouble(DatosX[i]);
                mult = mult * resta;
                res = res + Convert.ToDouble(item) * mult;
                i++;
            }*/

            /*for(int i = 0; i<x-1; i++)
            {
                resta = calcular - Convert.ToDouble(DatosX[i]);
                mult = mult * resta;
                res = res + Convert.ToDouble(DatosBR[i+1]) * mult;
            }
            res = res + Convert.ToDouble(DatosBR[0]);*/

            for (int i = 0; i < DatosX.Count - 1; i++)
            {
                b = ((Convert.ToDouble(DatosF[i + 1]) - Convert.ToDouble(DatosF[i])) / (Convert.ToDouble(DatosX[i + 1]) - Convert.ToDouble(DatosX[i])));
                DatosB.Add(b);
            }
            DatosBR.Add(DatosB[0]);

            for (int p = 0; p < DatosX.Count-1; p++)
            {
                for (int q = 0; q < DatosB.Count-1; q++)
                {
                    b2 = ((Convert.ToDouble(DatosB[q + 1]) - Convert.ToDouble(DatosB[q])) / (Convert.ToDouble(DatosX[p + q + 2]) - Convert.ToDouble(DatosX[q])));
                    DatosB2.Add(b2);
                }
                DatosBR.Add(DatosB2[0]);
            }

            for (int m = 0; m < DatosX.Count; m++)
            {
                resta = calcular - Convert.ToDouble(DatosX[m]);
                mult = mult * resta;
                res += Convert.ToDouble(DatosX[m + 1]) * mult;
            }
            res += Convert.ToDouble(DatosF[0]);

            txtResultado.Text = Convert.ToString(res);
        }

        private void btnAgregarX_Click(object sender, EventArgs e)
        {
            double valorX = 0;
            valorX = Convert.ToDouble(txtValorX.Text);
            DatosX.Add(valorX);
        }

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            double valorF = 0;
            valorF = Convert.ToDouble(txtValorF.Text);
            DatosF.Add(valorF);
        }
    }
}
