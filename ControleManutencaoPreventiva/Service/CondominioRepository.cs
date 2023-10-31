using ControleManutencaoPreventiva.Context;
using ControleManutencaoPreventiva.Models;
using ControleManutencaoPreventiva.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace ControleManutencaoPreventiva.Service
{
    public class CondominioRepository : BaseRepository<Condominio>, ICondominio
    {
        private PrevContext _context;
        public CondominioRepository(PrevContext conn) : base(conn)
        {
            _context = conn;
        }
        public override Condominio PegarPorId(int id)
        {
            try
            {
                var condominioData = _context.Condominio
                    .Where(x => x.Id == id)
                    .Include(x => x.Endereco)
                    .Include(x => x.Equipamentos)
                    .FirstOrDefault();
                return condominioData;
            }
            catch
            {
                throw;
            }
        }
    }
}
