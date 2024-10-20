using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasDiarias
{
    internal class Funciones
    {
        public static void IngresarVentas(double[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write($"Ingrese las ventas del día {i + 1}: ");
                ventas[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
        }

        public static double CalcularTotalVentas(double[] ventas)
        {
            double total = 0;
            foreach (double venta in ventas)
            {
                total += venta;
            }
            return total;
        }

        public static int EncontrarDiaMaxVenta(double[] ventas)
        {
            int diaMax = 0;
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > ventas[diaMax])
                {
                    diaMax = i;
                }
            }
            return diaMax;
        }

    }
}
