using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MInha tentativa inicial de fazer um construtor de personagem
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
                            string classe = Console.ReadLine();
                            switch(classe)
                            {
                                case "1":

                                Guerreiro guerreiro = new Guerreiro();
                                listaPersonagens.Add(guerreiro.ConstruirPersonagem());
                                    break;
                                case "2":

                                Mago mago = new Mago();
                                listaPersonagens.Add(mago.ConstruirPersonagem());
                                break;
                                case "3":

                                Ranger ranger = new Ranger();
                                listaPersonagens.Add(ranger.ConstruirPersonagem());
                                break;
                            }
                        break;
                    case "2":
                        Console.WriteLine("\nSeu Personagem: ");
                        Console.WriteLine(listaPersonagens);
                        break;
                    case "3":
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
