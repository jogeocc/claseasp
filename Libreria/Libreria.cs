using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libreria
    {
        public decimal calprom(Int16 cal1, Int16 cal2, Int16 cal3)
        {

            decimal W;
            W = (cal1 + cal2 + cal3) / 3;

            return W;

        }

        public void muestrarProm(decimal prom)
        {

            Console.Write("El promedio es: ");
            Console.Write(prom);
            Console.ReadLine();

            return;

        }
    }
}
