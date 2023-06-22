using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Player :Personagem
    {
        public int Experiencia{ get; set; }
        public int Nivel { get; set; }
        public int[] Localização { get; set; }

        public string ClasseLuta { get; set; }
        public string Especializacao { get; set; }
        public Player()
        {
           
        }
        public Player(string nome,string clase, string espec)
        {
            this.Nome = nome;
            this.ClasseLuta = Classe;
            this.Especializacao = Especializacao;
            Nivel = 1;
            Experiencia = 1;
            Localização = new int[] { 1, 1 };
            Ataque = 10;
            Defesa = 10;
            HP = 10;

        }



    }
}
