using CarSaleProject;
using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
using CarSaleProject.Repositories;
namespace SalesManagerSaleProject.Services
{
    public class SalesManagerService : ISalesManagerService
    {
        ISalesManagerRepository _repository;
        CarSalesDbContext _context;

        public SalesManagerService()
        {
            _context = new CarSalesDbContext();
            _repository = new SalesManagerRepository(_context);
        }
        public void Add(SalesManager entity)
        {
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public SalesManager Get(int id)
        {
            return _repository.Get(id);
        }

        public List<SalesManager> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(SalesManager entity)
        {
            _repository.Update(entity);
        }
    }
}
