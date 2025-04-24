using System.ComponentModel.DataAnnotations;

namespace RelacionamentoApi.Models
{
    public class Endereco
    {
        [Key] //Chave primária
        public int Id { get; set; }

        public string Rua { get; set; }

        public int CasaId { get; set; }
    }
}
