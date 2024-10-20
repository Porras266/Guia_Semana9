using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace VentasDiarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar mensaje inicial
            Console.WriteLine("Bienvenido. Este programa se centra en los almacenes de informacion de ventas diarias de X negocio, ademas de poder visualizar distintas funciones como encontrar su dia con mas ventas o su total vendido dentro de la semana, puede presionar Enter para continuar...");
            Console.ReadLine(); // Esperar a que el usuario presione Enter

            // Establecer la cultura a en-US
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            const int dias = 7; // Suponiendo una semana de ventas
            double[] ventas = new double[dias];
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Limpiar la pantalla antes de comenzar
            Console.Clear();

            // Llamada a funciones
            Funciones.IngresarVentas(ventas);
            double total = Funciones.CalcularTotalVentas(ventas);
            int diaMaxVenta = Funciones.EncontrarDiaMaxVenta(ventas);

            // Mostrar resultados
            Console.WriteLine($"Total vendido: {total:C}");
            Console.WriteLine($"Día con la venta más alta: {diasSemana[diaMaxVenta]} con {ventas[diaMaxVenta]:C}");
        }
    }
}
