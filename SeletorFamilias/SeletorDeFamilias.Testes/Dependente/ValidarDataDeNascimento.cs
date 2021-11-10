using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeletorDeFamilias.Testes.Dependente
{
    public class ValidarDataDeNascimento
    {
        [Fact]
        public void DeveLancarExcecaoDadoUmaIdadeMenorQue18anos()
        {
            var dataNascimento = new DateTime(2007, 05, 12);
            var nome = "Joao";
            var cpf = "00000000001";
            var mensagemEsperada = "O dependente deve ter idade maior ou igual a 18 anos.";

            void Acao() => new DependenteFamiliar(nome, cpf, dataNascimento);

            var mensagemObtida = Assert.Throws<ArgumentException>(Acao).Message;
            Assert.Equal(mensagemEsperada, mensagemObtida);
        }
    }
}
