using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int HP { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public Habilidade Habilidade { get; set; }
    }

    public class Guerreiro : Personagem
    {
        public int Forca { get; set; }

        public Guerreiro(string nome, int ataque, int defesa, int hp, int forca)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Forca = forca;
        }
    }

    public class Mago : Personagem
    {
        public int Magia { get; set; }

        public Mago(string nome, int ataque, int defesa, int hp, int magia)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Magia = magia;
        }
    }

    public class Ranger : Personagem
    {
        public int Destreza { get; set; }

        public Ranger(string nome, int ataque,int defesa, int hp,  int destreza)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Destreza = destreza;
        }
    }
}
