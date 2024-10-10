using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
using CarSaleProject.Repositories;

namespace CarSaleProject.Services
{
    public class BrandService : IBrandService
    {
        IBrandRepository _repository;
        CarSalesDbContext _context;
        public BrandService()
        {
            _context = new CarSalesDbContext();
            _repository = new BrandRepository(_context);
        }

        public void Add(Brand entity)
        {
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Brand Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Brand> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Brand entity)
        {
            _repository.Update(entity);
        }
    }
}
