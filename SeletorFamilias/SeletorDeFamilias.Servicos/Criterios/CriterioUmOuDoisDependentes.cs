using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletorDeFamilias.Servicos
{
    public class CriterioUmOuDoisDependentes : ICriterio
    {
        public void Avaliar(Familia familia)
        {
            if (familia.Dependentes.Count == 1
                || familia.Dependentes.Count == 2)
            {
                familia.AcrescentarPontuacao(2);
            }
        }
    }
}
