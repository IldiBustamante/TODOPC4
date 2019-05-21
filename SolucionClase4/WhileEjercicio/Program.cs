using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar los primeros 4 numeros pares

            //declaro mis variables

            int intNro = 2;
             
            while (intNro<10)
            {
                Console.WriteLine(intNro);
                intNro += 2;
                
            }
            Console.ReadKey();
        }
    }
}
