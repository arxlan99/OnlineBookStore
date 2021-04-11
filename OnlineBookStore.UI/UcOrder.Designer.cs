namespace OnlineBookStore.UI
{
    partial class UcOrder
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContentOfOrder = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblDateText = new System.Windows.Forms.Label();
            this.lblPriceText = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPaymentTypeText = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContentOfOrder
            // 
            this.lblContentOfOrder.AutoSize = true;
            this.lblContentOfOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContentOfOrder.Location = new System.Drawing.Point(10, 10);
            this.lblContentOfOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentOfOrder.Name = "lblContentOfOrder";
            this.lblContentOfOrder.Size = new System.Drawing.Size(138, 23);
            this.lblContentOfOrder.TabIndex = 0;
            this.lblContentOfOrder.Text = "Sipariş İçeriği";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(391, 146);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 54);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Siparişi İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 21;
            this.lstProducts.Location = new System.Drawing.Point(14, 53);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(280, 147);
            this.lstProducts.TabIndex = 2;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderDate.Location = new System.Drawing.Point(317, 10);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(126, 23);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Sipariş Tarihi";
            // 
            // lblDateText
            // 
            this.lblDateText.Location = new System.Drawing.Point(291, 34);
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.Size = new System.Drawing.Size(194, 32);
            this.lblDateText.TabIndex = 4;
            this.lblDateText.Text = "label1";
            this.lblDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceText
            // 
            this.lblPriceText.Location = new System.Drawing.Point(387, 107);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(194, 32);
            this.lblPriceText.TabIndex = 6;
            this.lblPriceText.Text = "label1";
            this.lblPriceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(391, 83);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(190, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Fiyat";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentTypeText
            // 
            this.lblPaymentTypeText.Location = new System.Drawing.Point(463, 39);
            this.lblPaymentTypeText.Name = "lblPaymentTypeText";
            this.lblPaymentTypeText.Size = new System.Drawing.Size(194, 32);
            this.lblPaymentTypeText.TabIndex = 8;
            this.lblPaymentTypeText.Text = "label1";
            this.lblPaymentTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentType.Location = new System.Drawing.Point(467, 11);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(190, 23);
            this.lblPaymentType.TabIndex = 7;
            this.lblPaymentType.Text = "Ödeme Tipi";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lblPaymentTypeText);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblPriceText);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDateText);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblContentOfOrder);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcOrder";
            this.Size = new System.Drawing.Size(659, 214);
            this.Load += new System.EventHandler(this.UcOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContentOfOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.Label lblPriceText;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPaymentTypeText;
        private System.Windows.Forms.Label lblPaymentType;
    }
}
