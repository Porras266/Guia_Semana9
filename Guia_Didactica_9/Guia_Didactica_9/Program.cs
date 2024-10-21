using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicio1
{
internal class Program
{
static void Main(string[] args)
{
Console.WriteLine("El siguiente programa Solicita la base su altura de un triangulo y Calculará el area\n");

Console.WriteLine("Ingrese la altura del triangulo");
double Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la base del triangulo");
double Base = double.Parse(Console.ReadLine());

double Area = Calcular_Area_Triangulo.calcular_area_triangulo(Altura, Base);
Calcular_Area_Triangulo.ImprimirResultado(Area);

Console.ReadKey();

}
}
}