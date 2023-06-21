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
            (string, int, int, int, int)ConstruirPersonagem()
            {
                int ataque = 0;
                int defesa = 0;
                int hp = defesa * 2;
                int atributo = ataque;

                Console.WriteLine("Digite o Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
                string tipo = Console.ReadLine();
                switch (tipo)
                {
                    case "1":
                        ataque = 7;
                        defesa = 3;
                        break;
                    case "2":
                        ataque = 3;
                        defesa = 7;
                        break;
                    case "3":
                        ataque = 5;
                        defesa = 5;
                        break;
                }
                return (nome, ataque, defesa, hp, atributo);
            }
            while (!flag)
            {
                Console.WriteLine("Criação de Personagem");
                Console.WriteLine("Digite uma Opção para Começar");
                Console.WriteLine("1 - Criar Personagem");
                Console.WriteLine("2 - Mostrar Personagem");
                Console.WriteLine("3 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                            Console.WriteLine("Digite a Clase do seu Personagem:");
                            Console.WriteLine("Digite o Númeo Desejado");
                            Console.WriteLine("1 - Guerreiro");
                            Console.WriteLine("2 - Mago");
                            Console.WriteLine("3 - Ranger");
                            string classe = Console.ReadLine();
                            switch(classe)
                            {
                                case "1":
                                Guerreiro guerreiro = new Guerreiro();
                                    break;
                                case "2":
                                Mago mago = new Mago();
                                    break;
                                case "3":
                                Ranger ranger = new Ranger();
                                break;
                            }
                        break;
                    case "2":
                        Console.WriteLine("Seu Personagem: ");

                        break;
                    case "3":
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
