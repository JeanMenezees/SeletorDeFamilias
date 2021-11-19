using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.Models
{
    public class ResponsavelFamiliar
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Renda { get; set; }

        private ResponsavelFamiliar()
        {

        }

        public ResponsavelFamiliar(string nome, string cpf, decimal renda)
        {
            Nome = nome;
            Cpf = cpf;
            Renda = renda;
        }
    }
}
