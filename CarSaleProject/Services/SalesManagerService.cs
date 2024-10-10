using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
namespace SalesManagerSaleProject.Services
{
    public class SalesManagerService : ISalesManagerService
    {
        ISalesManagerRepository _repository;

        public SalesManagerService(ISalesManagerRepository repository)
        {
            _repository = repository;
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
