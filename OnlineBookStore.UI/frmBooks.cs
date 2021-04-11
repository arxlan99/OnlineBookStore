using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.Concrete;
using OnlineBookStore.Business.DependencyResolvers.Ninject;
using OnlineBookStore.DataAccess.Concrete.EntityFramework;
using OnlineBookStore.Entities.Abstract;
using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OnlineBookStore.UI
{
    public partial class FrmBooks : Form
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public FrmBooks()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();

            var products = _productService.GetAll();
            LoadBooks(products);
        }

        private void LoadCategoriesToCombobox()
        {
            var categories = _categoryService.GetAll();

            cmbCategories.Items.Add("All Categories");

            foreach (var category in categories)
                cmbCategories.Items.Add(category.CategoryName);
        }

        private void LoadBooks(List<Product> products)
        {
            tblProducts.Controls.Clear();

            foreach (var product in products)
            {
                UcProduct ucProduct = new UcProduct();
                ucProduct.ProductName = product.ProductName;
                ucProduct.Price = product.Price.ToString() + " TL";
                ucProduct.ProductId = product.ProductId;
                ucProduct.CategoryId = product.CategoryId;

                if (File.Exists(@"..\..\images\productImages\" + product.Image))
                    ucProduct.Image = @"..\..\images\productImages\" + product.Image;

                tblProducts.Controls.Add(ucProduct);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbCategories.SelectedIndex;
            List<Product> products;

            if (index == 0)
                products = _productService.GetAll();
            else
                products = _productService.GetByCategories(index);

            LoadBooks(products);          
        }
    }
}
