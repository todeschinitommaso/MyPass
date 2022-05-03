
namespace MyPass
{
    partial class Mypass
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mypass));
            this.login = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.viewbutton = new System.Windows.Forms.Button();
            this.hidebutton = new System.Windows.Forms.Button();
            this.signpanel = new System.Windows.Forms.Panel();
            this.nextbutton = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            this.signpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(181, 151);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(129, 39);
            this.login.TabIndex = 0;
            this.login.Text = "LOGIN";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(72, 205);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(343, 26);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "USERNAME";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(99, 247);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '•';
            this.txtpass.Size = new System.Drawing.Size(294, 29);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "PASSWORD";
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(182, 291);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(122, 36);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.TabStop = false;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.Location = new System.Drawing.Point(182, 345);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(122, 36);
            this.signupbutton.TabIndex = 4;
            this.signupbutton.TabStop = false;
            this.signupbutton.Text = "SIGN UP";
            this.signupbutton.UseVisualStyleBackColor = false;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // loginpanel
            // 
            this.loginpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.loginpanel.Controls.Add(this.signupbutton);
            this.loginpanel.Controls.Add(this.loginbutton);
            this.loginpanel.Controls.Add(this.txtpass);
            this.loginpanel.Controls.Add(this.txtemail);
            this.loginpanel.Controls.Add(this.login);
            this.loginpanel.Controls.Add(this.viewbutton);
            this.loginpanel.Controls.Add(this.hidebutton);
            this.loginpanel.Location = new System.Drawing.Point(2, 2);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(499, 589);
            this.loginpanel.TabIndex = 5;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // viewbutton
            // 
            this.viewbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewbutton.BackColor = System.Drawing.Color.Transparent;
            this.viewbutton.BackgroundImage = global::MyPass.Properties.Resources.viewpass;
            this.viewbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewbutton.Location = new System.Drawing.Point(399, 248);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(30, 28);
            this.viewbutton.TabIndex = 31;
            this.viewbutton.TabStop = false;
            this.viewbutton.UseVisualStyleBackColor = false;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // hidebutton
            // 
            this.hidebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hidebutton.BackColor = System.Drawing.Color.Transparent;
            this.hidebutton.BackgroundImage = global::MyPass.Properties.Resources.hidepass;
            this.hidebutton.Location = new System.Drawing.Point(399, 248);
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.Size = new System.Drawing.Size(30, 28);
            this.hidebutton.TabIndex = 30;
            this.hidebutton.TabStop = false;
            this.hidebutton.UseVisualStyleBackColor = false;
            this.hidebutton.Click += new System.EventHandler(this.hide_Click_1);
            // 
            // signpanel
            // 
            this.signpanel.Controls.Add(this.nextbutton);
            this.signpanel.Controls.Add(this.txtuser);
            this.signpanel.Controls.Add(this.txtpass2);
            this.signpanel.Controls.Add(this.txtemail2);
            this.signpanel.Controls.Add(this.label1);
            this.signpanel.Controls.Add(this.view);
            this.signpanel.Controls.Add(this.button5);
            this.signpanel.Location = new System.Drawing.Point(12, 15);
            this.signpanel.Name = "signpanel";
            this.signpanel.Size = new System.Drawing.Size(470, 557);
            this.signpanel.TabIndex = 6;
            // 
            // nextbutton
            // 
            this.nextbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(173, 422);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(116, 47);
            this.nextbutton.TabIndex = 23;
            this.nextbutton.TabStop = false;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtuser
            // 
            this.txtuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(71, 223);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(328, 30);
            this.txtuser.TabIndex = 22;
            this.txtuser.Text = "USERNAME";
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtuser.UseSystemPasswordChar = true;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass2
            // 
            this.txtpass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass2.BackColor = System.Drawing.Color.White;
            this.txtpass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass2.ForeColor = System.Drawing.Color.Black;
            this.txtpass2.Location = new System.Drawing.Point(71, 353);
            this.txtpass2.Multiline = true;
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.PasswordChar = '•';
            this.txtpass2.Size = new System.Drawing.Size(328, 30);
            this.txtpass2.TabIndex = 21;
            this.txtpass2.Text = "PASSWORD";
            this.txtpass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass2.UseSystemPasswordChar = true;
            this.txtpass2.TextChanged += new System.EventHandler(this.txtpass2_TextChanged);
            this.txtpass2.Enter += new System.EventHandler(this.txtpass2_Enter);
            this.txtpass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass2_KeyDown);
            this.txtpass2.Leave += new System.EventHandler(this.txtpass2_Leave);
            // 
            // txtemail2
            // 
            this.txtemail2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail2.BackColor = System.Drawing.Color.White;
            this.txtemail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail2.ForeColor = System.Drawing.Color.Black;
            this.txtemail2.Location = new System.Drawing.Point(71, 288);
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(328, 24);
            this.txtemail2.TabIndex = 20;
            this.txtemail2.Text = "EMAIL";
            this.txtemail2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemail2.Enter += new System.EventHandler(this.txtemail2_Enter);
            this.txtemail2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail2_KeyDown);
            this.txtemail2.Leave += new System.EventHandler(this.txtemail2_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 73);
            this.label1.TabIndex = 19;
            this.label1.Text = "SIGN UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // view
            // 
            this.view.BackgroundImage = global::MyPass.Properties.Resources.viewpass;
            this.view.Location = new System.Drawing.Point(412, 353);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(30, 32);
            this.view.TabIndex = 28;
            this.view.TabStop = false;
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::MyPass.Properties.Resources.hidepass;
            this.button5.Location = new System.Drawing.Point(412, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 27;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Mypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(491, 587);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.signpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(507, 626);
            this.MinimumSize = new System.Drawing.Size(507, 626);
            this.Name = "Mypass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mypass";
            this.Load += new System.EventHandler(this.Mypass_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mypass_KeyDown);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.signpanel.ResumeLayout(false);
            this.signpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Panel signpanel;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button hidebutton;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Panel loginpanel;
    }
}

