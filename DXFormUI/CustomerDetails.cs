using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using DevExpress.XtraEditors;
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
    public partial class CustomerDetails : DevExpress.XtraEditors.XtraForm
    {
        
        public CustomerDetails()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        ICustomerService _customerService;
       

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            var result = _customerService.GetCustomerDetails();
            dgwCustomerDetails.DataSource = result.Data;
        }
    }
}