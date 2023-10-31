namespace ControleManutencaoPreventiva.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public int CondominioId {  get; set; }
        public Condominio Condominio { get; set; }
    }
}