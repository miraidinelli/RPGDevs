﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Combate
    {
        public Monstros mob1;
        public Player p1;
        int turn;
        public Combate()
        {
            turn = 0;
        }

        public bool RealizarCombat(Player player, Monstros mob)
        {
            p1 = player;
            mob1 = mob;
            Console.WriteLine("Voce entrou em combat!");
            Console.WriteLine("");
            while (!IsDead(p1) && !IsDead(mob1))
            {
                Console.WriteLine("");
                Console.WriteLine("digite 1 para ir para o Atacar");
                Console.WriteLine("digite 2 para ir para o Defender");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Voce realiza um ataque!");
                    Atacar();
                    Console.WriteLine("Monstro realiza um ataque!");
                    MobAtaca();

                }
                if (opcao == 2)
                {

                }
            }
            if (IsDead(p1)) { return false; }
            if (IsDead(mob1)) { return true; };
            return true;
            }
        
        public void Combat()
        {



        }

        
        public void Atacar()
        {
            mob1.HP = mob1.HP - p1.Ataque ;
            Console.WriteLine($"seu ataque causou {p1.Ataque} de dano");

        }
        public void Defender()
        {
            mob1.HP = mob1.HP - p1.Ataque;

        }
        public void MobAtaca()
        {
            p1.HP = p1.HP - mob1.Ataque;
            Console.WriteLine($"{mob1.Nome} Atacou e causou {mob1.Ataque}");

        }
        public bool IsDead(Personagem p1)
            {
            if (p1.HP <= 0) { 
                Console.WriteLine($"{p1.Nome} Morreu");
                return true; 
            }
             return false; 
            }



    }
}
