using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
    public class Aviamento
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Cor { get; set; }
        public double Quantidade { get; set; }
        public double Peso { get; set; }
        public double Metragem { get; set; }
        public double Unidade { get; set; }
        public bool Status { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}