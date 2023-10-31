using System.ComponentModel.DataAnnotations;

namespace ControleManutencaoPreventiva.Models
{
    public class Condominio
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public int EnderecoId {  get; set; }
        public Endereco Endereco { get; set; }

        public List<Equipamento> Equipamentos { get; set; }
    }
}
