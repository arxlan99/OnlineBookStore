namespace OnlineBookStore.UI
{
    partial class FrmCustomerInfos
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
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.checkEdit = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.lnkChangePassword);
            this.gbxCustomer.Controls.Add(this.txtPhone);
            this.gbxCustomer.Controls.Add(this.lblPhone);
            this.gbxCustomer.Controls.Add(this.checkEdit);
            this.gbxCustomer.Controls.Add(this.txtEmail);
            this.gbxCustomer.Controls.Add(this.txtAddress);
            this.gbxCustomer.Controls.Add(this.txtName);
            this.gbxCustomer.Controls.Add(this.txtId);
            this.gbxCustomer.Controls.Add(this.btnUpdate);
            this.gbxCustomer.Controls.Add(this.label8);
            this.gbxCustomer.Controls.Add(this.label5);
            this.gbxCustomer.Controls.Add(this.label4);
            this.gbxCustomer.Controls.Add(this.label1);
            this.gbxCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxCustomer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxCustomer.Location = new System.Drawing.Point(56, 48);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(732, 390);
            this.gbxCustomer.TabIndex = 11;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Müşteri Bilgileri";
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.ActiveLinkColor = System.Drawing.Color.Olive;
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Location = new System.Drawing.Point(510, 223);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(118, 21);
            this.lnkChangePassword.TabIndex = 16;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "Şifreyi Değiştir";
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(160, 204);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(223, 28);
            this.txtPhone.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(92, 207);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 21);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Telefon";
            // 
            // checkEdit
            // 
            this.checkEdit.AutoSize = true;
            this.checkEdit.Location = new System.Drawing.Point(484, 151);
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.Size = new System.Drawing.Size(167, 25);
            this.checkEdit.TabIndex = 13;
            this.checkEdit.Text = "Bilgilerini Düzenle";
            this.checkEdit.UseVisualStyleBackColor = true;
            this.checkEdit.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(223, 28);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(160, 245);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(223, 81);
            this.txtAddress.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 121);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(223, 28);
            this.txtName.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 80);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(223, 28);
            this.txtId.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(509, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 33);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Müşteri Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // FrmCustomerInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 482);
            this.Controls.Add(this.gbxCustomer);
            this.Name = "FrmCustomerInfos";
            this.Text = "frmCustomerInfos";
            this.Load += new System.EventHandler(this.frmCustomerInfos_Load);
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.CheckBox checkEdit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
    }
}