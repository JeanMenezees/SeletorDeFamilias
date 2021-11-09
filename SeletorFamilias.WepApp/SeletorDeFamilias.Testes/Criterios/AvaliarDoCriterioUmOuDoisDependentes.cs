﻿using SeletorDeFamilias.Servicos;
using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class AvaliarDoCriterioUmOuDoisDependentes
    {
        [Fact]
        public void DeveAdicionar2PontosAFamiliaQueOAtende()
        {
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dependentes = new List<DependenteFamiliar>() { new DependenteFamiliar("Jose", "00000000002"),
                                                                    new DependenteFamiliar("Joaquina", "00000000003") };
            var familia = new Familia(responsavel, conjuge, dependentes);
            var criterio = new CriterioUmOuDoisDependentes();

            criterio.Avaliar(familia);

            Assert.Equal(2, familia.Pontuacao);
        }
    }
}
