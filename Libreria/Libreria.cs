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

        public decimal CalPromProms(decimal[] vector, Int16 k) {
            decimal prom = 0, resp = 0;
            Int16 ciclo;

            for (ciclo = 0; ciclo < k; ciclo++) {
                resp += vector[ciclo];
            }

            prom = resp / k;

            return prom;
        }

        public void DespliegaPromProms(decimal promprom) {

            Console.WriteLine("El promedio general es: {0}", promprom);
           
            return;
        }

    }
}
