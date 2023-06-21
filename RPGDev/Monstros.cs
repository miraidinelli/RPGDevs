using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Monstros : Personagem
    {

        public int IdMonstro { get; set; }
        public string TipoMonstro { get; set; }
        public int MobExperiencia { get; set; }
        public double Multiplicador { get; set; }

        public Monstros Mob01()
        {
            IdMonstro = 1;
            TipoMonstro = "COMUN";
            MobExperiencia = 10;
            HP = 10;
            Defesa = 10;
            Ataque = 4;
            return this;

        }
        public Monstros Mob02()
        {
            IdMonstro = 1;
            TipoMonstro = "RARO";
            MobExperiencia = 10;
            HP = 10;
            Defesa = 10;
            Ataque = 4;
            return this;

        }
        public Monstros Mob03()
        {
            IdMonstro = 1;
            TipoMonstro = "CHEFE";
            MobExperiencia = 20;
            HP = 10;
            Defesa = 10;
            Ataque = 4;
            return this;

        }
    }
}
