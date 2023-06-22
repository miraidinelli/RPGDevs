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

        public Monstros Mob01(double mult)
        {
            IdMonstro = 1;
            Nome = "Ratao do esgoto";
            TipoMonstro = "COMUN";
            MobExperiencia = 10;
            
            HP = (int)(10 * mult);
            Defesa = (int)(10 * mult);
            Ataque = (int)(10 * mult);
            return this;

        }
        public Monstros Mob02(double mult)
        {
            IdMonstro = 1;
            TipoMonstro = "RARO";
            MobExperiencia = (int)(15 * mult);
            HP = (int)(15 * mult);
            Defesa = (int)(15 * mult);
            Ataque = (int)(15 * mult);
            return this;

        }
        public Monstros Mob03(double mult)
        {
            IdMonstro = 1;
            TipoMonstro = "CHEFE";
            MobExperiencia = (int)(20 * mult);
            HP = (int)(20 * mult);
            Defesa = (int)(20 * mult);
            Ataque = (int)(20 * mult);
            return this;

        }
    }
}
