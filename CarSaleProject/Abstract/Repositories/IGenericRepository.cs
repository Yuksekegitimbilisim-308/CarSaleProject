using CarSaleProject.Entities;

namespace CarSaleProject.Abstract.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
