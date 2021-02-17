using Business.Abstract;
using Business.DependencyResolvers.Ninject;
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
    public partial class CarDetails : DevExpress.XtraEditors.XtraForm
    {
        public CarDetails()
        {
            InitializeComponent();
            _carservice = InstanceFactory.GetInstance<ICarService>();
        }
        private ICarService _carservice;
        private void CarDetails_Load(object sender, EventArgs e)
        {
            var result = _carservice.GetCarDetails();
            dgwCarDetails.DataSource = result.Data;
        }
    }
}