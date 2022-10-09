using ControleDeDespesas.Infra.Database;
using ControleDeDespesas.Models.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Services
{
    public class DespesaService
    {
        private readonly DespesaControlContext _dbContext;
        public DespesaService(DespesaControlContext context)
        {
            _dbContext= context;
        }

        public async Task Create(DTOs.CreateDespesaDTO createDespesaDTO)
        {
            await _dbContext.Despesas.AddAsync(new Despesa()
            {
                Descricao = createDespesaDTO.Descricao,
                Data = createDespesaDTO.Data,
                Valor = createDespesaDTO.Valor
            });

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Despesa>> FindBy(DateTime dataInicial, DateTime dataFinal)
        {
            var items = await _dbContext.Despesas.Where(e => e.Data >= dataInicial && e.Data <= dataFinal).AsNoTracking().ToListAsync();

            return items;
        }
    }
}
