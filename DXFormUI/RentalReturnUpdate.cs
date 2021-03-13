using Business.Abstract;
using Business.Constans;
using Business.DependencyResolvers.Autofac;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class RentalReturnUpdate : DevExpress.XtraEditors.XtraForm
    {
        public RentalReturnUpdate()
        {
            InitializeComponent();
            _rentalService = InstanceFactory.GetInstance<IRentalService>();
            _carService = InstanceFactory.GetInstance<ICarService>();
          
        }

        IRentalService _rentalService;
        ICarService _carService;
        private void RentalReturnUpdate_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
            var result = _rentalService.GetRentalDetail();
            dgwRentalReturn.DataSource = result.Data;
            tbxReturnDate.Text= string.Format("{0:dd.MM.yyyy HH:mm}", DateTime.Now);
        }

        private void returnBtnUpdate_Click(object sender, EventArgs e)
        {
           
            if (_rentalService.GetRentalDetail() != null)
            {
                var result = _rentalService.UpdateReturnDate(new Rental { CarId=Convert.ToInt32(dgwRentalReturn.CurrentRow.Cells[0].Value)});
                if (result.Success)
                {
                    MessageBox.Show(result.Message,"Bilgilendirme Penceresi");
                    LoadRentals();
                }
                else
                {
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                }
            }
        }

        private void dgwRentalReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwRentalReturn.CurrentRow;
            tbxCarId2.Text = row.Cells[1].Value.ToString();
            tbxUserName.Text = row.Cells[3].Value.ToString();
            tbxCmpnyName.Text= row.Cells[5].Value.ToString();
            tbxRentDate.Text= row.Cells[6].Value.ToString();

        }
    }
}