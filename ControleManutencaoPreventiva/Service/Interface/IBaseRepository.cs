using NPOI.SS.Formula.Functions;

namespace ControleManutencaoPreventiva.Service.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> PegarTodos();
        T PegarPorId(int id);
        bool Deletar(T entity);
        bool Update(T entity);
        bool Create(T entity);

    }
}
