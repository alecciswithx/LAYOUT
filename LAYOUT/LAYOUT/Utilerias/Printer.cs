using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYOUT.Utilerias
{
    class Printer
    {
        public void DrawDogMessage()
        {
            Console.WriteLine("          __   _,--=\"=--,_   __");
            Console.WriteLine("         /  \\.\"    .-.    \"./  \\");
            Console.WriteLine("        /  ,/  _   : :   _  \\/` \\");
            Console.WriteLine("        \\  `| /o\\  :_:  /o\\ |\\__/");
            Console.WriteLine("         `-'| :=\"~` _ `~\"=: |");
            Console.WriteLine("            \\`     (_)     `/");
            Console.WriteLine("    .-\" -.   \\      |      /   .- \"-.");
            Console.WriteLine(".---{     }--|  /,.-'-.,\\  |--{     }---.");
            Console.WriteLine(" )  (_)_)_)  \\_/`~-===-~`\\_/  (_(_(_)  (");
            Console.WriteLine("============================================");
            Console.WriteLine("||                                        ||");
            Console.WriteLine("||        Suscribete a mi canal :3        ||");
            Console.WriteLine("||  Pulsa enter para limpiar la pantala   ||");
            Console.WriteLine("============================================");
            Console.ReadKey();
            Console.Clear();
        }

        public void PrintTitle(string ptitulo)
        {
            string tituloFormateado = $"************* {ptitulo} *************";
            Console.WriteLine("".PadLeft(tituloFormateado.Length, '='));
            Console.WriteLine(tituloFormateado);
            Console.WriteLine("".PadRight(tituloFormateado.Length, '='));
        }
    }
}
