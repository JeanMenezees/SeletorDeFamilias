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
            Responsavel = responsavel;
            Conjuge = conjuge;
            Dependentes = dependentes;
        }
    }
}
