using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RelacionamentoApi.Models
{
    public class Casa
    {
        [Key] //Chave primária.
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Endereco Endereco { get; set; }

        public List<Quarto> Quartos { get; set; }

        [JsonIgnore]
        public List<Morador> Moradores { get; set; }



    }
}
