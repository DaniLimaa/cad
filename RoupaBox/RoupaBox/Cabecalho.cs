﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Cabecalho
    {
        public void exibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Daniel Camargo");
            Console.ForegroundColor= ConsoleColor.Red;   
            Console.WriteLine("═════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═════════════════════════════════════");
            Console.ResetColor();
        }
}
}
