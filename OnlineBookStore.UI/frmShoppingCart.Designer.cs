namespace OnlineBookStore.UI
{
    partial class FrmShoppingCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlShoppingDetails = new System.Windows.Forms.Panel();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.lblSiparis = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNoProduct = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlShoppingDetails.SuspendLayout();
            this.pnlOzet.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlNoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShoppingDetails
            // 
            this.pnlShoppingDetails.Controls.Add(this.pnlOzet);
            this.pnlShoppingDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlShoppingDetails.Location = new System.Drawing.Point(656, 0);
            this.pnlShoppingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShoppingDetails.Name = "pnlShoppingDetails";
            this.pnlShoppingDetails.Size = new System.Drawing.Size(344, 591);
            this.pnlShoppingDetails.TabIndex = 0;
            // 
            // pnlOzet
            // 
            this.pnlOzet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlOzet.Controls.Add(this.btnContinue);
            this.pnlOzet.Controls.Add(this.lblPrice);
            this.pnlOzet.Controls.Add(this.lblToplam);
            this.pnlOzet.Controls.Add(this.lblNumberOfProducts);
            this.pnlOzet.Controls.Add(this.lblSiparis);
            this.pnlOzet.Location = new System.Drawing.Point(4, 114);
            this.pnlOzet.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(307, 299);
            this.pnlOzet.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(43, 236);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(221, 43);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Devam Et";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.lblPrice.Location = new System.Drawing.Point(195, 188);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.lblToplam.Location = new System.Drawing.Point(39, 188);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(81, 23);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "Toplam";
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOfProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.lblNumberOfProducts.Location = new System.Drawing.Point(3, 83);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(300, 41);
            this.lblNumberOfProducts.TabIndex = 1;
            this.lblNumberOfProducts.Text = "N Product";
            this.lblNumberOfProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSiparis
            // 
            this.lblSiparis.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.lblSiparis.Location = new System.Drawing.Point(4, 40);
            this.lblSiparis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiparis.Name = "lblSiparis";
            this.lblSiparis.Size = new System.Drawing.Size(299, 43);
            this.lblSiparis.TabIndex = 0;
            this.lblSiparis.Text = "Sipariş Özeti";
            this.lblSiparis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.Controls.Add(this.pnlNoProduct);
            this.pnlProducts.Location = new System.Drawing.Point(31, 29);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(618, 536);
            this.pnlProducts.TabIndex = 1;
            // 
            // pnlNoProduct
            // 
            this.pnlNoProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlNoProduct.Controls.Add(this.lblInfo);
            this.pnlNoProduct.Controls.Add(this.pictureBox1);
            this.pnlNoProduct.Location = new System.Drawing.Point(4, 4);
            this.pnlNoProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNoProduct.Name = "pnlNoProduct";
            this.pnlNoProduct.Size = new System.Drawing.Size(500, 446);
            this.pnlNoProduct.TabIndex = 5;
            this.pnlNoProduct.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.lblInfo.Location = new System.Drawing.Point(113, 269);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 34);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Sepetinizde Ürün Yok";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineBookStore.UI.Properties.Resources.clear_shopping_cart_96px;
            this.pictureBox1.Location = new System.Drawing.Point(168, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlShoppingDetails);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmShoppingCart";
            this.Text = "frmShoppingCart";
            this.Load += new System.EventHandler(this.FrmShoppingCart_Load);
            this.pnlShoppingDetails.ResumeLayout(false);
            this.pnlOzet.ResumeLayout(false);
            this.pnlOzet.PerformLayout();
            this.pnlProducts.ResumeLayout(false);
            this.pnlNoProduct.ResumeLayout(false);
            this.pnlNoProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShoppingDetails;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label lblSiparis;
        private System.Windows.Forms.FlowLayoutPanel pnlProducts;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Panel pnlNoProduct;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}