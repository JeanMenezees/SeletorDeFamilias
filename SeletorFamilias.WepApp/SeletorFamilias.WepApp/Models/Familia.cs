using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.Models
{
    public class Familia
    {
        public ResponsavelFamiliar Responsavel { get; set; }
        public ConjugeFamiliar Conjuge { get; set; }
        public List<DependenteFamiliar> Dependentes { get; set; }
        public Familia(ResponsavelFamiliar responsavel, ConjugeFamiliar conjuge, List<DependenteFamiliar> dependentes)
        {
            ValidarDados(responsavel, conjuge);
            Responsavel = responsavel;
            Conjuge = conjuge;
            Dependentes = dependentes;
        }
        
        private void ValidarDados(ResponsavelFamiliar responsavel, ConjugeFamiliar conjuge)
        {
            if (responsavel == null)
            {
                throw new ArgumentException("A familia deve ter pelo menos um responsavel.");
            }

            if (conjuge == null)
            {
                throw new ArgumentException("A familia deve ter pelo menos um conjuge.");
            }
        }
    }
}
