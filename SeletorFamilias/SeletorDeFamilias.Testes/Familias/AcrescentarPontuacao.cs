using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeletorDeFamilias.Testes.Familias
{
    public class AcrescentarPontuacao
    {
        [Fact]
        public void DeveLancarArgumentExceptionDadoUmaPontuacaoNegativa()
        {
            const int pontuacaoNegativa = -1;
            const string mensagemEsperada = "A familia nao pode acrescentar uma pontuacao negativa.";
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();
            var familia = new Familia(responsavel, conjuge, dependentes);

            void Acao() => familia.AcrescentarPontuacao(pontuacaoNegativa);

            var mensagemObtida = Assert.Throws<ArgumentException>(Acao).Message;
            Assert.Equal(mensagemEsperada, mensagemObtida);
        }
    }
}
