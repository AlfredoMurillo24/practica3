using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class class1
    {

        static void Main(string[] args)
        {
            string sl1;
            string sl2;
            string sl3;
            string sl4;
            int l1;
            int l2;
            int l3;
            int l4;
            int resultado;

            Console.WriteLine("Dame el lado 1");
            sl1 = Console.ReadLine();
            l1 = Convert.ToInt32(sl1);

            Console.WriteLine("Dame el lado 2");
            sl2 = Console.ReadLine();
            l2 = Convert.ToInt32(sl2);

            Console.WriteLine("Dame el lado 3");
            sl3 = Console.ReadLine();
            l3 = Convert.ToInt32(sl3);

            Console.WriteLine("Dame el lado 4");
            sl4 = Console.ReadLine();
            l4 = Convert.ToInt32(sl4);

            resultado = l1 + l2 + l3 + l4;
            Console.WriteLine("El perimetro de tu figura es: {0}", resultado);
            Console.ReadLine();
        }
    }
}
