using AdvertisementSaleProject.Services;
using CarSaleProject.Abstract.Services;
using CarSaleProject.Repositories;
using CarSaleProject.Services;

namespace CarSaleProject
{
    public partial class Form1 : Form
    {

        IBrandService _brandService;
        IAdvertisementService _advertisementService;
        public Form1()
        {
            InitializeComponent();
            _brandService = new BrandService();
            _advertisementService = new AdvertisementService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _advertisementService.GetAllBrandWithSalesManagerAndCar();
        }
    }
}
