using Microsoft.EntityFrameworkCore;
using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.DAO
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Familia> Familias { get; set; }
        public DbSet<ResponsavelFamiliar> Responsaveis {get; set;}
        public DbSet<ConjugeFamiliar> Conjuges { get; set; }
        public DbSet<DependenteFamiliar> Dependentes { get; set; }
    }
}
