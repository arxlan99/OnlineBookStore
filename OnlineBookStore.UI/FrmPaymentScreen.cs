using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class FrmPaymentScreen : Form
    {

        private IShoppingCartService _shoppingCartService;
        private IItemToPurchaseService _itemToPurchaseService;
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderedProductService _orderedProductService;

        private int shoppingCartId;
        private decimal price;
        private List<ItemToPurchase> itemToPurchases;
        public FrmPaymentScreen()
        {
            InitializeComponent();
            _shoppingCartService = InstanceFactory.GetInstance<IShoppingCartService>();
            _itemToPurchaseService = InstanceFactory.GetInstance<IItemToPurchaseService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _orderedProductService = InstanceFactory.GetInstance<IOrderedProductService>();

            LoadInfos();
            GetShoppingCartId();
        }

        #region Kullanıcıya ait shoppingCartId bulma
        private void GetShoppingCartId()
        {
            shoppingCartId = _shoppingCartService.GetShoppingCartId(LoginedCustomer.GetLoginedCustomer.Id);
            GetItemToPurchases();
        }
        #endregion

        #region Satın alınacak ürünleri veri tabanından alma
        private void GetItemToPurchases()
        {
            itemToPurchases = _itemToPurchaseService.GetProducts(shoppingCartId);
            WriteProductsToListView();
        }
        #endregion

        #region Ürünleri listeye yazdırma
        private void WriteProductsToListView()
        {
            foreach (var item in itemToPurchases)
            {
                price += _productService.GetById(item.ProductId).Price * item.Quantity;
                lstBoughtProducts.Items.Add(
                    item.Quantity + " adet\t" +
                    _productService.GetById(item.ProductId).ProductName);
            }
            lblPrice.Text = price + " TL";
        }
        #endregion

        #region Kullanıcıya ait bilgileri yazdırma
        private void LoadInfos()
        {
            txtAddress.Text = LoginedCustomer.GetLoginedCustomer.Address;
            txtEmail.Text = LoginedCustomer.GetLoginedCustomer.Email;
            txtPhone.Text = LoginedCustomer.GetLoginedCustomer.Phone;
        }
        #endregion

        #region Ödeme tipine göre kredi kartı bölümünü aktif etme
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.SelectedIndex == 0)
                txtCreditCard.Enabled = false;
            else
                txtCreditCard.Enabled = true;
        }
        #endregion

        #region Siparişi tamamla butonu eventi
        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PaymentTypeValidate()) return;

                int orderId = CreateOrder();
                AddOrderedProducts(orderId);
                DeleteOrderedProductsFromItemToPurchasesTable();

                MessageBox.Show("Sipariş tamamlandı");

                SendInvoiceByPhoneAndByEmail(orderId);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş tamamlanamadı" + ex.Message);
            }
        }
        #endregion

        #region Sipariş Oluşturma
        private int CreateOrder()
        {
            return _orderService.CreateAndReturnOrderId(new Order
            {
                CustomerId = LoginedCustomer.GetLoginedCustomer.Id,
                OrderDate = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                PaymentType = (PaymentTypes)cmbPaymentType.SelectedIndex + 1,
                PaymentAmount = price
            });
        }
        #endregion

        #region Ürünleri orderedProducts tablosuna yazdırma
        private void AddOrderedProducts(int orderId)
        {
            for (int i = 0; i < itemToPurchases.Count; i++)
            {
                _orderedProductService.Add(new OrderedProduct
                {
                    OrderId = orderId,
                    ProductId = itemToPurchases[i].ProductId,
                    Quantity = itemToPurchases[i].Quantity
                });
            }
        }
        #endregion

        #region Ürünleri itemToPurchases tablosundan silme
        private void DeleteOrderedProductsFromItemToPurchasesTable()
        {
            foreach (var item in itemToPurchases)
            {
                _itemToPurchaseService.DeleteProduct(item);
            }
        }
        #endregion

        #region Ödeme tipi kontrolü
        private bool PaymentTypeValidate()
        {
            if (cmbPaymentType.SelectedItem == null)
            {
                errPaymentType.SetError(cmbPaymentType, "Ödeme tipini seçmeniz gerekmektedir");
                return false;
            }
            else
            {
                errPaymentType.SetError(cmbPaymentType, null);
                return true;
            }
        }
        #endregion

        private void SendInvoiceByPhoneAndByEmail(int orderId)
        {
            var customer = LoginedCustomer.GetLoginedCustomer;
            _orderService.SendInvoiceByEmail(customer, orderId);
            MessageBox.Show("Fatura bilgileri " + customer.Email + " e gönderildi.");

            _orderService.SendInvoiceByPhone(customer, orderId);
            MessageBox.Show("Fatura bilgileri " + customer.Phone + " e gönderildi.");

        }
    }
}
