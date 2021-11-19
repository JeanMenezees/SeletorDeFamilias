using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.DAO
{
    public class MigradorDoBanco : IMigradorDoBanco
    {
        private readonly Contexto _contexto;

        public MigradorDoBanco(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Migrar()
        {
            _contexto.Database.Migrate();
        }
    }
}
