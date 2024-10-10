using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
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

        public AdvertisementService(IAdvertisementRepository repository)
        {
            _repository = repository;
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

        public void Update(Advertisement entity)
        {
            _repository.Update(entity);
        }
    }
}
