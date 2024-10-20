using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos. Este programa se centra en las temperaturas y sus distintas conversiones(Celsius, Kelvin y Fahrenheit). A continuacion presiones Enter para continuar");
            Console.ReadLine();
            Console.Clear();

            // Listas para almacenar las temperaturas en Celsius, Fahrenheit y Kelvin
            List<double> temperaturasCelsius = new List<double>();
            List<double> temperaturasFahrenheit = new List<double>();
            List<double> temperaturasKelvin = new List<double>();

            bool continuar = true;

            // Bucle principal para ingresar temperaturas y convertirlas
            while (continuar)
            {
                Console.WriteLine("Ingrese una temperatura en grados Celsius:");
                double tempCelsius = double.Parse(Console.ReadLine());
                temperaturasCelsius.Add(tempCelsius);

                // Convertir la temperatura a Fahrenheit y Kelvin
                double tempFahrenheit = Funciones.ConvertirAFahrenheit(tempCelsius);
                double tempKelvin = Funciones.ConvertirAKelvin(tempCelsius);

                // Almacenar las temperaturas convertidas en las listas respectivas
                temperaturasFahrenheit.Add(tempFahrenheit);
                temperaturasKelvin.Add(tempKelvin);

                // Mostrar las temperaturas convertidas
                Console.WriteLine($"\nTemperatura en Fahrenheit: {tempFahrenheit}");
                Console.WriteLine($"Temperatura en Kelvin: {tempKelvin}\n");

                // Preguntar al usuario si desea ingresar otra temperatura
                Console.WriteLine("¿Desea ingresar otra temperatura? (s/n)");
                continuar = Console.ReadLine().ToLower() == "s";
                Console.Clear();
            }

            // Preguntar al usuario si desea eliminar alguna temperatura convertida
            Console.WriteLine("\n¿Desea eliminar alguna temperatura convertida? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                Funciones.EliminarTemperatura(temperaturasFahrenheit, temperaturasKelvin);
            }

            // Mostrar las listas de temperaturas convertidas
            Console.WriteLine("\nTemperaturas en Fahrenheit:");
            Funciones.MostrarLista(temperaturasFahrenheit);

            Console.WriteLine("\nTemperaturas en Kelvin:");
            Funciones.MostrarLista(temperaturasKelvin);
        }
    }
}
