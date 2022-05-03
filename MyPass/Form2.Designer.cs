
namespace MyPass
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.passpanel = new System.Windows.Forms.Panel();
            this.backbutton = new System.Windows.Forms.Button();
            this.PassList = new System.Windows.Forms.ListBox();
            this.MyPassword = new System.Windows.Forms.Label();
            this.addpass = new System.Windows.Forms.Button();
            this.settingspanel = new System.Windows.Forms.Panel();
            this.backbutton1 = new System.Windows.Forms.Button();
            this.userinfo = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.emaillabel1 = new System.Windows.Forms.Label();
            this.userlabel1 = new System.Windows.Forms.Label();
            this.settingslabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.homepanel = new System.Windows.Forms.Panel();
            this.logoutpanel = new System.Windows.Forms.Panel();
            this.settpanel = new System.Windows.Forms.Panel();
            this.passwordpanel = new System.Windows.Forms.Panel();
            this.websitepannel = new System.Windows.Forms.Panel();
            this.passpanel.SuspendLayout();
            this.settingspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.homepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passpanel
            // 
            this.passpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.passpanel.Controls.Add(this.backbutton);
            this.passpanel.Controls.Add(this.PassList);
            this.passpanel.Controls.Add(this.MyPassword);
            this.passpanel.Controls.Add(this.addpass);
            this.passpanel.Location = new System.Drawing.Point(2, 2);
            this.passpanel.Margin = new System.Windows.Forms.Padding(2);
            this.passpanel.Name = "passpanel";
            this.passpanel.Size = new System.Drawing.Size(1187, 689);
            this.passpanel.TabIndex = 1;
            // 
            // backbutton
            // 
            this.backbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.BackgroundImage = global::MyPass.Properties.Resources.icons8_indietro_30__1_;
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backbutton.Location = new System.Drawing.Point(10, 9);
            this.backbutton.Margin = new System.Windows.Forms.Padding(2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(54, 55);
            this.backbutton.TabIndex = 5;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // PassList
            // 
            this.PassList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.PassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassList.ForeColor = System.Drawing.Color.White;
            this.PassList.FormattingEnabled = true;
            this.PassList.ItemHeight = 24;
            this.PassList.Location = new System.Drawing.Point(167, 141);
            this.PassList.Name = "PassList";
            this.PassList.Size = new System.Drawing.Size(826, 436);
            this.PassList.TabIndex = 4;
            this.PassList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MyPassword
            // 
            this.MyPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyPassword.AutoSize = true;
            this.MyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPassword.ForeColor = System.Drawing.Color.White;
            this.MyPassword.Location = new System.Drawing.Point(377, 9);
            this.MyPassword.Name = "MyPassword";
            this.MyPassword.Size = new System.Drawing.Size(389, 55);
            this.MyPassword.TabIndex = 3;
            this.MyPassword.Text = "MY PASSWORD";
            // 
            // addpass
            // 
            this.addpass.BackColor = System.Drawing.Color.Transparent;
            this.addpass.BackgroundImage = global::MyPass.Properties.Resources.icons8_aggiungi_50;
            this.addpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addpass.Location = new System.Drawing.Point(1088, 608);
            this.addpass.Margin = new System.Windows.Forms.Padding(2);
            this.addpass.Name = "addpass";
            this.addpass.Size = new System.Drawing.Size(56, 55);
            this.addpass.TabIndex = 1;
            this.addpass.UseVisualStyleBackColor = false;
            this.addpass.Click += new System.EventHandler(this.addpass_Click_1);
            // 
            // settingspanel
            // 
            this.settingspanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.settingspanel.Controls.Add(this.passpanel);
            this.settingspanel.Controls.Add(this.backbutton1);
            this.settingspanel.Controls.Add(this.userinfo);
            this.settingspanel.Controls.Add(this.emaillabel);
            this.settingspanel.Controls.Add(this.userlabel);
            this.settingspanel.Controls.Add(this.emaillabel1);
            this.settingspanel.Controls.Add(this.userlabel1);
            this.settingspanel.Controls.Add(this.settingslabel);
            this.settingspanel.Location = new System.Drawing.Point(2, 2);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.Size = new System.Drawing.Size(1191, 691);
            this.settingspanel.TabIndex = 2;
            // 
            // backbutton1
            // 
            this.backbutton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backbutton1.BackColor = System.Drawing.Color.Transparent;
            this.backbutton1.BackgroundImage = global::MyPass.Properties.Resources.icons8_indietro_30__1_;
            this.backbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backbutton1.Location = new System.Drawing.Point(10, 10);
            this.backbutton1.Margin = new System.Windows.Forms.Padding(2);
            this.backbutton1.Name = "backbutton1";
            this.backbutton1.Size = new System.Drawing.Size(54, 55);
            this.backbutton1.TabIndex = 6;
            this.backbutton1.UseVisualStyleBackColor = false;
            this.backbutton1.Click += new System.EventHandler(this.backbutton1_Click);
            // 
            // userinfo
            // 
            this.userinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userinfo.AutoSize = true;
            this.userinfo.BackColor = System.Drawing.Color.Transparent;
            this.userinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userinfo.ForeColor = System.Drawing.Color.White;
            this.userinfo.Location = new System.Drawing.Point(516, 148);
            this.userinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userinfo.Name = "userinfo";
            this.userinfo.Size = new System.Drawing.Size(109, 29);
            this.userinfo.TabIndex = 8;
            this.userinfo.Text = "User Info";
            // 
            // emaillabel
            // 
            this.emaillabel.BackColor = System.Drawing.Color.Transparent;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.White;
            this.emaillabel.Location = new System.Drawing.Point(557, 314);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(387, 29);
            this.emaillabel.TabIndex = 6;
            this.emaillabel.Text = "emailaddress";
            this.emaillabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userlabel
            // 
            this.userlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlabel.BackColor = System.Drawing.Color.Transparent;
            this.userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.White;
            this.userlabel.Location = new System.Drawing.Point(554, 265);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(392, 29);
            this.userlabel.TabIndex = 5;
            this.userlabel.Text = "username";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emaillabel1
            // 
            this.emaillabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emaillabel1.AutoSize = true;
            this.emaillabel1.BackColor = System.Drawing.Color.Transparent;
            this.emaillabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel1.ForeColor = System.Drawing.Color.White;
            this.emaillabel1.Location = new System.Drawing.Point(164, 314);
            this.emaillabel1.Name = "emaillabel1";
            this.emaillabel1.Size = new System.Drawing.Size(187, 29);
            this.emaillabel1.TabIndex = 2;
            this.emaillabel1.Text = "Email Addresss:";
            // 
            // userlabel1
            // 
            this.userlabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlabel1.AutoSize = true;
            this.userlabel1.BackColor = System.Drawing.Color.Transparent;
            this.userlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel1.ForeColor = System.Drawing.Color.White;
            this.userlabel1.Location = new System.Drawing.Point(164, 265);
            this.userlabel1.Name = "userlabel1";
            this.userlabel1.Size = new System.Drawing.Size(130, 29);
            this.userlabel1.TabIndex = 1;
            this.userlabel1.Text = "Username:";
            // 
            // settingslabel
            // 
            this.settingslabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingslabel.AutoSize = true;
            this.settingslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingslabel.ForeColor = System.Drawing.Color.White;
            this.settingslabel.Location = new System.Drawing.Point(450, 10);
            this.settingslabel.Name = "settingslabel";
            this.settingslabel.Size = new System.Drawing.Size(263, 55);
            this.settingslabel.TabIndex = 0;
            this.settingslabel.Text = "SETTINGS";
            this.settingslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingslabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // homepanel
            // 
            this.homepanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.homepanel.BackgroundImage = global::MyPass.Properties.Resources.HomeBG3;
            this.homepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homepanel.Controls.Add(this.logoutpanel);
            this.homepanel.Controls.Add(this.settpanel);
            this.homepanel.Controls.Add(this.passwordpanel);
            this.homepanel.Controls.Add(this.websitepannel);
            this.homepanel.Location = new System.Drawing.Point(2, 2);
            this.homepanel.Margin = new System.Windows.Forms.Padding(2);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(1187, 711);
            this.homepanel.TabIndex = 4;
            // 
            // logoutpanel
            // 
            this.logoutpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutpanel.BackColor = System.Drawing.Color.Transparent;
            this.logoutpanel.Location = new System.Drawing.Point(621, 481);
            this.logoutpanel.Name = "logoutpanel";
            this.logoutpanel.Size = new System.Drawing.Size(296, 108);
            this.logoutpanel.TabIndex = 1;
            this.logoutpanel.Click += new System.EventHandler(this.logoutpanel_Click);
            // 
            // settpanel
            // 
            this.settpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settpanel.BackColor = System.Drawing.Color.Transparent;
            this.settpanel.Location = new System.Drawing.Point(621, 291);
            this.settpanel.Name = "settpanel";
            this.settpanel.Size = new System.Drawing.Size(296, 184);
            this.settpanel.TabIndex = 1;
            this.settpanel.Click += new System.EventHandler(this.settpanel_Click);
            // 
            // passwordpanel
            // 
            this.passwordpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordpanel.BackColor = System.Drawing.Color.Transparent;
            this.passwordpanel.Location = new System.Drawing.Point(282, 291);
            this.passwordpanel.Name = "passwordpanel";
            this.passwordpanel.Size = new System.Drawing.Size(320, 298);
            this.passwordpanel.TabIndex = 1;
            this.passwordpanel.Click += new System.EventHandler(this.passwordpanel_Click);
            // 
            // websitepannel
            // 
            this.websitepannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.websitepannel.BackColor = System.Drawing.Color.Transparent;
            this.websitepannel.Location = new System.Drawing.Point(282, 182);
            this.websitepannel.Name = "websitepannel";
            this.websitepannel.Size = new System.Drawing.Size(635, 100);
            this.websitepannel.TabIndex = 0;
            this.websitepannel.Click += new System.EventHandler(this.websitepannel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.homepanel);
            this.Controls.Add(this.settingspanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPass";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.passpanel.ResumeLayout(false);
            this.passpanel.PerformLayout();
            this.settingspanel.ResumeLayout(false);
            this.settingspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.homepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel passpanel;
        private System.Windows.Forms.Panel settingspanel;
        private System.Windows.Forms.Label settingslabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button addpass;
        private System.Windows.Forms.Label MyPassword;
        private System.Windows.Forms.Label userinfo;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label emaillabel1;
        private System.Windows.Forms.Label userlabel1;
        private System.Windows.Forms.ListBox PassList;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button backbutton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Panel logoutpanel;
        private System.Windows.Forms.Panel settpanel;
        private System.Windows.Forms.Panel passwordpanel;
        private System.Windows.Forms.Panel websitepannel;
    }
}