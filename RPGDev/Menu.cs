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
            VerificaInput input = new VerificaInput();
            Console.WriteLine("Seja Bem Vindo a RataZona");
            Console.Write($"\n Criação de Personagem" +
                              $"\n Digite uma opção para começar" +
                              $"\n 1 - Criar Personagem" +
                              $"\n 2 - Sair" +
                              $"\n Opção -> ");
            int opcao = input.GetInput(1, 2);
            
            switch (opcao)
            {
                case 1 :
                    Console.Write($"\n Escolha a Classe do seu Personagem" +
                                      $"\n Digite a opção desejada" +
                                      $"\n 1 - Guerreiro" +
                                      $"\n 2 - Mago" +
                                      $"\n 3 - Ranger" +
                                      $"\n Opção -> ");
                    int classe = input.GetInput(1, 3);
                    return classe;

                case 2:
                    return 4;

                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    return MenuInicial();
            }
        }
    }
}

