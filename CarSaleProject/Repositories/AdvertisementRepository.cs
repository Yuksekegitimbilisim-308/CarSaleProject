using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Entities;
using CarSaleProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleProject.Repositories
{
    public class AdvertisementRepository : GenericRepository<Advertisement>, IAdvertisementRepository
    {
        CarSalesDbContext _context;
        public AdvertisementRepository(CarSalesDbContext context) : base(context)
        {
            _context = context;
        }
        public List<AdvertisementListModel> GetAllBrandWithSalesManagerAndCar()
        {
            var query = _context.Advertisements
                .Include(x => x.SalesManager)
                .Include(x => x.Car)
                .ThenInclude(x => x.Brand)
                .Select(x => new AdvertisementListModel



                {
                    Id = x.Id,
                    Status = x.Status,
                    BrandName = x.Car.Brand.Name,
                    Model  =x.Car.Model,
                    Color = x.Car.Color,
                    Price = x.Price,
                    CreatedDate = x.CreatedDate,
                    Kilometers = x.Kilometers,
                    SalesManagerName = x.SalesManager.FullName
                }).ToList();
            return query;
        }
    }
}
