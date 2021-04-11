namespace OnlineBookStore.UI
{
    partial class FrmPaymentScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDeliveryInfo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblInvoiceInfos = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPaymentInfos = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.MaskedTextBox();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.lstBoughtProducts = new System.Windows.Forms.ListBox();
            this.errPaymentType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderSummary.Location = new System.Drawing.Point(12, 9);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(153, 28);
            this.lblOrderSummary.TabIndex = 0;
            this.lblOrderSummary.Text = "Sipariş Özeti";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(300, 517);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "... Tl";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(196, 514);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 28);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Toplam";
            // 
            // lblDeliveryInfo
            // 
            this.lblDeliveryInfo.AutoSize = true;
            this.lblDeliveryInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeliveryInfo.Location = new System.Drawing.Point(12, 207);
            this.lblDeliveryInfo.Name = "lblDeliveryInfo";
            this.lblDeliveryInfo.Size = new System.Drawing.Size(196, 28);
            this.lblDeliveryInfo.TabIndex = 4;
            this.lblDeliveryInfo.Text = "Teslimat Bilgileri";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(26, 276);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 77);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(22, 249);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(132, 21);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Teslimat Adresi";
            // 
            // lblInvoiceInfos
            // 
            this.lblInvoiceInfos.AutoSize = true;
            this.lblInvoiceInfos.Location = new System.Drawing.Point(293, 249);
            this.lblInvoiceInfos.Name = "lblInvoiceInfos";
            this.lblInvoiceInfos.Size = new System.Drawing.Size(121, 21);
            this.lblInvoiceInfos.TabIndex = 8;
            this.lblInvoiceInfos.Text = "Fatura Bilgileri";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(297, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 28);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(297, 325);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 28);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPaymentInfos
            // 
            this.lblPaymentInfos.AutoSize = true;
            this.lblPaymentInfos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentInfos.Location = new System.Drawing.Point(12, 384);
            this.lblPaymentInfos.Name = "lblPaymentInfos";
            this.lblPaymentInfos.Size = new System.Drawing.Size(191, 28);
            this.lblPaymentInfos.TabIndex = 10;
            this.lblPaymentInfos.Text = "Ödeme Bilgileri";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(33, 422);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(155, 21);
            this.lblPaymentType.TabIndex = 12;
            this.lblPaymentType.Text = "Ödeme Seçeneği";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Nakit",
            "KrediKartı"});
            this.cmbPaymentType.Location = new System.Drawing.Point(37, 450);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(221, 29);
            this.cmbPaymentType.TabIndex = 13;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(293, 422);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(93, 21);
            this.lblCreditCard.TabIndex = 14;
            this.lblCreditCard.Text = "Kredi Kartı";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Enabled = false;
            this.txtCreditCard.Location = new System.Drawing.Point(297, 451);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(229, 28);
            this.txtCreditCard.TabIndex = 15;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnCompleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteOrder.FlatAppearance.BorderSize = 0;
            this.btnCompleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnCompleteOrder.Location = new System.Drawing.Point(110, 577);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(333, 52);
            this.btnCompleteOrder.TabIndex = 16;
            this.btnCompleteOrder.Text = "Siparişi Tamamla";
            this.btnCompleteOrder.UseVisualStyleBackColor = false;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // lstBoughtProducts
            // 
            this.lstBoughtProducts.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoughtProducts.FormattingEnabled = true;
            this.lstBoughtProducts.ItemHeight = 21;
            this.lstBoughtProducts.Location = new System.Drawing.Point(26, 49);
            this.lstBoughtProducts.Name = "lstBoughtProducts";
            this.lstBoughtProducts.Size = new System.Drawing.Size(503, 151);
            this.lstBoughtProducts.TabIndex = 17;
            // 
            // errPaymentType
            // 
            this.errPaymentType.ContainerControl = this;
            // 
            // FrmPaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 681);
            this.Controls.Add(this.lstBoughtProducts);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblPaymentInfos);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblInvoiceInfos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblDeliveryInfo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblOrderSummary);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPaymentScreen";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaymentScreen";
            ((System.ComponentModel.ISupportInitialize)(this.errPaymentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDeliveryInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblInvoiceInfos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPaymentInfos;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.MaskedTextBox txtCreditCard;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.ListBox lstBoughtProducts;
        private System.Windows.Forms.ErrorProvider errPaymentType;
    }
}