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
    public partial class BrandOperations : DevExpress.XtraEditors.XtraForm
    {
        public BrandOperations()
        {
            InitializeComponent();
            _brandService = InstanceFactory.GetInstance<IBrandService>();
        }
        private IBrandService _brandService;
        private void BrandOperations_Load(object sender, EventArgs e)
        {
            LoadBrand();
        }

        private void LoadBrand()
        {
            var result = _brandService.GetAll();
            dgwBrand.DataSource = result.Data;
        }

        private void brandAddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var result = _brandService.Add(new Brand
                {
                    BrandName = tbxBrandName.Text
                });
                if (result.Success == true)
                {
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                }
                else
                {
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                }

                LoadBrand();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
            
           


        }

        private void brandUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _brandService.Update(new Brand
                {
                    Id = Convert.ToInt32(dgwBrand.CurrentRow.Cells[0].Value),
                    BrandName = tbxBrandName.Text.ToString()
                });

                MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                LoadBrand();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
            
        }

        private void dgwBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwBrand.CurrentRow;
            tbxBrandName.Text = row.Cells[1].Value.ToString();
        }

        private void brandDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgwBrand.CurrentRow != null)
            {
                try
                {
                    var result = _brandService.Delete(new Brand
                    {
                        Id = Convert.ToInt32(dgwBrand.CurrentRow.Cells[0].Value)
                    });

                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadBrand();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Hata!");
                }
            }
        }
    }
}