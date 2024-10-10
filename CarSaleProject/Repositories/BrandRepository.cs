using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Entities;

namespace CarSaleProject.Repositories
{
    public class BrandRepository : GenericRepository<Brand>,IBrandRepository
    {
        public BrandRepository(CarSalesDbContext context):base(context)
        {
            
        }
    }
}
