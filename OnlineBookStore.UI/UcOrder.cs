using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class UcOrder : UserControl
    {
        private IOrderService _orderService;
        private IOrderedProductService _orderedProductService;
        public UcOrder()
        {
            InitializeComponent();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _orderedProductService = InstanceFactory.GetInstance<IOrderedProductService>();
        }

        private void UcOrder_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ProductNames.Count; i++)
                lstProducts.Items.Add(ProductQuantities[i] + " adet" + ProductNames[i]);

            PaymentAmountText = PaymentAmount.ToString() + " TL";
        }
        public List<string> ProductNames { get; set; }
        public List<int> ProductQuantities { get; set; }
        public decimal PaymentAmount { get; set; }

        private int orderId;

        public string Date
        {
            get { return lblDateText.Text; }
            set { lblDateText.Text = value; }
        }

        public string PaymentType
        {
            get { return lblPaymentTypeText.Text; }
            set { lblPaymentTypeText.Text = value; }
        }

        private string PaymentAmountText
        {
            get { return lblPriceText.Text; }
            set { lblPriceText.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                GetOrderId();
                DeleteOrderedProducts();
                SendEmailAboutCancelOrder();
                DeleteOrder();

                MessageBox.Show("Siparişiniz iptal edildi");

                this.Dispose();
            }
            catch (Exception)
            { MessageBox.Show("Siparişiniz iptal edilemedi"); }
        }

        private void DeleteOrder()
        {
            _orderService.DeleteOrderByOrderId(orderId);
        }

        private void DeleteOrderedProducts()
        {
            _orderedProductService.DeleteProductsByOrderId(orderId);
        }

        private void GetOrderId()
        {
            orderId = _orderService.GetOrderIdByDate(Date);
        }

        private void SendEmailAboutCancelOrder()
        {
            _orderService.SendInfoAboutCancelOrderByEmail(LoginedCustomer.GetLoginedCustomer, orderId);
        }
    }
}
