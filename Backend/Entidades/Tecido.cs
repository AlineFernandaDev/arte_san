using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entidades
{
    public class Tecido
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Peso { get; set; }
        public string Cor { get; set; }
        public string Composicao { get; set; }
        public double Metragem { get; set; }
        public bool Status { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}