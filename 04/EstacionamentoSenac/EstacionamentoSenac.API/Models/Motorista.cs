using EstacionamentoSenac.API.Models;
using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace EstacionamentoSenac.API.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? VeiculoId { get; set; } // chave estrangeira

        [JsonIgnore]
        public Veiculo? Veiculo { get; set; } // propriedade de navegação

    }
}
