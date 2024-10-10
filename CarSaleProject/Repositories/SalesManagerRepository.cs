using CarSaleProject.Abstract.Repositories;
using CarSaleProject.Entities;

namespace CarSaleProject.Repositories
{
    public class SalesManagerRepository : GenericRepository<SalesManager>, ISalesManagerRepository
    {
        public SalesManagerRepository(CarSalesDbContext context) : base(context)
        {
        }
    }
}
