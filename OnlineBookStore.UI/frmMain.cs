using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore.UI
{
    public partial class FrmMain : Form
    {
        private Form _activeForm = null;
        public void openChildForm(Form childForm)
        {
            _activeForm?.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            openChildForm(new FrmBooks());          
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBooks());
        }

        private void btnUserInfos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCustomerInfos());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialog != DialogResult.Yes) return;

            Application.Exit();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmShoppingCart());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmOrders());
        }
    }
}
