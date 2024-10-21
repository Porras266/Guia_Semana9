using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicio1
{
    internal class Calcular_Area_Triangulo
    {

        //metodo para calcular el area

        public static double calcular_area_triangulo(double Base, double Altura)
        {
            double Area;
            Area = Base * Altura / 2;
            return Area;
        }

        //Metodo para imprimir el resultado
        public static void ImprimirResultado(double Area)
        {
            Console.WriteLine($"El Area del triangulo es: {Area:F2}");
        }

    }
}