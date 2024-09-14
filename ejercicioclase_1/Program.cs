using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño = 10;
            int[] numeros = new int[10];
            int sumapares = 0, sumaimpares = 0;
            Console.WriteLine("Digite los 10 números del arreglo.");
            Console.WriteLine();
            for (int i = 0; i < tamaño; i++)
            {   
                //Lee y suma los números
                Console.Write("Ingresa un número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    sumapares += numeros[i];
                }
                else
                {
                    sumaimpares += numeros[i];
                }
            }
            Console.WriteLine("Números ingresados en el arreglo:");
            for (int i = 0; i < tamaño; i++)
            { 
                //Muestra en pantalla de números del arreglo
                Console.Write("{0}, ", numeros[i]);
            }

            //Muestra en pantalla de la suma par e impar de números
            Console.WriteLine("");
            Console.Write("Suma de números pares: {0}", sumapares);
            Console.WriteLine("");
            Console.Write("Suma de números impares: {0}", sumaimpares);

            Console.ReadKey();
        }
    }
}
