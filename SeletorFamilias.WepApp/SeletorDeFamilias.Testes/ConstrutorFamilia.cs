using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class ConstrutorFamilia
    {
        [Fact]
        public void DeveConstruirUmaFamiliaComZeroDependentes()
        {
            var quantidadeEsperada = 0;
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000");
            var conjuge = new ConjugeFamiliar("Maria", "00000000001");
            var dependentes = new List<DependenteFamiliar>();

            var familia = new Familia(responsavel, conjuge, dependentes);

            Assert.Equal(quantidadeEsperada, familia.Dependentes.Count);
        }
    }
}
