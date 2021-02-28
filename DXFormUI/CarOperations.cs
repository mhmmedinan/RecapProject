using Business.Abstract;
using Business.DependencyResolvers.Autofac;
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
    public partial class CarOperations : DevExpress.XtraEditors.XtraForm
    {

        public CarOperations()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetInstance<ICarService>();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
            _colorService = InstanceFactory.GetInstance<IColorService>();
        }


        ICarService _carService;
        IBrandService _brandService;
        IColorService _colorService;


        private void CarOperations_Load(object sender, EventArgs e)
        {
            LoadBrands();
            LoadColors();
            LoadCars();

        }

        private void LoadCars()
        {
            var result = _carService.GetAll();
            dgwCar.DataSource = result.Data;
        }

        private void LoadColors()
        {
            var result = _colorService.GetAll();
            cbxColorId.DataSource = result.Data;
            cbxColorId.DisplayMember = "ColorName";
            cbxColorId.ValueMember = "Id";
        }

        private void LoadBrands()
        {
            var result = _brandService.GetAll();
            cbxBrandId.DataSource = result.Data;
            cbxBrandId.DisplayMember = "BrandName";
            cbxBrandId.ValueMember = "Id";

            cbxBrandName.DataSource = result.Data;
            cbxBrandName.DisplayMember = "BrandName";
            cbxBrandName.ValueMember = "Id";
        }

        private void carAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _carService.Add(new Car
                {
                    BrandId = Convert.ToInt32(cbxBrandId.SelectedValue),
                    ColorId = Convert.ToInt32(cbxColorId.SelectedValue),
                    ModelYear = Convert.ToInt32(tbxModelYear.Text),
                    DailyPrice = Convert.ToDecimal(tbxPrice.Text),
                    Description = tbxDescription.Text
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }

        private void dgwCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCar.CurrentRow;
            cbxBrandId.SelectedValue = row.Cells[1].Value.ToString();
            cbxColorId.SelectedValue = row.Cells[2].Value.ToString();
            tbxModelYear.Text = row.Cells[3].Value.ToString();
            tbxPrice.Text = row.Cells[4].Value.ToString();
            tbxDescription.Text = row.Cells[5].Value.ToString();
        }

        private void carUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _carService.Update(new Car
                {
                    Id = Convert.ToInt32(dgwCar.CurrentRow.Cells[0].Value),
                    BrandId = Convert.ToInt32(cbxBrandId.SelectedValue),
                    ColorId = Convert.ToInt32(cbxColorId.SelectedValue),
                    ModelYear = Convert.ToInt32(tbxModelYear.Text),
                    DailyPrice = Convert.ToDecimal(tbxPrice.Text),
                    Description = tbxDescription.Text
                });
                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }

        private void carDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgwCar.CurrentRow != null)
            {
                try
                {
                    var result = _carService.Delete(new Car
                    {
                        Id = Convert.ToInt32(dgwCar.CurrentRow.Cells[0].Value)

                    });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadCars();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
                }

            }
        }

        private void cbxBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var result = _carService.GetCarByBrand(Convert.ToInt32(cbxBrandName.SelectedValue));
                dgwCar.DataSource = result.Data;
            }
            catch
            {


            }
        }
    }
}