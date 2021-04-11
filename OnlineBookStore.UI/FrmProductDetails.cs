using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.Entities.Abstract;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.UI
{
    public partial class FrmProductDetails : Form
    {
        public static int ProductId;
        public static int CategoryId;
        public static string Image;
        public static decimal Price;
        private IProductService _productService;
        private IItemToPurchaseService _itemToPurchaseService;
        private IShoppingCartService _shoppingCartService;
        private Product product;


        public FrmProductDetails()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _itemToPurchaseService = InstanceFactory.GetInstance<IItemToPurchaseService>();
            _shoppingCartService = InstanceFactory.GetInstance<IShoppingCartService>();
        }

        private void FrmProductDetails_Load(object sender, EventArgs e)
        {
            GetProduct();
            LoadProductImage();
        }

        private void LoadProductImage()
        {
            if (File.Exists(@"..\..\images\productImages\" + Image))
                pcbProduct.ImageLocation = @"..\..\images\productImages\" + Image;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetProduct()
        {
            product = _productService.GetById(ProductId);

            var type = product.GetType();
            var attributesOfProduct = type.GetProperties(BindingFlags.Public |
                                                         BindingFlags.Instance |
                                                         BindingFlags.DeclaredOnly);
            foreach (var item in attributesOfProduct)
            {
                var name = item.GetValue(product, null);
                lsbDetails.Items.Add(item.Name + ": " + name);
            }
            label1.Text = Price.ToString();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                _itemToPurchaseService.AddProduct(new ItemToPurchase
                {
                    ProductId = product.ProductId,
                    Quantity = int.Parse(numericUpDown1.Value.ToString()),
                    ShoppingCartId = _shoppingCartService.GetShoppingCartId(LoginedCustomer.GetLoginedCustomer.Id),

                });

                MessageBox.Show("Ürün sepetinize eklendi");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün ekleme başarısız");
                throw;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;

            if (numericUpDown1.Value > 5)
                numericUpDown1.Value = 5;
            label1.Text = (numericUpDown1.Value * Price).ToString();
        }
    }
}
