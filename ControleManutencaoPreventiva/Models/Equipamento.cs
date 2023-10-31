namespace ControleManutencaoPreventiva.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public List<RangeIps> Ips { get; set; }


        public int CondominioId { get; set; }
        public Condominio Condominio { get; set; }

    }
}