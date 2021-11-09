using SeletorFamilias.WepApp.Models;
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
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();

            var familia = new Familia(responsavel, conjuge, dependentes);

            Assert.Equal(quantidadeEsperada, familia.Dependentes.Count);
        }

        [Fact]
        public void DeveConstruirUmaFamiliaComPontuacaoZerada()
        {
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();

            var familia = new Familia(responsavel, conjuge, dependentes);

            Assert.Equal(0, familia.Pontuacao);
        }

        [Fact]
        public void DeveConstruirUmaFamiliaComRenda()
        {
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();
            var rendaEsperada = 1000;

            var familia = new Familia(responsavel, conjuge, dependentes);

            Assert.Equal(rendaEsperada, familia.RendaTotal);
        }
    }
}
