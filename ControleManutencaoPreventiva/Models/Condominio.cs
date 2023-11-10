using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleManutencaoPreventiva.Models
{
    public class Condominio
    {
        public Condominio()
        {
            Endereco = new Endereco();
            Equipamentos = new List<Equipamento>();
        }
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        
        public int? EnderecoId {  get; set; }

        public Endereco? Endereco { get; set; }

        
        public List<Equipamento>? Equipamentos { get; set; }
    }
}
