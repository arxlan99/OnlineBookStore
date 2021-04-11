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
    public partial class FrmOrders : Form
    {
        private IOrderService _orderService;
        private IOrderedProductService _orderedProductService;
        private IProductService _productService;

        private List<Order> orders;
        private List<OrderedProduct> orderedProducts;
        public FrmOrders()
        {
            InitializeComponent();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _orderedProductService = InstanceFactory.GetInstance<IOrderedProductService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            orderedProducts = new List<OrderedProduct>();

            orders = GetOrderId();
            if (PanelControls())
                return;

            GetOrderedItems();
            LoadProductsToCards();
        }


        #region Sipariş olup olmama durumuna göre formun düzenlenmesi
        private bool PanelControls()
        {
            if (orders.Count == 0)
            {
                pnlNoOrder.Visible = true;
                pnlOrders.Visible = false;
                return true;
            }
            else
            {
                pnlNoOrder.Visible = false;
                pnlOrders.Visible = true;
                return false;
            }
        }
        #endregion

        #region Siparişleri getirme
        private List<Order> GetOrderId()
        {
            return _orderService.GetOrdersIdByCustomerId(LoginedCustomer.GetLoginedCustomer.Id);
        }
        #endregion

        #region Sipariş edilen ürünleri getirme
        private void GetOrderedItems()
        {
            foreach (var order in orders)
            {
                var products = _orderedProductService.GetAll(order.Id);

                foreach (var product in products)
                    orderedProducts.Add(product);
            }
        }
        #endregion

        #region Ürünleri UcOrder ile ekrana yazdırma
        private void LoadProductsToCards()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                List<OrderedProduct> products = orderedProducts.Where(x => x.OrderId == orders[i].Id).ToList();
                List<string> productNames = new List<string>();
                List<int> productQuantities = new List<int>();

                foreach (var item in products)
                {
                    productQuantities.Add(item.Quantity);
                    productNames.Add(_productService.GetById(item.ProductId).ProductName);
                }

                pnlOrders.Controls.Add(new UcOrder
                {
                    Date = orders[i].OrderDate,
                    ProductNames = productNames,
                    ProductQuantities = productQuantities,
                    PaymentAmount = orders[i].PaymentAmount,
                    PaymentType = orders[i].PaymentType.ToString()
                });
            }
        }
        #endregion
    }
}
