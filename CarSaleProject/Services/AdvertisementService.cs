using CarSaleProject;
using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
using CarSaleProject.Models;
using CarSaleProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementSaleProject.Services
{
    public class AdvertisementService : IAdvertisementService
    {
        IAdvertisementRepository _repository;
        CarSalesDbContext _context;
        public AdvertisementService()
        {
            _context = new CarSalesDbContext();
            _repository = new AdvertisementRepository(_context);
        }

        public void Add(Advertisement entity)
        {
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Advertisement Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Advertisement> GetAll()
        {
            return _repository.GetAll();
        }

        public List<AdvertisementListModel> GetAllBrandWithSalesManagerAndCar()
        {
            return _repository.GetAllBrandWithSalesManagerAndCar();
        }

        public void Update(Advertisement entity)
        {
            _repository.Update(entity);
        }
    }
}
