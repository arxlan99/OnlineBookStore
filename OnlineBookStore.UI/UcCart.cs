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
    public partial class UcCart : UserControl
    {

        private IItemToPurchaseService _itemToPurchaseService;
        private IShoppingCartService _shoppingCartService;

        private int shoppingCartId;

        public UcCart()
        {
            InitializeComponent();
            _itemToPurchaseService = InstanceFactory.GetInstance<IItemToPurchaseService>();
            _shoppingCartService = InstanceFactory.GetInstance<IShoppingCartService>();
            GetShoppingCartId();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }

        public new string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public string Quantity
        {
            get { return lblQuantity.Text; }
            set { lblQuantity.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string Image
        {
            get { return pcbProduct.ImageLocation; }
            set { pcbProduct.ImageLocation = value; }
        }

        private void GetShoppingCartId()
        {
            shoppingCartId = _shoppingCartService.GetShoppingCartId(LoginedCustomer.GetLoginedCustomer.Id);
        }

        #region Ürün silme eventi
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _itemToPurchaseService.DeleteProduct(new ItemToPurchase
                {
                    Id = Id,
                    ProductId = ProductId,
                    Quantity = int.Parse(Quantity),
                    ShoppingCartId = shoppingCartId
                });
                MessageBox.Show("Ürün sepetinizden silindi");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün silinemedi\n" + ex.Message);
            }
        }
        #endregion
    }
}
