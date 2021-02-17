using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXFormUI
{
    public partial class RentalOperations : DevExpress.XtraEditors.XtraForm
    {
        public RentalOperations()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetInstance<ICarService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _rentalService = InstanceFactory.GetInstance<IRentalService>();

        }
        private ICarService _carService;
        private ICustomerService _customerService;
        private IRentalService _rentalService;
        private void RentalOperations_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadCustomers();
            LoadRentals();
        }

        private void LoadRentals()
        {
            var result = _rentalService.GetAll();
            dgwRental.DataSource = result.Data;
            tbxRent.Text = string.Format("{0:dd.MM.yyyy hh:mm}", DateTime.Now);
        }

        private void LoadCustomers()
        {
            var result = _customerService.GetAll();
            cbxCustomerId1.DataSource = result.Data;
            cbxCustomerId1.DisplayMember = "Id";
            cbxCustomerId1.ValueMember = "Id";
        }

        private void LoadCars()
        {
            var result = _carService.GetAll();
            cbxCarId1.DataSource = result.Data;
            cbxCarId1.DisplayMember = "Id";
            cbxCarId1.ValueMember = "Id";
        }

        private void rentAddBtn_Click(object sender, EventArgs e)
        {

            var result = _rentalService.Add(new Rental
            {
                CarId = Convert.ToInt32(cbxCarId1.SelectedValue),
                CustomerId = Convert.ToInt32(cbxCustomerId1.SelectedValue),
                RentDate = DateTime.Now,
                ReturnDate = null
            });
            if (result.Success == true)
            {
                MessageBox.Show(result.Message);
                LoadRentals();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

    
           
           
        
    }
}