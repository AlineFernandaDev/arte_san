using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
    public class Venda
    {
        public string Codigo { get; set; }= "empty";
        public string CodigoCliente { get; set; } = "empty";
        public string CodigoProduto { get; set; }= "empty";
        public string Quantidade { get; set; } = "empty";
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public DateTime DataVenda { get; set; }
        public string FormaPagamento { get; set; } = "empty";
        public string Vendedor { get; set; } = "empty";
        public bool Status { get; set; }

        public Cliente Cliente { get; set; } 
        public Produto Produto { get; set; }
        public Usuario Usuario { get; set; }
    }
}