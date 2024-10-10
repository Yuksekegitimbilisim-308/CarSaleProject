using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleProject.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(CarSalesDbContext context) : base(context)
        {
        }
    }
}
