using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.Models
{
    public class DependenteFamiliar
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DependenteFamiliar(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
