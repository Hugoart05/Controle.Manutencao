using ControleManutencaoPreventiva.Models;

namespace ControleManutencaoPreventiva.Service.Interface
{
    public interface IEquipamento : IBaseRepository<Equipamento>
    {
        List<Equipamento> EquipamentosCondominio(int id);
    }
}
