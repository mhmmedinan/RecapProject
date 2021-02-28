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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXFormUI
{
    public partial class UserOperations : DevExpress.XtraEditors.XtraForm
    {
        IUserService _userService;
        SHA1 sha = new SHA1CryptoServiceProvider();
       

        public UserOperations()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        

        private void UserOperations_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var result = _userService.GetAll();
            dgwUser.DataSource = result.Data;
        }
       
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Kötü kod yazdığımın farkındayım sadece deneme amaçlı.
            string sifrelenecekveri = tbxPassword.Text;
            string sifrelenmisveri = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(sifrelenecekveri)));
            try
            {
                var result = _userService.Add(new User
                {
                    UserName=tbxUser.Text,
                    FirstName = tbxName.Text,
                    LastName = tbxLastName.Text,
                    Email = tbxEmail.Text,
                    Password=sifrelenmisveri

                });
                MessageBox.Show(result.Message,"Bilgilendirme");
                LoadUsers();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message,"Bilgilendirme");
            }
        }

        private void dgwUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwUser.CurrentRow;
            tbxUser.Text = row.Cells[1].Value.ToString();
            tbxName.Text = row.Cells[2].Value.ToString();
            tbxLastName.Text= row.Cells[3].Value.ToString();
            tbxEmail.Text= row.Cells[4].Value.ToString();
            tbxPassword.Text= row.Cells[5].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Kötü kod yazdığımın farkındayım sadece deneme amaçlı.
            string sifrelenecekveri = tbxPassword.Text;
            string sifrelenmisveri = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(sifrelenecekveri)));
            try
            {
                var result = _userService.Update(new User
                {
                    Id = Convert.ToInt32(dgwUser.CurrentRow.Cells[0].Value),
                    UserName=tbxUser.Text,
                    FirstName=tbxName.Text,
                    LastName=tbxLastName.Text,
                    Email=tbxEmail.Text,
                    Password=sifrelenmisveri
                });
                MessageBox.Show(result.Message, "Bilgilendirme");
                LoadUsers();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Bilgilendirme");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgwUser.CurrentRow != null)
            {
                try
                {
                    var result = _userService.Delete(new User
                    {
                        Id = Convert.ToInt32(dgwUser.CurrentRow.Cells[0].Value)

                    });
                    MessageBox.Show(result.Message, "Bilgilendirme Penceresi");
                    LoadUsers();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Bilgilendirme Penceresi");
                }

            }
        }
    }
}