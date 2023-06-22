using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    public class Habilidade
    {
        // Nome da habilidade
        public string NomeHabilidade { get; set; }
        // Tipo da habilidade (ex.: "Fogo", "Gelo", "Elétrico", etc.)
        public string TipoHabilidade { get; set; }
        // O dano causado pela habilidade
        public int DanoBaseHabilidade { get; set; }

        public Habilidade
        (string nomeHabilidade, string tipoHabilidade, int danoBaseHabilidade)
        {
            NomeHabilidade = nomeHabilidade;
            TipoHabilidade = tipoHabilidade;
            DanoBaseHabilidade = danoBaseHabilidade;
        }
    }
}
