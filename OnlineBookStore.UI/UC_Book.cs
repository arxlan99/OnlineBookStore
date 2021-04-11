using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore.UI
{
    public partial class UcBook : UserControl
    {
        public UcBook()
        {
            InitializeComponent();
        }

        public string BookName
        {
            get => lblBookName.Text;
            set => lblBookName.Text = value;
        }

        public string Isbn
        {
            get => lblISBN.Text;
            set => lblISBN.Text = value;
        }

        public string Author
        {
            get => lblAuthor.Text;
            set => lblAuthor.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }

        public string Page
        {
            get => lblPage.Text;
            set => lblPage.Text = value;
        }

        public Image Icon
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        private void btnAddChart_Click(object sender, EventArgs e)
        {

        }
    }
}
