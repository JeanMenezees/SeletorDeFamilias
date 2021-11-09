using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletorDeFamilias.Servicos
{
    public class PontuadorDeFamilias
    {
        List<ICriterio> Criterios = new List<ICriterio>() { new CriterioRendaAte900Reais(), new CriterioRendaEntre901e1500()
                                                        , new CriterioUmOuDoisDependentes(), new CriterioPeloMenosTresDependentes()};
        public void Pontuar(Familia familia)
        {
            foreach(var criterio in Criterios)
            {
                criterio.Avaliar(familia);
            }
        }
    }
}
