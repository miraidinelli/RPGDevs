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
        public string Classe { get; set; }
        public Habilidade Habilidade { get; set; }

        // Método CalcularDano
        public virtual int CalcularDano()
        {
            return Ataque;
        }

        // Sobrescrevendo o ToString 
        public override string ToString()
        {
            return $"Nome: {Nome}, Hp: {HP}, Ataque: {Ataque}," +
                   $" Defesa: {Defesa}, Tipo: {Classe}";
        }
    }

    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome,int ataque,int defesa,int hp,string forca)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Habilidade = new Habilidade(forca,"Golpes",Ataque * +2);
        }
        public Guerreiro() { }
    }

    public class Mago : Personagem
    {
        public Mago(string nome,int ataque,int defesa,int hp,string magia)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Habilidade = new Habilidade(magia,"Misteriosa",Ataque - 1);
        }
        public Mago() { }
    }

    public class Ranger : Personagem
    {
        public Ranger(string nome,int ataque,int defesa,int hp,string destreza)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Habilidade = new Habilidade(destreza,"Capacidade",Ataque - 2);
        }
        public Ranger() { }
    }
}
