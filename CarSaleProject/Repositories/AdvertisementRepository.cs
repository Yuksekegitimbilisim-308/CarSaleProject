using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleProject.Repositories
{
    public class AdvertisementRepository : GenericRepository<Advertisement>, IAdvertisementRepository
    {
        public AdvertisementRepository(CarSalesDbContext context) : base(context)
        {
        }
    }
}
