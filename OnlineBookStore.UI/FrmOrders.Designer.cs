namespace OnlineBookStore.UI
{
    partial class FrmOrders
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
            this.pnlNoOrder = new System.Windows.Forms.Panel();
            this.lblNoOrder = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNoOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNoOrder
            // 
            this.pnlNoOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.pnlNoOrder.Controls.Add(this.lblNoOrder);
            this.pnlNoOrder.Location = new System.Drawing.Point(231, 102);
            this.pnlNoOrder.Name = "pnlNoOrder";
            this.pnlNoOrder.Size = new System.Drawing.Size(516, 346);
            this.pnlNoOrder.TabIndex = 0;
            // 
            // lblNoOrder
            // 
            this.lblNoOrder.AutoSize = true;
            this.lblNoOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNoOrder.ForeColor = System.Drawing.Color.White;
            this.lblNoOrder.Location = new System.Drawing.Point(100, 147);
            this.lblNoOrder.Name = "lblNoOrder";
            this.lblNoOrder.Size = new System.Drawing.Size(338, 28);
            this.lblNoOrder.TabIndex = 0;
            this.lblNoOrder.Text = "Siparişiniz Bulunmamaktadır";
            // 
            // pnlOrders
            // 
            this.pnlOrders.AutoScroll = true;
            this.pnlOrders.Location = new System.Drawing.Point(138, 44);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(759, 535);
            this.pnlOrders.TabIndex = 1;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.pnlNoOrder);
            this.Controls.Add(this.pnlOrders);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.pnlNoOrder.ResumeLayout(false);
            this.pnlNoOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNoOrder;
        private System.Windows.Forms.Label lblNoOrder;
        private System.Windows.Forms.FlowLayoutPanel pnlOrders;
    }
}