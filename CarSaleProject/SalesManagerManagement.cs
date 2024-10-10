using CarSaleProject.Abstract.Services;
using SalesManagerSaleProject.Services;
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
    public partial class SalesManagerManagement : Form
    {
        ISalesManagerService _salesManagerservice;
        public SalesManagerManagement()
        {
            _salesManagerservice = new SalesManagerService();
            InitializeComponent();
        }

        private void SalesManagerManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _salesManagerservice.GetAll();
        }
    }
}
