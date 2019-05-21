
using System;

namespace Multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solcitar un numero del 1 al 9 y genera la tabla de multiplicar

            //Declaro mis variables a utilizar

            //Pido numero al usuario para generar la tabla

            //Console.WriteLine("Ingrese el numero del cual quiere ver la tabla de multiplicar");
            //int intMultiplicado = Convert.ToInt32(Console.ReadLine());

            //Iniciar la tabla

            // declaro variable

            int intMultiplicado;
            int intNro;

            Console.WriteLine("Ingrese el numero del cual quiere ver la tabla de multiplicar");
            intMultiplicado = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {

                intNro = intMultiplicado * i;
                Console.WriteLine(intNro);
            }

            Console.ReadKey();
        }
    }
}
