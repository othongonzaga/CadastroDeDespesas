using System.ComponentModel.DataAnnotations;

namespace ControleDeDespesas.DTOs
{
    public class CreateDespesaDTO
    {
        [Required(ErrorMessage = "Descrição é obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório.")]
        [Range(0.01,999999999999, ErrorMessage ="Valor deve ser maior que 0.")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Data é obrigatório.")]
        public DateTime Data { get; set; }
    }
}
