namespace OnlineBookStore.UI
{
    partial class FrmBooks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategories);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(1024, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Göre Ara";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(40, 38);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(206, 24);
            this.cmbCategories.TabIndex = 8;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // tblProducts
            // 
            this.tblProducts.AutoScroll = true;
            this.tblProducts.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tblProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblProducts.ColumnCount = 4;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblProducts.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tblProducts.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tblProducts.Location = new System.Drawing.Point(0, 113);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.RowCount = 1;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblProducts.Size = new System.Drawing.Size(1024, 559);
            this.tblProducts.TabIndex = 11;
            // 
            // FrmBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 672);
            this.Controls.Add(this.tblProducts);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBooks";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "frmBooks";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TableLayoutPanel tblProducts;
    }
}