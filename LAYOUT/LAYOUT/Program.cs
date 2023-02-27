using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYOUT.Utilerias;

namespace LAYOUT
{
    class Program
    {

        static void Main(string[] args)
        {

            Printer.PrintTitle("PORTAL DE EMPLEADOS");

            Console.WriteLine("\n Menú del portal de empleados, seleccione la acción a relizar.\n");

            Console.WriteLine("\t a.- Buscar un empleado");
            Console.WriteLine("\t b.- Agregar un empleado");
            Console.WriteLine("\t c.- Eliminar un empleado");
            Console.WriteLine("\t d.- Alta masiva de empleados");
            Console.WriteLine("\t e.- Salir de la aplicación");

            Console.Write("\n Escriba la letra de la acción y presione enter para continuar: ");

            string accion = Console.ReadLine();
            Console.Clear();

            switch (accion)
            {
                case "a":
                    Console.WriteLine("Has elegido la opción a");
                    break;
                case "b":
                    Console.WriteLine("Has elegido la opción b");
                    break;
                case "c":
                    Console.WriteLine("Has elegido la opción c");
                    break;
                case "d":
                    Console.WriteLine("Has elegido la opción d");
                    break;
                case "e":
                    Console.WriteLine("Has elegido la opción e");
                    break;
                default:
                    Console.WriteLine("Esta opción no se encuentra en el menú");
                    break;
            }


            Console.ReadLine();
        }
    }
}
