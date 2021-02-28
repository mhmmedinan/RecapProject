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
    public partial class CarDetails : DevExpress.XtraEditors.XtraForm
    {
        
       

        public CarDetails()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetInstance<ICarService>();
        }
        ICarService _carService;
     
        private void CarDetails_Load(object sender, EventArgs e)
        {
            var result = _carService.GetCarDetails();
            dgwCarDetails.DataSource = result.Data;
        }
    }
}