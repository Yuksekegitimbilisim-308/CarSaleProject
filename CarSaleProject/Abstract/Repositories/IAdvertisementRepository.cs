using CarSaleProject.Entities;
using CarSaleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleProject.Abstract.Repositories
{
    public interface IAdvertisementRepository : IGenericRepository<Advertisement>
    {
        List<AdvertisementListModel> GetAllBrandWithSalesManagerAndCar();
    }
}
