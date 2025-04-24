using System.Text.Json.Serialization;

namespace RelacionamentoApi.Models
{
    public class Morador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [JsonIgnore]
        public List<Casa> Casas { get; set; }

    }
}
