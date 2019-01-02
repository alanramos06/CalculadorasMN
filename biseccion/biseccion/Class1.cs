using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biseccion
{
    class operaciones

    {
        public static Double fc(String masa, string tiempo, double C, string velocidad)
        {
            Double m, t, c, g, v, fc;

            m = Convert.ToDouble(masa);
            t = Convert.ToDouble(tiempo);
            c = Convert.ToDouble(C);
            v = Convert.ToDouble(velocidad);
            g = 9.8;

            fc = ((g * m)/c)*(1 - (Math.Pow(Math.E,(-(c/m)*t))))-v;            
            return fc;

        }

        public static decimal b(decimal fx1, decimal fx2, decimal x1, decimal x2)
        {
            decimal b = fx2 - fx1 / x2 - x1;

            return b;
        }

    }
       
}
