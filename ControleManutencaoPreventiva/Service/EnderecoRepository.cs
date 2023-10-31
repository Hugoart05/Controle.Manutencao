using ControleManutencaoPreventiva.Context;
using ControleManutencaoPreventiva.Models;
using ControleManutencaoPreventiva.Service.Interface;

namespace ControleManutencaoPreventiva.Service
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEndereco
    {
        public EnderecoRepository(PrevContext conn) : base(conn)
        {
        }
    }
}
