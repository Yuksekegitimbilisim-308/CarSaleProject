using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
using CarSaleProject.Repositories;

namespace CarSaleProject.Services
{
    public class CarService : ICarService
    {
        ICarRepository _repository;
        //CarSalesDbContext _context;
        public CarService(CarSalesDbContext context)
        {
            //_context = new CarSalesDbContext();
            _repository = new CarRepository(context);
        }

        public void Add(Car entity)
        {
           _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Car Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Car> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Car entity)
        {
            _repository.Update(entity);
        }
    }
}
