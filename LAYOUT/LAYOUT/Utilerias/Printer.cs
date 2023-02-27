using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAYOUT.Utilerias
{
    static class Printer
    {
        public static void DrawDogMessage()
        {
            WriteLine("          __   _,--=\"=--,_   __");
            WriteLine("         /  \\.\"    .-.    \"./  \\");
            WriteLine("        /  ,/  _   : :   _  \\/` \\");
            WriteLine("        \\  `| /o\\  :_:  /o\\ |\\__/");
            WriteLine("         `-'| :=\"~` _ `~\"=: |");
            WriteLine("            \\`     (_)     `/");
            WriteLine("    .-\" -.   \\      |      /   .- \"-.");
            WriteLine(".---{     }--|  /,.-'-.,\\  |--{     }---.");
            WriteLine(" )  (_)_)_)  \\_/`~-===-~`\\_/  (_(_(_)  (");
            WriteLine("============================================");
            WriteLine("||                                        ||");
            WriteLine("||        Suscribete a mi canal :3        ||");
            WriteLine("||  Pulsa enter para limpiar la pantala   ||");
            WriteLine("============================================");
            ReadKey();
            Clear();
        }

        public static  void PrintTitle(string ptitulo)
        {
            string tituloFormateado = $"************* {ptitulo} *************";
            WriteLine("".PadLeft(tituloFormateado.Length, '='));
            WriteLine(tituloFormateado);
            WriteLine("".PadRight(tituloFormateado.Length, '='));
        }
    }
}
