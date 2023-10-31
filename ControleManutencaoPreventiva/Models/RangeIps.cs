namespace ControleManutencaoPreventiva.Models
{
    public class RangeIps
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Type { get; set; }
        public int EquipamentoId { get; set; }
        public Equipamento Equipamento { get; set; }
    }
}