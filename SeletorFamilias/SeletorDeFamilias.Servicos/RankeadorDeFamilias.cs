using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeletorDeFamilias.Servicos
{
    public class RankeadorDeFamilias
    {
        public List<Familia> Rankear(List<Familia> familias) => familias.OrderBy(familia => familia.Pontuacao).ToList();
    }
}
