using SeletorFamilias.WepApp.Models;
using System.Collections.Generic;

namespace SeletorFamilias.WepApp.DAO
{
    public interface IFamiliaDAO
    {
        void AdicionarFamilia(Familia familia);
        List<Familia> ObterFamilias();
    }
}