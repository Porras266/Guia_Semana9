using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Usuario. Este programa se encarga de imprimir en orden inverso de una serie de numeros que elijas, ademas de mostrarte la cantidad de valores impares dentro de la misma");
            Console.ReadLine();
            Console.Clear();

            //Se Solicita al usuario que ingrese el tamaño del arreglo
            Console.WriteLine("Ingrese el tamaño del arreglo (Cantidad de numeros):");
            if (int.TryParse(Console.ReadLine(), out int tamaño) && tamaño > 0)
            {
                //Inicializa el arreglo con el tamaño especificado
                int[] arreglo = new int[tamaño];

                //Solicita al usuario que ingrese los elementos del arreglo (los numeros)
                for (int i = 0; i < tamaño; i++)
                {
                    Console.WriteLine($"Ingrese el numero {i + 1}:");
                    while (!int.TryParse(Console.ReadLine(), out arreglo[i]))
                    {
                        Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número entero:");
                    }
                }

                //Muestra el arreglo original
                Funciones.MostrarArreglo(arreglo, "Arreglo original:");

                //Invierte el arreglo y lo almacena dentro de una nueva variable
                int[] arregloInvertido = Funciones.InvertirArreglo(arreglo);

                //Muestra el arreglo invertido
                Funciones.MostrarArreglo(arregloInvertido, "Arreglo invertido:");

                //Cuenta la cantidad de valores impares dentro del arreglo invertido
                int cantidadImpares = Funciones.ContarImpares(arregloInvertido);

                //Muestra la cantidad de valores impares dentro del arreglo
                Console.WriteLine($"Cantidad de valores impares en el arreglo invertido: {cantidadImpares}");
            }
            else
            {
                Console.WriteLine("Tamaño del arreglo no válido. Debe ser un número entero y positivo.");
            }

        }
    }
}
