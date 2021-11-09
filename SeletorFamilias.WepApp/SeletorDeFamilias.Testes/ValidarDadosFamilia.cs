using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class ValidarDadosFamilia
    {
        [Fact]
        public void DeveLancarExcecaoDeArgumentoDadoUmResponsavelNulo()
        {
            const string mensagemEsperada = "A familia deve ter pelo menos um responsavel.";
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();

            void Acao() => new Familia(null, conjuge, dependentes);

            var mensagemObtida = Assert.Throws<ArgumentException>(Acao).Message;
            Assert.Equal(mensagemEsperada, mensagemObtida);
        }

        [Fact]
        public void DeveLancarExcecaoDeArgumentoDadoUmConjugeNulo()
        {
            const string mensagemEsperada = "A familia deve ter pelo menos um conjuge.";
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var dependentes = new List<DependenteFamiliar>();

            void Acao() => new Familia(responsavel, null, dependentes);

            var mensagemObtida = Assert.Throws<ArgumentException>(Acao).Message;
            Assert.Equal(mensagemEsperada, mensagemObtida);
        }
    }
}
