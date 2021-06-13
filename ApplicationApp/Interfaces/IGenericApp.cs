using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IGenericApp<T> where T : class
    {
        Task Add(T obj);

        Task Delete(T obj);

        Task<T> GetEntityById(int id);

        Task Update(T obj);

    }
}