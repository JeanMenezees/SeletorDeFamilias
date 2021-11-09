using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletorDeFamilias.Servicos
{
    public class CriterioPeloMenosTresDependentes : ICriterio
    {
        public void Avaliar(Familia familia)
        {
            if(familia.Dependentes.Count >= 3)
            {
                familia.AcrescentarPontuacao(3);
            }
        }
    }
}
