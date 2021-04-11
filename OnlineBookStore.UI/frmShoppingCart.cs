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
using OnlineBookStore.Entities.Abstract;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class FrmShoppingCart : Form
    {
        private IItemToPurchaseService _itemToPurchaseService;
        private IShoppingCartService _shoppingCartService;
        private IProductService _productService;

        private static int shoppingCartId;
        private decimal sumOfProductsPrice = 0;
        private static List<ItemToPurchase> itemToPurchases;
        private static List<Product> _products;
        public FrmShoppingCart()
        {
            InitializeComponent();
            _itemToPurchaseService = InstanceFactory.GetInstance<IItemToPurchaseService>();
            _shoppingCartService = InstanceFactory.GetInstance<IShoppingCartService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void FrmShoppingCart_Load(object sender, EventArgs e)
        {
            FormLoad();

        }
        private void FormLoad()
        {
            _products = new List<Product>();

            int productNumber = LoadNumberOfProducts();
            LoadProductsToCarts(productNumber);
            LoadPriceOfProducts();
        }

        #region Shopping Cart id getirme
        private void GetShoppingCartId()
        {
            shoppingCartId = _shoppingCartService.GetShoppingCartId
                    (LoginedCustomer.GetLoginedCustomer.Id);
        }
        #endregion

        #region Ürün sayısını getirme
        private int LoadNumberOfProducts()
        {
            try
            {
                GetShoppingCartId();

                itemToPurchases = _itemToPurchaseService.GetProducts(shoppingCartId);
                if (itemToPurchases == null) return 0;

                int productNumber = 0;
                foreach (var item in itemToPurchases)
                    productNumber += item.Quantity;

                lblNumberOfProducts.Text = productNumber.ToString() + " Ürün";
                return productNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Fiyat yazdırma
        private void LoadPriceOfProducts()
        {
            for (int i = 0; i < _products.Count; i++)
                sumOfProductsPrice += _products[i].Price * itemToPurchases[i].Quantity;

            lblPrice.Text = sumOfProductsPrice.ToString() + " TL";
        }
        #endregion

        #region Ürünleri forma yükleme
        private void LoadProductsToCarts(int productNumber)
        {
            if (productNumber == 0)
            {
                pnlOzet.Visible = false;
                pnlNoProduct.Visible = true;
                return;
            }
            GetProducts();

            for (int i = 0; i < _products.Count; i++)
            {
                pnlProducts.Controls.Add(new UcCart
                {
                    ProductName = _products[i].ProductName,
                    Price = _products[i].Price.ToString() + " TL",
                    Image = @"..\..\images\productImages\" + _products[i].Image,
                    Quantity = itemToPurchases[i].Quantity.ToString(),
                    ProductId = _products[i].ProductId,
                    Id = itemToPurchases[i].Id
                });
            }
        }
        #endregion

        #region Ürünleri getirme
        private void GetProducts()
        {
            foreach (var item in itemToPurchases)
            {
                var product = _productService.GetById(item.ProductId);
                _products.Add(product);
            }
        }
        #endregion

        #region Alışverişe devam et buton eventi
        private void btnContinue_Click(object sender, EventArgs e)
        {
            using (FrmPaymentScreen frm = new FrmPaymentScreen())
            {
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
