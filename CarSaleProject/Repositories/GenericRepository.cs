using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Entities;

namespace CarSaleProject.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        CarSalesDbContext _context;
        public GenericRepository(CarSalesDbContext context)
        {
            _context = context;
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity =  Get(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
