using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace biseccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();





        }

        ArrayList listx = new ArrayList();

        ArrayList listf = new ArrayList();

        ArrayList listb = new ArrayList();

        ArrayList listbr = new ArrayList(); }

       

        private void calcular_Click(object sender, EventArgs e)//Biseccion
        {

            //Inicializar variables
            double f1, f2, c1, c2, c3 = 0, f3, ea, es, vant = 0;
            int iteracion = 0;
            gravedad.Text = "9.8";
            c1 = Convert.ToDouble(C1.Text);
            c2 = Convert.ToDouble(C2.Text);
            f1 = operaciones.fc(masa.Text, tiempo.Text, c1, velocidad.Text);//Utilizado metodo para las funciones de f(c)
            f2 = operaciones.fc(masa.Text, tiempo.Text, c2, velocidad.Text);
            fc1.Text = Convert.ToString(f1);
            fc2.Text = Convert.ToString(f2);
            
            es = Convert.ToDouble(ers.Text);
            vant = 0;
            ea = 100;


            if ((f1 * f2) > 0)//Verificar que si los valores de c son correctos
            {
                MessageBox.Show("Cambie los valores de C1 o C2");
            }
            else
            {
                while (Math.Abs(ea) > es)//Ciclo para comparar Error aproximado
                {
                    //Formula
                    c3 = (c1 + c2) / 2;
                    f3 = operaciones.fc(masa.Text, tiempo.Text, c3, velocidad.Text);
                    ea = ((c3 - vant) / c3) * 100;
                    vant = c3;
                    iteracion++;

                    //Cambiar valores de c
                    if (f1 * f3 < 0)
                    {
                        f2 = f3;
                        c2 = c3;
                    }
                    else
                    {
                        f1 = f3;
                        c1 = c3;
                    }

                }
                valor.Text = Convert.ToString(c3);
                it.Text = Convert.ToString(iteracion);
                era.Text = Convert.ToString(ea);

            }
        }

        private void sec_Click(object sender, EventArgs e)
        {
            double f1, f2, f3, c1, c2, c3, ea, es, vant; 
            int iteracion = 0;
            gravedad.Text = "9.8";
            c1 = Convert.ToDouble(C1.Text);
            c2 = Convert.ToDouble(C2.Text);
            c3 = 0;
            f1 = operaciones.fc(masa.Text, tiempo.Text, c1, velocidad.Text);
            f2 = operaciones.fc(masa.Text, tiempo.Text, c2, velocidad.Text);
            fc1.Text = Convert.ToString(f1);
            fc2.Text = Convert.ToString(f2);
            es = Convert.ToDouble(ers.Text);
            vant = 0;
            ea = 100;


            while (Math.Abs(ea) > es)
            {
                //formula de secante
                c3 = c2 - ((f2 * (c1 - c2)) / (f1 - f2));
                f3 = operaciones.fc(masa.Text, tiempo.Text, c3, velocidad.Text);
                c1 = c2;
                f1 = f2;
                f2 = f3;
                c2 = c3;
                ea= ((c3 - vant) / c3) * 100;
                vant = c3;

                iteracion++;
                
                valor.Text = Convert.ToString(c3);
                it.Text = Convert.ToString(iteracion);
                era.Text = Convert.ToString(ea);
            }
        }

        private void pf_Click(object sender, EventArgs e)
        {

          
            double f1, c1, ea, es, vant = 0;
            int iteracion = 0;
            gravedad.Text = "9.8";

            c1 = Convert.ToDouble(C1.Text);            
            f1 = operaciones.fc(masa.Text, tiempo.Text, c1, velocidad.Text);
            fc1.Text = Convert.ToString(f1);                       
            es = Convert.ToDouble(ers.Text);        
            vant = 0;
            ea = 100;
            c1 = f1;

            while (Math.Abs(ea) > es)
            {
                //Sustituir c en la funcion y sumar c a la funcion
                f1 =operaciones.fc(masa.Text, tiempo.Text, c1, velocidad.Text)+c1;
                ea = ((f1 - vant) / f1) * 100;
                vant = f1;
                c1 = f1;

                iteracion++;

                valor.Text = Convert.ToString(c1);
                it.Text = Convert.ToString(iteracion);
                era.Text = Convert.ToString(ea);
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            listf.Add(fxn.Text);
            listx.Add(X.Text);
        }

        private void calcular_Click_1(object sender, EventArgs e)
        {

            decimal b0 = Convert.ToDecimal(listf[0]);            
            decimal f1 =Convert.ToDecimal(listf[1]) , f2 = Convert.ToDecimal(listf[2]), f3 = Convert.ToDecimal(listf[3]), f4 = Convert.ToDecimal(listf[4]), f5 = Convert.ToDecimal(listf[5]), f6 = Convert.ToDecimal(listf[6]), f7 = Convert.ToDecimal(listf[7]), f8 = Convert.ToDecimal(listf[8]);
            decimal x0 = Convert.ToDecimal(listx[0]), x1 = Convert.ToDecimal(listx[1]), x2 = Convert.ToDecimal(listx[2]), x3 = Convert.ToDecimal(listx[3]), x4 = Convert.ToDecimal(listx[4]), x5 = Convert.ToDecimal(listx[5]), x6 = Convert.ToDecimal(listx[6]), x7 = Convert.ToDecimal(listx[7]), x8 = Convert.ToDecimal(listx[8]);

            decimal x = Convert.ToDecimal(X.Text);
            int n = Convert.ToInt16(ndatos.Text);
            for(int i=0; i>n; i++)
            {
                decimal b = operaciones.b(Convert.ToDecimal(listf[i]), Convert.ToDecimal(listf[i+1]), Convert.ToDecimal(listx[i-1]), Convert.ToDecimal(listx[i]));
                listb.Add(b);
            }


            /*decimal b10 =operaciones.b(f0, f1, x0, x1);
            decimal b11 = operaciones.b(f1, f2, x1, x2);
            decimal b12 = operaciones.b(f2, f3, x2, x3);
            decimal b13 = operaciones.b(f3, f4, x3, x4);
            decimal b14 = operaciones.b(f4, f5, x4, x5);
            decimal b15 = operaciones.b(f5, f6, x5, x6);
            decimal b16 = operaciones.b(f6, f7, x6, x7);
            decimal b17 = operaciones.b(f7, f8, x7, x8);

            decimal b21 = operaciones.b(b11, b12, x2, x1);
            decimal b22 = operaciones.b(b12, b13, x2, x3);
            decimal b23 = operaciones.b(b13, b14, x3, x4);
            decimal b24 = operaciones.b(b14, b15, x4, x5);
            decimal b25 = operaciones.b(b15, b16, x5, x6);
            decimal b26 = operaciones.b(b16, b17, x6, x7);

            decimal b31 = operaciones.b(b21, b22, x2, x1);
            decimal b32 = operaciones.b(b22, b23, x2, x3);
            decimal b33 = operaciones.b(b23, b24, x3, x4);
            decimal b34 = operaciones.b(b24, b25, x4, x5);
            decimal b35 = operaciones.b(b25, b26, x5, x6);

            decimal b41 = operaciones.b(b31, b32, x2, x1);
            decimal b42 = operaciones.b(b32, b33, x2, x3);
            decimal b43 = operaciones.b(b33, b34, x3, x4);
            decimal b44 = operaciones.b(b34, b35, x4, x5);

            decimal b51 = operaciones.b(b41, b42, x2, x1);
            decimal b52 = operaciones.b(b42, b43, x2, x3);
            decimal b53 = operaciones.b(b43, b44, x3, x4);

            decimal b61 = operaciones.b(b51, b52, x2, x1);
            decimal b62 = operaciones.b(b52, b53, x2, x3);

            decimal b71 = operaciones.b(b61, b62, x2, x1);

            fx = b0 + b10*(x - x0) + b21 * (x - x0)*(x - x1) + b31 * (x - x0)*(x - x1)*(x - x2) + b31 * (x - x0)*(x - x1)*(x - x2) + b31 * (x - x0) * (x - x1) * (x - x2) * (x - x3) + b31 * (x - x0) * (x - x1) * (x - x2) * (x - x3) * (x - x4)
            */










        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
        }

        private void agrex_Click(object sender, EventArgs e)
        {
            X.Enabled = false;
        }
    }   
}
