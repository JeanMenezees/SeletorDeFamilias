using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeletorDeFamilias.Servicos
{
    interface ICriterio
    {
        public void Avaliar(Familia familia);
    }
}
