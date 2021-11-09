using System;
using System.Collections.Generic;

namespace SeletorFamilias.WepApp.Models
{
    public class Familia
    {
        public ResponsavelFamiliar Responsavel { get; set; }
        public ConjugeFamiliar Conjuge { get; set; }
        public List<DependenteFamiliar> Dependentes { get; set; }
        public int Pontuacao { get; private set; }
        private decimal RendaTotal;

        public Familia(ResponsavelFamiliar responsavel, ConjugeFamiliar conjuge, List<DependenteFamiliar> dependentes)
        {
            ValidarDados(responsavel, conjuge);
            Responsavel = responsavel;
            Conjuge = conjuge;
            Dependentes = dependentes;
            Pontuacao = 0;
            RendaTotal = DefinirRendaTotal(responsavel.Renda, conjuge.Renda);
        }

        public decimal ObterRendaTotal() => RendaTotal;

        public void AcrescentarPontuacao(int pontuacao)
        {
            Pontuacao += pontuacao;
        }

        private decimal DefinirRendaTotal(decimal rendaResponsavel, decimal rendaConjuge)
        {
            if(rendaResponsavel + rendaConjuge < 0)
            {
                throw new Exception("A familia deve ter uma renda total maior ou igual a zero.");
            }

            return rendaResponsavel + rendaConjuge;
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
