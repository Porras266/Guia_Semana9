using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    struct Persona
    {
        public string Nombre;
        public string Direccion;
        public string Telefono;
        public int Edad;
    }

    //List<persona> significa que creamos la lista llamada persona pero la pasamos a funcion con el personas 
    static void MostrarNombres(List<Persona> personas)
    {
        //el Foreach es un bucle especializado en recorrer colecciones, como listas o arrays.
        //el tipo de dato var le dice al compilador que deduzca el tipo de la variable basada en el valor que se le asigna
        foreach (var persona in personas)
        {
            Console.WriteLine(persona.Nombre);
        }
    }

    //sobre la misma /List<persona> agregamos de tipo entero edad
    static void MostrarPorEdad(List<Persona> personas, int edad)
    {
        foreach (var persona in personas)
        {
            if (persona.Edad == edad)
            {
                Console.WriteLine($"{persona.Nombre} {persona.Direccion} {persona.Telefono} {persona.Edad}");
            }
        }
    }

    //sobre la misma List<persona> agregamos de tipo string 
    static void MostrarPorNombre(List<Persona> personas, string nombre)
    {
        foreach (var persona in personas)
        {
            if (persona.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{persona.Nombre} {persona.Direccion} {persona.Telefono} {persona.Edad}");
            }
        }
    }

    static void Main()
    {
        //creacion del /List<persona> personas 
        List<Persona> personas = new List<Persona>();
        char opcion;

        Console.WriteLine("El siguiente programa primero solicitara el nombre la direccion telefono y edad de una persona y luego te pedira si quieres continuar guardando informacion o no se imprimira un menu para mostrar informacion en pantalla\n");
        Console.WriteLine("Presione cualquier tecla para continuar\n");
        Console.ReadKey();

        //persona 
        do
        {
            Persona p = new Persona();
            Console.Write("Ingrese el nombre: ");
            p.Nombre = Console.ReadLine();
            Console.Write("Ingrese la direccion: ");
            p.Direccion = Console.ReadLine();
            Console.Write("Ingrese el telefono: ");
            p.Telefono = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            p.Edad = int.Parse(Console.ReadLine());
            personas.Add(p);

            // Limpiar la pantalla después de ingresar los datos
            Console.Clear();

            Console.Write("Desea ingresar otra persona? (s/n): ");
            opcion = Console.ReadLine().ToLower()[0];
        } while (opcion == 's');

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Mostrar todos los nombres");
            Console.WriteLine("2. Mostrar personas por edad");
            Console.WriteLine("3. Mostrar personas por nombre");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = Console.ReadLine().ToLower()[0];

            // Limpiar la pantalla después de mostrar el menú
            Console.Clear();

            switch (opcion)
            {
                case '1':
                    MostrarNombres(personas);
                    break;
                case '2':
                    Console.Write("Ingrese la edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    MostrarPorEdad(personas, edad);
                    break;
                case '3':
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    MostrarPorNombre(personas, nombre);
                    break;
                case '4':
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }

            // Limpiar la pantalla después de ejecutar cada opción
            Console.Clear();

        } while (opcion != '4');
    }
}
