using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
        public string DataAdmissao { get; set; }
        public string DataDemissao { get; set; }
        public bool Status { get; set; }
        
        public Endereco Endereco { get; set; }
    }
}