using ControleManutencaoPreventiva.Context;
using ControleManutencaoPreventiva.Models;
using ControleManutencaoPreventiva.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace ControleManutencaoPreventiva.Service
{
    public class EquipamentoRepository : BaseRepository<Equipamento>, IEquipamento
    {
        private readonly PrevContext _conn;
        public EquipamentoRepository(PrevContext conn) : base(conn)
        {
            _conn = conn;
        }

        public List<Equipamento> EquipamentosCondominio(int id)
        {
            var equipamentos = _conn.Equipamentos
                .Where(x => x.CondominioId == id)
                .Include(x => x.Ips)
                .ToList();

            return equipamentos;
        }

        
    }
}
