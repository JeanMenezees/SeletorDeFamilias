using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class DefinirRendaTotal
    {
        [Fact]
        public void DeveLancarExcecaoDadoUmaRendaTotalNegativa()
        {
            const string mensagemEsperada = "A familia deve ter uma renda total maior ou igual a zero.";
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", -600);
            var dependentes = new List<DependenteFamiliar>();

            void Acao() => new Familia(responsavel, conjuge, dependentes);

            var mensagemObtida = Assert.Throws<Exception>(Acao).Message;
            Assert.Equal(mensagemEsperada, mensagemObtida);
        }
    }
}
