using CarSaleProject.Abstract.Services;
using CarSaleProject.Entities;
using CarSaleProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSaleProject
{
    public partial class CarManagement : Form
    {
        IBrandService _brandService;
        ICarService _carService;
        public CarManagement()
        {
            _brandService = new BrandService();
            _carService = new CarService(new CarSalesDbContext());
            InitializeComponent();
        }

        private void CarManagement_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _brandService.GetAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            dataGridView1.DataSource = _carService.GetAll();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new()
            {
                Model = txtModel.Text,
                Color = txtColor.Text,
                CaseType = txtCaseType.Text,
                FuelType = txtFuelType.Text,
                BrandId = (int)comboBox1.SelectedValue
            };
            _carService.Add(car);
            dataGridView1.DataSource = _carService.GetAll();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            Car car = (Car)row.DataBoundItem;

            txtModel.Text = car.Model;
            txtColor.Text = car.Color;
            txtCaseType.Text = car.CaseType;
            txtFuelType.Text = car.FuelType;
            comboBox1.SelectedValue = car.BrandId;
            txtId.Text = car.Id.ToString();
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            Car car = new()
            {
                Id = int.Parse(txtId.Text),
                Model = txtModel.Text,
                Color = txtColor.Text,
                CaseType = txtCaseType.Text,
                FuelType = txtFuelType.Text,
                BrandId = (int)comboBox1.SelectedValue
            };
            _carService.Update(car);
            dataGridView1.DataSource = _carService.GetAll();

        }
    }
}
