using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.DAO
{
    public class FamiliaDAO : IFamiliaDAO
    {
        private readonly Contexto _contexto;

        public FamiliaDAO(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void AdicionarFamilia(Familia familia)
        {
            _contexto.Familias.Add(familia);
        }

        public List<Familia> ObterFamilias()
        {
            return _contexto.Familias.ToList();
        }
    }
}
