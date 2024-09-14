using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Utilice un arreglo de un subíndice para resolver el siguiente problema. Una empresa le paga a su personal de ventas en base a comisión. Los vendedores reciben $200 por semana más 9 % de sus ventas brutas de dicha semana. Por ejemplo, un vendedor que vende $3000 en ventas brutas es una semana recibe $200 más 9% de 3000, o sea un total de $470. Escriba un programa en C# (utilizando un arreglo de contadores) que determine cuántos de los vendedores ganaron salarios en cada uno de los rangos siguientes (suponiendo que el salario de cada vendedor se trunca a una cantidad entera):
1.	$200-$299
2.	$300-$399
3.	$400-$499 
 $500-$599 
4.	5. $600-$699 
5.	6. $700-$799
1.	7. $800-$899
2.	8. $900-$999
3.	9. $1000 o superior
*/

class Program
{
    static void Main()
    {
        //Definimos las variables de las ventas brutas y el salario total al conocer la venta bruta
        double ventasbru, total;
        //Definimos la variable de salario en cantidad trunca, o sea entera 
        int trunca;
        // Arreglo para contar cuántos vendedores hay en cada rango de salario
        int[] salarios = new int[9];

        // Pedimos al usuario cuántos vendedores se van a calcular 
        Console.Write("Ingrese el número de vendedores: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Se hace un bucle para cada vendedor para obtener sus ventas y calcular su salario
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese las ventas brutas del vendedor {i + 1}: ");
            ventasbru = double.Parse(Console.ReadLine());

            // Calculamos el salario total a como indica el ejercicio
            total = 200 + (0.09 * ventasbru);

            // Convertimos el salario total a una cantidad entera 
            trunca = (int)total;

            // Determinamos el rango usando operadores relacionales y lógicos 
            if (trunca >= 200 && trunca <= 299)
                salarios[0]++;
            else if (trunca >= 300 && trunca <= 399)
                salarios[1]++;
            else if (trunca >= 400 && trunca <= 499)
                salarios[2]++;
            else if (trunca >= 500 && trunca <= 599)
                salarios[3]++;
            else if (trunca >= 600 && trunca <= 699)
                salarios[4]++;
            else if (trunca >= 700 && trunca <= 799)
                salarios[5]++;
            else if (trunca >= 800 && trunca <= 899)
                salarios[6]++;
            else if (trunca >= 900 && trunca <= 999)
                salarios[7]++;
            else if (trunca >= 1000)
                salarios[8]++;
        }

        // Mostramos el número de vendedores en cada rango con respecto a su salario 
        Console.WriteLine("Número de vendedores por rango salarial:");
        Console.WriteLine("$200 - $299: " + salarios[0]);
        Console.WriteLine("$300 - $399: " + salarios[1]);
        Console.WriteLine("$400 - $499: " + salarios[2]);
        Console.WriteLine("$500 - $599: " + salarios[3]);
        Console.WriteLine("$600 - $699: " + salarios[4]);
        Console.WriteLine("$700 - $799: " + salarios[5]);
        Console.WriteLine("$800 - $899: " + salarios[6]);
        Console.WriteLine("$900 - $999: " + salarios[7]);
        Console.WriteLine("$1000 o superior: " + salarios[8]);

        //Se pone para que el programa no termine hasta que el usuario presione una tecla 
        Console.ReadKey();
    }
}
