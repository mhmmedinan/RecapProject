using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using DevExpress.XtraEditors;
using Core.Entities.Concrete;
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
    public partial class CustomerOperations : DevExpress.XtraEditors.XtraForm
    {
       


        public CustomerOperations()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        IUserService _userService;
        ICustomerService _customerService;
        private void CustomerOperations_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var result = _userService.GetAll();
            cbxUserId.DataSource = result;
            cbxUserId.DisplayMember = "FirstName" + "LastName";
            cbxUserId.ValueMember = "Id";
        }

        private void LoadCustomers()
        {
            var result = _customerService.GetAll();
            dgwCustomer.DataSource = result.Data;
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _customerService.Add(new Customer
                {

                    UserId = Convert.ToInt32(cbxUserId.SelectedValue),
                    CompanyName = tbxCompanyName.Text

                });
                MessageBox.Show(result.Message, "Bilgilendirme");
                LoadCustomers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme");
            }
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _customerService.Update(new Customer
                {
                    Id = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value),
                    UserId = Convert.ToInt32(cbxUserId.SelectedValue),
                    CompanyName = tbxCompanyName.Text
                });
                MessageBox.Show(result.Message, "Bilgilendirme");
                LoadCustomers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme");
            }
        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCustomer.CurrentRow;
            cbxUserId.SelectedValue = row.Cells[1].Value.ToString();
            tbxCompanyName.Text = row.Cells[2].Value.ToString();

        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgwCustomer.CurrentRow != null)
            {
                try
                {
                    var result = _customerService.Delete(new Customer
                    {
                        Id = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value)

                    });
                    MessageBox.Show(result.Message, "Bilgilendirme ");
                    LoadCustomers();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Bilgilendirme ");
                }

            }
        }
    }
}