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
        public int Forca { get; set; }
        public Guerreiro(string nome,int hp,int ataque,int defesa,int forca)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Forca = forca;
            Habilidade = new Habilidade("Corte Preciso","Fortificada",Ataque * +2);
        }
        public int DanoGuerreiro()
        {
            return 5 ;
        }

        public int VidaGuerreiro()
        {
            return 20;
        }
        public Guerreiro() { }
    }

    public class Mago : Personagem
    {
        public int Magia { get; set; }
        public Mago(string nome,int hp,int ataque,int defesa,int magia)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Magia = magia;
            Habilidade = new Habilidade("Teletransporte","Ilusão",Ataque - 1);
        }
        public Mago() { }

        public int DanoMago()
        {
            return 3;
        }
        public int VidaMago()
        {
            return 18;
        }
    }

    public class Ranger : Personagem
    {
        public int Destreza { get; set; }
        public Ranger(string nome,int hp,int ataque,int defesa,int destreza)
        {
            Nome = nome;
            HP = hp;
            Ataque = ataque;
            Defesa = defesa;
            Destreza = destreza;
            Habilidade = new Habilidade("Tiro Preciso","Armadilhas",Ataque - 2);
        }
        public Ranger() { }
        public int DanoRanger()
        {
            return 6;
        }
        public int VidaRanger()
        {
            return 15;
        }
    }
}
