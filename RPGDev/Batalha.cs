using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    public class Batalha
    {
        public int Dano { get; set; }
        public void Atacar(Personagem personagem, Personagem inimigo)
        {
            Random random = new Random();
            int numAleatorio = random.Next(1, 3);
            switch (numAleatorio)
            {
                case 1:
                    personagem.HP -= inimigo.Ataque;
                    inimigo.HP -= personagem.Ataque;
                    Console.WriteLine($"O inimigo te atacou de volta. Você recebeu {inimigo.Ataque} de dano.");
                    break;
                case 2:
                    inimigo.HP -= personagem.Ataque - inimigo.Defesa;
                    Console.WriteLine($"O inimigo se defendeu. Ele recebeu {personagem.Ataque - inimigo.Defesa} de dano.");
                    break;
            }
        }
        public void OrdemDosTurnos(Personagem personagem, Personagem inimigo)
        {
            while (personagem.HP > 0 && inimigo.HP > 0)
            {
                Console.WriteLine("1- Atacar");
                Console.WriteLine("2- Defender");
                Console.WriteLine("3- Ataque SUPREMO");
                Console.WriteLine("4- Fugir");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Atacar(personagem, inimigo);
                        break;
                    case 2:
                        Defender(personagem, inimigo);
                        break;
                    case 3:
                        AtaqueSupremo(personagem, inimigo);
                        break;
                    case 4:
                        Fugir(personagem);
                        break;
                }
                if (inimigo.HP <= 0)
                {
                    Console.WriteLine($"Você derrotou {inimigo.Nome}.");
                    break;
                }
                if (personagem.HP <= 0)
                {
                    Console.WriteLine("Você foi morto. GameOver!");
                    break;
                }
                Fugir(personagem);
            }
        }
        public void AtaqueSupremo(Personagem personagem, Personagem inimigo)
        {
            Random random = new Random();
            int numAleatorio = random.Next(1, 3);
            switch (numAleatorio)
            {
                case 1:
                    personagem.HP -= inimigo.Ataque + 2;
                    inimigo.HP -= personagem.Ataque + 2;
                    Console.WriteLine("Ataque supremo!!!");
                    Console.WriteLine($"O inimigo te atacou de volta. Você recebeu {inimigo.Ataque} de dano.");
                    break;
                case 2:
                    inimigo.HP -= personagem.Ataque + 2 - inimigo.Defesa;
                    Console.WriteLine("Ataque supremo!!!");
                    Console.WriteLine($"O inimigo se defendeu. Ele recebeu {personagem.Ataque + 2 - inimigo.Defesa} de dano.");
                    break;
            }
        }
        public void Defender(Personagem personagem, Personagem inimigo)
        {
            Random random = new Random();
            int numAleatorio = random.Next(1, 3);
            switch (numAleatorio)
            {
                case 1:
                    personagem.HP -= inimigo.Ataque - personagem.Defesa;
                    Console.WriteLine($"O inimigo te atacou e você se defendeu. Você recebeu {inimigo.Ataque - personagem.Defesa} de dano.");
                    break;
                case 2:
                    Console.WriteLine("Você e seu inimigo se defenderam. Ninguém sofreu danos.");
                    break;
            }
        }
        public void Fugir(Personagem personagem)
        {
            if (personagem.HP == 1)
            {
                Console.Write("Fugir? [s] ou [n]: ");
                char op = char.Parse(Console.ReadLine());
                if (op == 's') return;

            }
        }
    }
}
