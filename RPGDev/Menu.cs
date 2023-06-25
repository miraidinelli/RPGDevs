using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Menu
    {
        public int MenuInicial()
        {
            Console.WriteLine("\nCriação de Personagem");
            Console.WriteLine("Digite uma Opção para Começar");
            Console.WriteLine("1 - Criar Personagem");
            Console.WriteLine("2 - Sair");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\nEscolha a Clase do seu Personagem:");
                    Console.WriteLine("Digite o Número Desejado");
                    Console.WriteLine("1 - Guerreiro");
                    Console.WriteLine("2 - Mago");
                    Console.WriteLine("3 - Ranger");
                    string classe = Console.ReadLine();
                    switch(classe)
                    {
                        case "1":
                            return 1;
                        case "2": 
                            return 2;
                        case "3":
                            return 3;
                    }
                    return 0;
                case "2":

                    return 4;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    return 0;
            }
        }
    }
}

