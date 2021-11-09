using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletorDeFamilias.Servicos
{
    public class CriterioRendaEntre901e1500 : ICriterio
    {
        public void Avaliar(Familia familia)
        {
            if(familia.ObterRendaTotal() >= 901 && 
                familia.ObterRendaTotal() <= 1500)
            {
                familia.AcrescentarPontuacao(3);
            }
        }
    }
}
