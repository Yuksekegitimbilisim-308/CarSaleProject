using CarSaleProject.Abstract.Services;
using CarSaleProject.Repositories;
using CarSaleProject.Services;

namespace CarSaleProject
{
    public partial class Form1 : Form
    {

        IBrandService _brandService;
        public Form1()
        {
            InitializeComponent();
            _brandService = new BrandService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
