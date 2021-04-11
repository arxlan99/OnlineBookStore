using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore.UI
{
    public partial class UcProduct : UserControl
    {
        public UcProduct()
        {
            InitializeComponent();
        }
        private int _id;
        private int _categoryId;

        public int ProductId
        {
            get { return _id; }
            set { _id = value; }
        }

        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }

        public new string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string Image
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FrmProductDetails.ProductId = _id;
            FrmProductDetails.CategoryId = _categoryId;
            FrmProductDetails.Image = this.Image;
            FrmProductDetails.Price = decimal.Parse(this.Price.Substring(0, Price.Length - 3));
            FrmProductDetails frm = new FrmProductDetails();
            frm.ShowDialog();
        }
    }
}
