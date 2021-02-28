using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXFormUI
{
    public partial class ColorOperations : DevExpress.XtraEditors.XtraForm
    {
        

        public ColorOperations()
        {
            InitializeComponent();
            _colorService = InstanceFactory.GetInstance<IColorService>();
        }
        IColorService _colorService;
       
        private void colorAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _colorService.Add(new Color { ColorName=tbxColorName.Text});
                if (result.Success==true)
                {
                    MessageBox.Show(result.Message,"Bilgilendirme Penceresi");
                }
                else
                {
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                }
                LoadColor();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }

        private void ColorOperations_Load(object sender, EventArgs e)
        {
            LoadColor();
        }

        private void LoadColor()
        {
            var result = _colorService.GetAll();
            dgwColor.DataSource = result.Data;
        }

        private void colorUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _colorService.Update(new Color { Id = Convert.ToInt32(dgwColor.CurrentRow.Cells[0].Value),
                    ColorName=tbxColorName.Text.ToString() });
               
                MessageBox.Show(result.Message,"Bilgilendirme Penceresi");
                LoadColor();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
            }
        }

        private void colorDeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgwColor.CurrentRow != null)
            {
                try
                {
                    var result = _colorService.Delete(new Color
                    {
                        Id = Convert.ToInt32(dgwColor.CurrentRow.Cells[0].Value)
                    });

                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadColor();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Hata!");
                }
            }
        }

        private void dgwColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwColor.CurrentRow;
            tbxColorName.Text = row.Cells[1].Value.ToString();
        }
    }
}