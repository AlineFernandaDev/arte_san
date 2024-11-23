using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
    public class Fornecedor
    {
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

        public Endereco Enderecos { get; set; }
        
    }
}