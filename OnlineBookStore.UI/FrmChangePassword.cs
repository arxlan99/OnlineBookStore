using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class FrmChangePassword : Form
    {
        private ICustomerService _customerService;

        public FrmChangePassword()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void chkActivePasswords_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = txtOldPassword.UseSystemPasswordChar != true;
            txtNewPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar != true;
            txtPasswordAgain.UseSystemPasswordChar = txtPasswordAgain.UseSystemPasswordChar != true;
        }

        private bool ValidateChangePassword()
        {
            if (ValidateIsNullOrEmpty(txtOldPassword, lblOldPassword) && ValidateIsNullOrEmpty(txtNewPassword, lblNewPassword) &&
                ValidateIsNullOrEmpty(txtPasswordAgain, lblPasswordAgain) && ValidateIsMatch(txtNewPassword, txtPasswordAgain))
                return true;

            return false;
        }

        #region Textbox ın boş olup olmama kontrolü
        private bool ValidateIsNullOrEmpty(TextBox textBox, Label label)
        {
            if (textBox.Text.Equals(string.Empty))
            {
                errProvider.SetError(textBox, $"{label.Text} alanı boş olamaz");
                return false;
            }
            else
            {
                errProvider.SetError(textBox, null);
                return true;
            }
        }
        #endregion

        #region Textboxların eşleşme kontrolü
        private bool ValidateIsMatch(TextBox textBox, TextBox textBox2)
        {
            if (!textBox.Text.Equals(textBox2.Text))
            {
                errProvider.SetError(textBox, "Şifreler eşleşmiyor");
                return false;
            }
            else
            {
                errProvider.SetError(textBox, null);
                return true;
            }
        }
        #endregion
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateChangePassword()) return;
            var customer = LoginedCustomer.GetLoginedCustomer;

            try
            {
                _customerService.ChangePassword(new Customer
                {
                    Id = customer.Id,
                    Address = customer.Address,
                    Name = customer.Name,
                    Phone = customer.Phone,
                    Email = customer.Email,
                    Password = txtOldPassword.Text
                }, txtNewPassword.Text);

                MessageBox.Show("Şifreniz güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
