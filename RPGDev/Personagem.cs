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

        public Personagem ConstruirPersonagem()
        {
            Personagem p = new Personagem();
            int ataque = 0;
            int defesa = 0;

            Console.WriteLine("Digite o Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu Personagem será: 1- Atacante/ 2- Defensor/ 3- Misto");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    ataque = 7;
                    defesa = 3;
                    tipo = "Atacante";
                    break;
                case "2":
                    ataque = 3;
                    defesa = 7;
                    tipo = "Defensor";
                    break;
                case "3":
                    ataque = 5;
                    defesa = 5;
                    tipo = "Misto";
                    break;
             
            }
            int hp = defesa * 2;
            int atributo = ataque;

            p.HP = hp;
            p.Ataque = atributo;   
            p.Defesa = defesa;
            p.Nome = nome;
            p.Classe = tipo;

            return p;
        }
        // Sobrescrevendo o ToString 
        public override string ToString()
        {
            return $"Nome: {Nome}, Hp: {HP}, Ataque: {Ataque}, Defesa: {Defesa}, Tipo: {Classe}";
        }
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
        public Guerreiro() { }
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
        public Mago() { }
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
        public Ranger() { } 
    }
}
