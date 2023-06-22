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
        public int[] expNivel { get; set; }
        public List<>
        public Player()
        {
           
        }
        public Player(string nome,string clase, int espec)
        {
            this.Nome = nome;
            this.ClasseLuta = Classe;
            
            Nivel = 1;
            Experiencia = 1;
            Localização = new int[] { 1, 1 };
            Ataque = 10;
            Defesa = 10;
            HP = 10;
            expNivel = new int[] { 30, 60, 90, 150, 200 };
            if(espec == 1) {
                Ataque += 7; }
            else if (espec == 2)
            {
                Defesa += 7;
            }
            else
            {
                Ataque += 3;
                Defesa += 3;
            }

        }



    }
}
