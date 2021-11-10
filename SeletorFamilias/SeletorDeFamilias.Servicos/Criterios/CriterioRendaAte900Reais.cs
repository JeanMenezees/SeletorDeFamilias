using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletorDeFamilias.Servicos
{
    public class CriterioRendaAte900Reais : ICriterio
    {
        public void Avaliar(Familia familia)
        {
            if(familia.ObterRendaTotal() <= 900)
            {
                familia.AcrescentarPontuacao(5);
            }
        }
    }
}
