namespace OnlineBookStore.UI
{
    partial class FrmLogin
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
            this.tbLoginRegister = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPasswordR = new System.Windows.Forms.TextBox();
            this.txtEmailR = new System.Windows.Forms.TextBox();
            this.lblPasswordR = new System.Windows.Forms.Label();
            this.lblEmailR = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbLoginRegister.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLoginRegister
            // 
            this.tbLoginRegister.Controls.Add(this.tabLogin);
            this.tbLoginRegister.Controls.Add(this.tabRegister);
            this.tbLoginRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLoginRegister.Location = new System.Drawing.Point(0, 0);
            this.tbLoginRegister.Name = "tbLoginRegister";
            this.tbLoginRegister.SelectedIndex = 0;
            this.tbLoginRegister.Size = new System.Drawing.Size(602, 434);
            this.tbLoginRegister.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbLoginRegister.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabLogin.Controls.Add(this.chkRemember);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.txtEmail);
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.lblEmail);
            this.tabLogin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabLogin.Location = new System.Drawing.Point(4, 26);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Size = new System.Drawing.Size(594, 404);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Giriş Yap";
            this.tabLogin.ToolTipText = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(173, 220);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(109, 23);
            this.chkRemember.TabIndex = 2;
            this.chkRemember.Text = "Beni Hatırla";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(173, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(169, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(169, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.txtPhone);
            this.tabRegister.Controls.Add(this.lblPhone);
            this.tabRegister.Controls.Add(this.txtAddress);
            this.tabRegister.Controls.Add(this.txtName);
            this.tabRegister.Controls.Add(this.lblAddress);
            this.tabRegister.Controls.Add(this.lblName);
            this.tabRegister.Controls.Add(this.txtPasswordAgain);
            this.tabRegister.Controls.Add(this.lblPasswordAgain);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.txtPasswordR);
            this.tabRegister.Controls.Add(this.txtEmailR);
            this.tabRegister.Controls.Add(this.lblPasswordR);
            this.tabRegister.Controls.Add(this.lblEmailR);
            this.tabRegister.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabRegister.Location = new System.Drawing.Point(4, 26);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Size = new System.Drawing.Size(594, 404);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Kayıt Ol";
            this.tabRegister.ToolTipText = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(35, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(31, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 19);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Telefon";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(35, 201);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 52);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 23);
            this.txtName.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 179);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 19);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Adres";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 19);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Ad";
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Location = new System.Drawing.Point(330, 201);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(236, 23);
            this.txtPasswordAgain.TabIndex = 5;
            this.txtPasswordAgain.UseSystemPasswordChar = true;
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Location = new System.Drawing.Point(326, 179);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(79, 19);
            this.lblPasswordAgain.TabIndex = 11;
            this.lblPasswordAgain.Text = "Şifre Tekrar";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(185, 274);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(236, 44);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPasswordR
            // 
            this.txtPasswordR.Location = new System.Drawing.Point(330, 138);
            this.txtPasswordR.Name = "txtPasswordR";
            this.txtPasswordR.Size = new System.Drawing.Size(236, 23);
            this.txtPasswordR.TabIndex = 4;
            this.txtPasswordR.UseSystemPasswordChar = true;
            // 
            // txtEmailR
            // 
            this.txtEmailR.Location = new System.Drawing.Point(330, 78);
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(236, 23);
            this.txtEmailR.TabIndex = 3;
            // 
            // lblPasswordR
            // 
            this.lblPasswordR.AutoSize = true;
            this.lblPasswordR.Location = new System.Drawing.Point(326, 116);
            this.lblPasswordR.Name = "lblPasswordR";
            this.lblPasswordR.Size = new System.Drawing.Size(36, 19);
            this.lblPasswordR.TabIndex = 7;
            this.lblPasswordR.Text = "Şifre";
            // 
            // lblEmailR
            // 
            this.lblEmailR.AutoSize = true;
            this.lblEmailR.Location = new System.Drawing.Point(326, 56);
            this.lblEmailR.Name = "lblEmailR";
            this.lblEmailR.Size = new System.Drawing.Size(46, 19);
            this.lblEmailR.TabIndex = 6;
            this.lblEmailR.Text = "Email";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 434);
            this.Controls.Add(this.tbLoginRegister);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tbLoginRegister.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbLoginRegister;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.Label lblPasswordAgain;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPasswordR;
        private System.Windows.Forms.TextBox txtEmailR;
        private System.Windows.Forms.Label lblPasswordR;
        private System.Windows.Forms.Label lblEmailR;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}