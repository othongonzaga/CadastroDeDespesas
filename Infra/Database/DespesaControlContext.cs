using ControleDeDespesas.Models.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Infra.Database
{
    public class DespesaControlContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=ControleDespesa.db");
    }
}
