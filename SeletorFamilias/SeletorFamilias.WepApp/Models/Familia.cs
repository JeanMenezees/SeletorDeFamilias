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
        private decimal _rendaTotal;

        public Familia(ResponsavelFamiliar responsavel, ConjugeFamiliar conjuge, List<DependenteFamiliar> dependentes)
        {
            ValidarDados(responsavel, conjuge);
            Responsavel = responsavel;
            Conjuge = conjuge;
            Dependentes = dependentes;
            Pontuacao = 0;
            _rendaTotal = DefinirRendaTotal(responsavel.Renda, conjuge.Renda);
        }

        public decimal ObterRendaTotal() => _rendaTotal;

        public void AcrescentarPontuacao(int pontuacao)
        {
            if(pontuacao < 0)
            {
                throw new ArgumentException("A familia nao pode acrescentar uma pontuacao negativa.");
            }
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
