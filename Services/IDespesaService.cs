using ControleDeDespesas.Models.Despesas;

namespace ControleDeDespesas.Services
{
    public interface IDespesaService
    {
        Task Create(DTOs.CreateDespesaDTO createDespesaDTO);
        Task<List<Despesa>> FindBy(DateTime dataInicial, DateTime dataFinal);
    }
}
