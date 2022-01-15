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
            Printer Print = new Printer();
            Print.DrawDogMessage();

            string titulo = Console.ReadLine();
            Print.PrintTitle(titulo);


            Console.ReadLine();
        }
    }
}
