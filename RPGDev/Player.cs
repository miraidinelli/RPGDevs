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
        public List<Itens> itens { get; set; }
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
            itens = new List<Itens>();
            
            

        }

        public override int CalcularDano()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(1, 3);

            if (numeroSorteado == 1) return (base.CalcularDano() * 2);
            return Ataque;
            
        }

    }
}
