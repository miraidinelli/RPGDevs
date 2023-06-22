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
        public Monstros Mob { get; set; }
        public Mapa Mp1 { get; set; }

        public Menu menu;
        public double Dificuldade {get; set;}
        public Controler()
        {
            Dificuldade = 1.0;
            menu = new Menu();
            int opcao = menu.MenuInicial();
            if (opcao == 1)
            {
                Console.WriteLine("Digite o Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
                string tipo = Console.ReadLine();
                P1 = new Player( nome, "GUERREIRO",tipo);

            }
            else if(opcao == 2)
            {
                Console.WriteLine("Digite o Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
                string tipo = Console.ReadLine();
                P1 = new Player(nome, "MAGE", tipo);

            }
            else if (opcao == 3)
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
            OpcoesMap();
            Console.ReadKey();
        }
        public void OpcoesMap()
        {
            Console.WriteLine("Voce pode andar em 4 direcoes");
            Console.WriteLine("digite 1 para ir para o Norte");
            Console.WriteLine("digite 2 para ir para o SUL");
            Console.WriteLine("digite 3 para ir para o Leste");
            Console.WriteLine("digite 4 para ir para o Oest");
            Console.WriteLine("Digite 5 para ver status");
            int opcao = int.Parse(Console.ReadLine());
            if (ChecarCaminho(opcao)&& opcao!=5)
            {
                Movimentar(opcao);
                ChecarMapa();

            }else if(opcao == 5)
            {
                MostrarStatus();
                OpcoesMap();
            }
            else {
                Console.WriteLine("Nao caminho disponivel para este lado");
                Console.WriteLine("presione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                OpcoesMap();
            };


        }

        private void MostrarStatus()
        {
            Console.WriteLine($"Status do jogador");
            Console.WriteLine($"Nome - {P1.Nome}");
            Console.WriteLine($"Vida - {P1.HP}");
            Console.WriteLine($"Ataque - {P1.Ataque}");
            Console.WriteLine($"Defesa - {P1.Defesa}");
            Console.WriteLine($"Experiencia - {P1.Experiencia}");
            Console.WriteLine($"Precione qualquer tecla para retorna ao mapa");
            Console.ReadKey();
            Console.Clear();

        }

        private void ChecarMapa()
        {
            int ocupante = Mp1.formatoMapa[P1.Localização[0], P1.Localização[1]];
            if (ocupante == 0) { 
                Console.WriteLine("Nao tem ninguem por perto");
                OpcoesMap(); 
            }
            if (ocupante == 4) { Console.WriteLine("Voce achou a saida");
                Console.WriteLine($"Voce terminou  com {P1.Experiencia} de experiencia");
                Console.WriteLine("precione qualquer tecla pra fechar");
                Console.ReadKey();
            }
            if (ocupante == 1 || ocupante == 2 || ocupante == 3) {
                Console.WriteLine("Voce encontrou um monstro");
                Monstros criadormob = new Monstros();
                Mob = criadormob.Mob01(Dificuldade);
                OpcoesCombat();
            }
        
        }
        public void OpcoesCombat()
        {
            Console.WriteLine($"Voce entrou em combat com o{Mob.Nome} ");
            Combate cbt = new Combate();
            if(cbt.RealizarCombat(P1, Mob))
            {   P1.Experiencia += Mob.MobExperiencia;
                Dificuldade += 0.01;
                Console.WriteLine($"voce ganhou {Mob.MobExperiencia}");
                Console.WriteLine($"precione qualquer tecla para continuar a aventura");
                Console.ReadKey();
                Console.Clear();
                OpcoesMap();

            }
            else { Console.WriteLine(" Voce Faleceu! ");
                Console.WriteLine("qualquer tecla para encerrar");
                Environment.Exit(0);
            }

            Console.ReadKey();


        }

        public bool ChecarCaminho(int opcao)
        {
            if(opcao == 1 && P1.Localização[1] >= 9) { return false; }
            if (opcao == 2 && P1.Localização[1] <= 1) { return false; }
            if (opcao == 3 && P1.Localização[0] >= 9) { return false; }
            if (opcao == 4 && P1.Localização[0] <= 1) { return false; }
            return true;
        }
        public void Movimentar(int opcao)
        {
            if(opcao == 1) { P1.Localização[1] = P1.Localização[1] + 1;  return; }
            if (opcao == 2) { P1.Localização[1] = P1.Localização[1] - 1; return; }
            if (opcao == 3) { P1.Localização[0] = P1.Localização[0] + 1; return; }
            if (opcao == 4) { P1.Localização[0] = P1.Localização[0] - 1; return; }
        }

    }
}
