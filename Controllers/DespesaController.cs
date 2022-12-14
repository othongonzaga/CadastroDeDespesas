using ControleDeDespesas.DTOs;
using ControleDeDespesas.Models;
using ControleDeDespesas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControleDeDespesas.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ILogger<DespesaController> _logger;
        private readonly IDespesaService _despesaService;

        public DespesaController(ILogger<DespesaController> logger, IDespesaService despesaService)
        {
            _logger = logger;
            _despesaService = despesaService;
        }

        public async Task<IActionResult> Index()
        {
            var listDespesaDto = new ListDespesaDTO();
            listDespesaDto.Items = await _despesaService.FindBy(listDespesaDto.DataInicial, listDespesaDto.DataFinal);

            return View(listDespesaDto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}