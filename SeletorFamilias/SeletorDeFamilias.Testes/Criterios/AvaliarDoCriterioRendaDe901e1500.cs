using SeletorDeFamilias.Servicos;
using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class AvaliarDoCriterioRendaDe901e1500
    {
        [Fact]
        public void DeveAdicionar3PontosDadoUmaFamiliaQueOAtende()
        {
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>();
            var familia = new Familia(responsavel, conjuge, dependentes);
            var criterio = new CriterioRendaEntre901e1500();

            criterio.Avaliar(familia);

            Assert.Equal(3, familia.Pontuacao);
        }
    }
}
