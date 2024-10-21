using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Funciones
    {
        //Muestra los elementos del arreglo en la consola
        public static void MostrarArreglo(int[] arreglo, string mensaje)
        {
            Console.WriteLine(mensaje);
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }

        //Invierte el arreglo
        public static int[] InvertirArreglo(int[] arreglo)
        {
            int[] invertido = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                //Se asignan los elementos del arreglo en orden inverso
                invertido[i] = arreglo[arreglo.Length - 1 - i];
            }
            return invertido;
        }

        //Cuenta los valores impares en el arreglo
        public static int ContarImpares(int[] arreglo)
        {
            int contador = 0;
            foreach (int valor in arreglo)
            {
                //Incrementa el contador si el valor es impar
                if (valor % 2 != 0)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
