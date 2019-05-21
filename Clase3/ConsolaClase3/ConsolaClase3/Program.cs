using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //contadora
            int intNumero = 2;
            Console.WriteLine("Valor de un intNumero: {0}", intNumero);
            intNumero = intNumero + 1;
            Console.WriteLine("Valor de un intNumero: {0}", intNumero);
            intNumero += 1;
            Console.WriteLine("Valor de un intNumero: {0}", intNumero);
            intNumero++;
            Console.WriteLine("Valor de un intNumero: {0}", intNumero++); // aca se vuelve 6 pero no muestro
            Console.WriteLine("Valor de un intNumero: {0}", --intNumero);
            //acumulador desde aca
            int intNumero2 = 10;
            intNumero2 += intNumero;
            Console.WriteLine("Valor de un intNumero: {0}", intNumero2);


            //pausa en la consola
            Console.ReadKey();
        }
    }
}
