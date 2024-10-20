using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Funciones
    {
        //Convierte de Celsius a Fahrenheit
        public static double ConvertirAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        //Convierte de Celsius a Kelvin
        public static double ConvertirAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        //Muestra los elementos de una lista
        public static void MostrarLista(List<double> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        //Elimina una temperatura de una lista seleccionada
        public static void EliminarTemperatura(List<double> listaFahrenheit, List<double> listaKelvin)
        {
            Console.WriteLine("Seleccione la lista de la que desea eliminar una temperatura:");
            Console.WriteLine("1. Fahrenheit");
            Console.WriteLine("2. Kelvin");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            //Selecciona la lista correspondiente según la opción del usuario
            List<double> listaSeleccionada = opcion == 1 ? listaFahrenheit : listaKelvin;

            //Pide al usuario el índice de la temperatura a eliminar
            Console.WriteLine("Ingrese el índice de la temperatura que desea eliminar:");
            int indice = int.Parse(Console.ReadLine());
            Console.Clear();

            //Verifica si el índice es válido y elimina dicha temperatura
            if (indice >= 0 && indice < listaSeleccionada.Count)
            {
                listaSeleccionada.RemoveAt(indice);
                Console.WriteLine("Temperatura eliminada.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");

            }
        }
    }
}
