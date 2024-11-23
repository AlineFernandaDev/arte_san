using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
    public class Produto
    {
        public string Codigo { get; set; } = "empty";
        public string Descricao { get; set; } = "empty";
        public string CodigoBarras { get; set; } = "empty";
        public string Quantidade { get; set; } = "empty";
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; } 
        public bool Status { get; set; }

        public Tecido Tecido { get; set; }
        public Aviamento Aviamento { get; set; }
        public Fornecedore fornecedore { get; set; }
    }
}