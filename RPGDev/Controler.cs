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

    }
}
