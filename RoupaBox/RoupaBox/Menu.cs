﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class ExibirMenu
    {
            public void Menu(Produtos varPro, Clientes varCli)
        {
            List<ProdutoCad> listaP = new List<ProdutoCad>();
            List<ProdutoCad> listaC = new List<ProdutoCad>();

            Console.WriteLine("\nDigite 0 para sair");
            Console.WriteLine("\nDigite 1 para cadastro de clientes");
            Console.WriteLine("\nDigite 2 para listar clientes");
            Console.WriteLine("\nDigite 3 para cadastro de produtos");
            Console.WriteLine("\nDigite 4 para listar produtos");
            Console.WriteLine();
            Console.WriteLine("Digite a opção escolhida");
            int opcoes_menu = int.Parse(Console.ReadLine());

            switch (opcoes_menu)
            {
                case 0:

                    Console.WriteLine("");
                    break;

                case 1:


                    //varCli.cadCliente();
                    break;

                case 2:

                    Console.WriteLine("");
                    break;

                case 3:


                    varPro.cadProdutos();
                    break;

                case 4:

                    Console.WriteLine("");
                    break;
            }
        }
    }
}