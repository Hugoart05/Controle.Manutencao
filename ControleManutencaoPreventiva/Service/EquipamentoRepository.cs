using ControleManutencaoPreventiva.Context;
using ControleManutencaoPreventiva.Models;
using ControleManutencaoPreventiva.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace ControleManutencaoPreventiva.Service
{
    public class EquipamentoRepository : BaseRepository<Equipamento>, IEquipamento
    {
        public EquipamentoRepository(PrevContext conn) : base(conn)
        {
        }
    }
}
