using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeletorFamilias.WepApp.DTOs
{
    public class FamiliaDTO
    {
        public string NomeResponsavel { get; set; }
        public string CPFResponsavel { get; set; }
        public string NomeConjuge { get; set; }
        public string CPFConjuge { get; set; }

        public FamiliaDTO(Familia familia)
        {
            NomeResponsavel = familia.Responsavel.Nome;
            NomeConjuge = familia.Conjuge.Nome;
            CPFResponsavel = familia.Responsavel.Cpf;
            CPFConjuge = familia.Conjuge.Cpf;
        }
    }
}
