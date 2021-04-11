using System;
using System.Windows.Forms;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class FrmCustomerInfos : Form
    {
        private readonly ICustomerService _customerService;
        private Customer _customer;
        public FrmCustomerInfos()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();

        }

        private void frmCustomerInfos_Load(object sender, EventArgs e)
        {
            LoadInfos();

        }

        private void LoadInfos()
        {
            _customer = _customerService.GetById(LoginedCustomer.GetLoginedCustomer.Id);

            txtId.Text = _customer.Id.ToString();
            txtName.Text = _customer.Name;
            txtAddress.Text = _customer.Address;
            txtEmail.Text = _customer.Email;
            txtPhone.Text = _customer.Phone;
        }

        private void checkEdit_CheckedChanged_1(object sender, EventArgs e)
        {
            txtName.ReadOnly = txtName.ReadOnly != true;
            txtAddress.ReadOnly = txtAddress.ReadOnly != true;
            txtPhone.ReadOnly = txtPhone.ReadOnly != true;
        }

        #region Güncelle buton eventi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.Update(new Customer
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Password = _customer.Password,
                    Phone = txtPhone.Text
                });
                MessageBox.Show("Bilgileriniz güncellendi!");
                LoadInfos();
                checkEdit.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi");
            }
        }
        #endregion

        #region Şifre değiştirme
        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmChangePassword frm = new FrmChangePassword())
            {
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
