using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUno
{
    class ProyectoUno
    {

        //Atributos de la clase
        //Metodos constructores

        //Los metodos del usuario

        /*public decimal calprom( Int16 cal1, Int16 cal2, Int16 cal3) {

            decimal W;
            W = (cal1 + cal2 + cal3) / 3;

            return W;
                            
        }

        public void muestrarProm(decimal prom) {

            Console.Write("El promedio es: ");
            Console.Write(prom);
            Console.ReadLine();

            return;

        }*/


        static void Main(string[] args)
        {
            ProyectoUno obj = new ProyectoUno();
            Libreria.Libreria ObjLibreria = new Libreria.Libreria();

            //Atributos del Main
            Int16 a, b, c;
            decimal prom;

            String e;

            //Entrada de datos
                Console.WriteLine("Dar el valor de a");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Dar el valor de b");
                b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Dar el valor de c");
                c = Convert.ToInt16(Console.ReadLine());
            //Un proceso
                 // prom = (a + b + c) / 3;
                prom = ObjLibreria.calprom(a,b,c);
            //Resultado
            ObjLibreria.muestrarProm(prom);
        }
    }
}
