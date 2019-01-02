using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMetodosNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcularB_Click(object sender, EventArgs e)
        {
            double gravedad = 9.8, masa = 0, tiempo = 0, velocidad = 0, errorE = 0, c1 = 0, c2 = 0, c3 = 0, funcion1 = 0, funcion2 = 0,
                funcion3 = 0, euler = 0, errorA = 0, vAct = 0, vAnt = 0, aux = 0;
            int i = 0;
            euler = Math.Exp(1);
            Random r = new Random();
            c1 = r.Next(0, 100);
            c2 = r.Next(0, 100);

            masa = Convert.ToDouble(txtMasaB.Text);
            tiempo = Convert.ToDouble(txtTiempoB.Text);
            velocidad = Convert.ToDouble(txtVelocidadB.Text);
            errorE = Convert.ToDouble(txtErrorB.Text);

            funcion1 = (gravedad * masa / c1) * (1 - Math.Pow(euler, -(c1 / masa * tiempo))) - velocidad;
            funcion2 = (gravedad * masa / c2) * (1 - Math.Pow(euler, -(c2 / masa * tiempo))) - velocidad;
            while (funcion1 * funcion2 > 0)
            {
                c2 = r.Next(0, 100);
                funcion2 = (gravedad * masa / c2) * (1 - Math.Pow(euler, -(c2 / masa * tiempo))) - velocidad;
            }
            c3 = (c1 + c2) / 2;
            funcion3 = (gravedad * masa / c3) * (1 - Math.Pow(euler, -(c3 / masa * tiempo))) - velocidad;
            vAct = c3;
            errorA = Math.Abs(((vAct - vAnt) / vAct) * 100);
            i++;
            while (errorA > errorE)
            {
                if (funcion2 * funcion3 < 0)
                {
                    vAnt = c3;
                    c1 = c2;
                    aux = (c2 + c3) / 2;
                    c2 = c3;
                    c3 = aux;
                    vAct = aux;
                    errorA = Math.Abs(((vAct - vAnt) / vAct) * 100);
                    funcion3 = (gravedad * masa / c3) * (1 - Math.Pow(euler, -(c3 / masa * tiempo))) - velocidad;
                }
                else if (funcion1 * funcion3 < 0)
                {
                    vAnt = c3;
                    c2 = c3;
                    c3 = (c3 + c1) / 2;
                    vAct = c3;
                    errorA = Math.Abs(((vAct - vAnt) / vAct) * 100);
                    funcion3 = (gravedad * masa / c3) * (1 - Math.Pow(euler, -(c3 / masa * tiempo))) - velocidad;
                }
                i++;
            }
            txtResultadoB.Text = Convert.ToString(c3);
            txtIteracionesB.Text = Convert.ToString(i);
            label7.Text = Convert.ToString(errorA);
            label8.Text = Convert.ToString(vAct);
            label9.Text = Convert.ToString(vAnt);
            label10.Text = Convert.ToString(funcion3);
        }
    }
}
