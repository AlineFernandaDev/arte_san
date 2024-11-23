using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
  public class Cliente
    {
        public string Codigo { get; set; } = "empty";
        public string Nome { get; set; } = "empty";
        public string Cpf { get; set; } = "empty";
        public string Telefone { get; set; } = "empty";
        public string Email { get; set; } = "empty";
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }

        public Endereco Endereco { get; set; }
        public Medida Medida { get; set; }

    }
}