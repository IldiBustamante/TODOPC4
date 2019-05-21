using System;


namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando do e if, mostrar en consola los primeros n numeros pares con n ingresado por teclado

            //Declaro mis variables a utilizar

            int intContador = 0;
            int intNro = 0;
            //Pido que ingrese el numero hasta cual quiero ver

            Console.WriteLine("Ingrese hasta que numero par quiere ver");

            do
            {
                intNro = Convert.ToInt32(Console.ReadLine());

                if ( intNro >= 2)
                {
                    break;
                }
            } while (true);

      
            do

            {
                intContador +=2;
                Console.WriteLine(intContador);

            } while (intContador<intNro && intContador %2 ==0);


            if (true)
            {

            }
            //pausa en la consola
            Console.ReadKey();
        }
    }
}
