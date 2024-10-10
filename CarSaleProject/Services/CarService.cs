using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleProject.Services
{
    public class CarService : ICarService
    {
        ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
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
