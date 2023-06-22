using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Menu
    {


        public int  MenuInicial()
        {
            bool flag = false;
            List<Personagem> listaPersonagens = new List<Personagem>();

            while (!flag)
            {
                Console.WriteLine("\nCriação de Personagem");
                Console.WriteLine("Digite uma Opção para Começar");
                Console.WriteLine("1 - Criar Personagem");
                Console.WriteLine("2 - Mostrar Personagem");
                Console.WriteLine("3 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nDigite a Clase do seu Personagem:");
                        Console.WriteLine("Digite o Númeo Desejado");
                        Console.WriteLine("1 - Guerreiro");
                        Console.WriteLine("2 - Mago");
                        Console.WriteLine("3 - Ranger");
                        int classe = int.Parse(Console.ReadLine());
                        switch (classe)
                        {
                            case 1:

                                return 1;
                                
                            case 2:

                                return 2;
                            case 3:

                                return 3;
                        }
                        return 0;
                    case "2":
                        Console.WriteLine("\nSeu Personagem: ");
                        foreach (Personagem personagem in listaPersonagens)
                        {

                            Console.WriteLine(personagem.ToString());
                        }
                        return 0;
                    case "3":
                        flag = true;
                        return 0;
                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        return 0;
                }
                flag = true;
                return 0;
            }
            return 0;
        }
    }
}
