using ControleDeDespesas.Models.Despesas;
using System;

namespace ControleDeDespesas.DTOs
{
    public class ListDespesaDTO
    {
        public ListDespesaDTO()
        {
            DataInicial = DateTime.UtcNow.AddDays(-5);
            DataFinal = DateTime.UtcNow.AddDays(3);
            Items = new List<Despesa>();
        }

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public List<Despesa> Items { get; set; }
    }
}
