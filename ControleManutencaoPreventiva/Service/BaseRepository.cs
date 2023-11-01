using ControleManutencaoPreventiva.Context;
using ControleManutencaoPreventiva.Service.Interface;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;

namespace ControleManutencaoPreventiva.Service
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PrevContext _conn;

        public BaseRepository(PrevContext conn)
        {
            _conn = conn;
        }
        public virtual List<T> PegarTodos()
        {
            try
            {
                var list = _conn.Set<T>().ToList();
                return list;
            }
            catch (Exception ex)
            {
                return new List<T>();
            }
        }
        public virtual T PegarPorId(int id)
        {
            try
            {
                var pegaPorId = _conn.Set<T>().Find(id);
                return pegaPorId;
            }catch(Exception ex)
            {
                throw;
            }
        }


        public bool Create(T entity)
        {
            try
            {
                var newEntity = _conn.Entry<T>(entity).State = EntityState.Added;
                _conn.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Deletar(T entity)
        {
            try
            {
                var deleteEntity = _conn.Entry<T>(entity).State = EntityState.Deleted;
                _conn.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }


        public bool Update(T entity)
        {
            try
            {
                var deleteEntity = _conn.Entry<T>(entity).State = EntityState.Modified;
                _conn.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
