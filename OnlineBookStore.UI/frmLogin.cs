using System;
using System.Windows.Forms;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class FrmLogin : Form
    {
        private ICustomerService _customerService;
        private IShoppingCartService _shoppingCartService;
        public FrmLogin()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _shoppingCartService = InstanceFactory.GetInstance<IShoppingCartService>();
            LoadInfosFromSettings();
        }

        private void LoadInfosFromSettings()
        {
            if (Properties.Settings.Default.Email != string.Empty)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void SaveInfosToSettingsIfChecked()
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.Email = txtEmail.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }

        #region Login butonu eventi
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!LoginValidate()) return;
            SaveInfosToSettingsIfChecked();

            var customer = _customerService.Get(txtEmail.Text, txtPassword.Text);

            if (customer != null)
            {
                MessageBox.Show("Giriş Başarılı");

                var loginedCustomer = LoginedCustomer.GetLoginedCustomer;
                loginedCustomer.Id = customer.Id;
                loginedCustomer.Email = customer.Email;
                loginedCustomer.Address = customer.Address;
                loginedCustomer.Name = customer.Name;
                loginedCustomer.Phone = customer.Phone;

                using (var frm = new FrmMain())
                {
                    this.Hide();
                    frm.ShowDialog();
                    this.Dispose();
                }
            }
            else
                MessageBox.Show("Giriş Başarısız");
        }
        #endregion

        #region Register butonu eventi
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!RegisterValidate()) return;

                _customerService.Add(new Customer
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmailR.Text,
                    Password = txtPasswordR.Text
                });

                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var customer = _customerService.Get(txtEmailR.Text, txtPasswordR.Text);
            if (customer != null)
                _shoppingCartService.CreateShoppingCart(customer.Id);
        }
        #endregion

        #region Register kuralları
        private bool RegisterValidate()
        {
            if (ValidateIsNullOrEmpty(txtName, lblName) && ValidateIsNullOrEmpty(txtAddress, lblAddress) &&
                ValidateIsNullOrEmpty(txtPhone, lblPhone) && ValidateIsNullOrEmpty(txtEmailR, lblEmailR) &&
                ValidateIsNullOrEmpty(txtPasswordR, lblPasswordR) && ValidateIsNullOrEmpty(txtPasswordAgain, lblPasswordAgain) &&
                ValidateIsMatch(txtPasswordR, txtPasswordAgain) && IsValidEmail(txtEmailR, lblEmailR))
                return true;

            return false;
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

        #region Login kuralları
        private bool LoginValidate()
        {
            if (ValidateIsNullOrEmpty(txtEmail, lblEmail) && ValidateIsNullOrEmpty(txtPassword, lblPassword))
                return true;

            return false;
        }

        #endregion

        #region Email formatı kontrol
        private bool IsValidEmail(TextBox textBox, Label label)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(textBox.Text);
                errProvider.SetError(textBox, null);
                return addr.Address == textBox.Text;
            }
            catch
            {
                errProvider.SetError(textBox, $"{label.Text} biçimi doğru değil");
                return false;
            }
        }
        #endregion

    }
}
