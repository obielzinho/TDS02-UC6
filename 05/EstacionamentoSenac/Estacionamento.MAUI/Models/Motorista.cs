namespace Estacionamento.MAUI.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
         public string? Cpf { get; set; }  
        public string? Telefone { get; set; }

        // [JsonIgnore] 
        public Veiculo? Veiculo { get; set; }
    }
}
