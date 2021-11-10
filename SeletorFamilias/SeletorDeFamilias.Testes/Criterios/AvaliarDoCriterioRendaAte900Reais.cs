using SeletorFamilias.WepApp.Models;
using SeletorDeFamilias.Servicos;
using System.Collections.Generic;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class AvaliarDoCriterioRendaAte900Reais
    {
        [Fact]
        public void DeveAdicionar5PontosDadoUmaFamiliaQueOAtende()
        {
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 300);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();
            var familia = new Familia(responsavel, conjuge, dependentes);
            var criterio = new CriterioRendaAte900Reais();

            criterio.Avaliar(familia);

            Assert.Equal(5, familia.Pontuacao);
        }
    }
}
