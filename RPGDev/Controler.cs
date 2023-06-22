using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Controler
    {
        public Player P1 { get; set; }
        public Mapa Mp1 { get; set; }
        public Menu menu;
        public Controler()
        {
            menu = new Menu();
            if (menu.MenuInicial() == 1)
            {
                Console.WriteLine("Digite o Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
                string tipo = Console.ReadLine();
                P1 = new Player( nome, "GUERREIRO",tipo);

            }
            else if(menu.MenuInicial() == 2)
            {
                Console.WriteLine("Digite o Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
                string tipo = Console.ReadLine();
                P1 = new Player(nome, "MAGE", tipo);

            }
            else if (menu.MenuInicial() == 3)
            {
                Console.WriteLine("Digite o Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
                string tipo = Console.ReadLine();
                P1 = new Player(nome, "RANGE", tipo);

            }
            Mp1 = new Mapa();
            P1.Localização = Mp1.entrada;
            Console.WriteLine(P1.Nome);
            Console.WriteLine(P1.Localização[0].ToString());

            Console.ReadKey();
        }
        public void OpcoesMap()
        {
            Console.WriteLine("Voce entrou no labirinto");
            Console.WriteLine("Voce pode andar em 4 direcoes");
            Console.WriteLine("digite 1 para ir para o Norte");
            Console.WriteLine("digite 2 para ir para o SUL");
            Console.WriteLine("digite 3 para ir para o Leste");
            Console.WriteLine("digite 4 para ir para o Oest");
            int opcao = int.Parse(Console.ReadLine());
            if (ChecarCaminho(opcao))
            {
                Console.WriteLine(" eta nois");
            }


        }
        public bool ChecarCaminho(int opcao)
        {
            if(opcao == 4 && P1.Localização[0] <= 0) { return false; }
            if (opcao == 1 && P1.Localização[1] <= 0) { return false; }
            if (opcao == 3 && P1.Localização[0] >= 11) { return false; }
            if (opcao == 2 && P1.Localização[1] >= 11) { return false; }
            return true;
        }

    }
}
