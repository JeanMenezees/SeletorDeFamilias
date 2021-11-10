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
        public DateTime DataDeNascimento { get; set; }
        public DependenteFamiliar(string nome, string cpf, DateTime dataDeNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            ValidarDataNascimento(dataDeNascimento);
        }

        private void ValidarDataNascimento(DateTime dataNascimento)
        {
            if (dataNascimento.Year > DateTime.Now.Year - 18)
            {
                throw new ArgumentException("O dependente deve ter idade maior ou igual a 18 anos.");
            }

            DataDeNascimento = dataNascimento;
        }
    }
}
