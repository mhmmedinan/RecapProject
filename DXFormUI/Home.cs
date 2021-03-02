using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
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
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Home()
        {
           InitializeComponent();
           
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            
        }


        private void brandOperationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BrandOperations brandOperations = new BrandOperations();

           brandOperations.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void colorOperationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorOperations colorOperations = new ColorOperations();
            colorOperations.Show();
        }

        private void carOperationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarOperations carOperations = new CarOperations();
            carOperations.Show();
        }

        private void carDetailsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarDetails carDetails = new CarDetails();
            carDetails.Show();
        }

        private void userOperationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void customerOperationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomerOperations customerOperations = new CustomerOperations();
            customerOperations.Show();
        }

        private void customerDetailsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.Show();
        }

        private void rentalOperationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RentalOperations rentalOperations = new RentalOperations();
            rentalOperations.Show();
        }

        private void rentalReturnBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RentalReturnUpdate rentalReturnUpdate = new RentalReturnUpdate();
            rentalReturnUpdate.Show();
        }
    }
}