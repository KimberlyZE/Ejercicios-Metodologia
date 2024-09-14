using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla = new int[3, 3];
            int[] sumafilas = new int[3];
            int[] sumacolumnas = new int[3];
            int sumapares = 0, sumaimpares = 0;
            int filas, columnas;

            Console.WriteLine("Ingrese los 9 números del arreglo");

            for (filas = 0; filas < 3; filas++)
            {
                for (columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write("Digite el número: ");
                    tabla[filas, columnas] = int.Parse(Console.ReadLine());

                    sumafilas[filas] += tabla[filas, columnas];
                    sumacolumnas[columnas] += tabla[filas, columnas];

                    //Se usa un if y un módulo para determinar si los números del arreglo son pares o impares
                    if (tabla[filas, columnas] % 2 == 0)
                    {
                        sumapares += tabla[filas, columnas];
                    }
                    else
                    {
                        sumaimpares += tabla[filas, columnas];
                    }
                }
            }

            // Imprime la matriz después de llenarla
            Console.WriteLine();
            Console.WriteLine("Matriz:");
            for (filas = 0; filas < 3; filas++)
            {
                for (columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write("{0} ", tabla[filas, columnas]); // Mostrar cada número dentro del arreglo en forma de matriz
                }
                Console.WriteLine();
            }

            // Muestra la suma de cada fila
            Console.WriteLine("");
            for (filas = 0; filas < 3; filas++)
            {
                Console.WriteLine("La suma de la fila {0} es: {1}", filas + 1, sumafilas[filas]);
            }

            // Muestra la suma de cada columna
            Console.WriteLine("");
            for (columnas = 0; columnas < 3; columnas++)
            {
                Console.WriteLine("La suma de la columna {0} es: {1}", columnas + 1, sumacolumnas[columnas]);
            }

            // Muestra la suma de los números pares e impares
            Console.WriteLine("");
            Console.WriteLine("La suma de los números pares es: {0}", sumapares);
            Console.WriteLine("La suma de los números impares es: {0}", sumaimpares);

            Console.ReadKey();
        }
    }
}

