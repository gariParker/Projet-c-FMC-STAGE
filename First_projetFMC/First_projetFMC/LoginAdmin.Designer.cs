namespace First_projetFMC
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.TextBoxNameAdmin = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxMdpAdmin = new Guna.UI.WinForms.GunaTextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.BtnAnnulerAdmin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SeConnectAdministrateur = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblIncorrecte = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(80, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(283, 47);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Authentification";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(428, 100);
            this.gunaGradient2Panel1.TabIndex = 2;
            // 
            // TextBoxNameAdmin
            // 
            this.TextBoxNameAdmin.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxNameAdmin.BaseColor = System.Drawing.Color.White;
            this.TextBoxNameAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.TextBoxNameAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNameAdmin.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxNameAdmin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxNameAdmin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxNameAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxNameAdmin.Location = new System.Drawing.Point(88, 275);
            this.TextBoxNameAdmin.Name = "TextBoxNameAdmin";
            this.TextBoxNameAdmin.PasswordChar = '\0';
            this.TextBoxNameAdmin.Radius = 10;
            this.TextBoxNameAdmin.SelectedText = "";
            this.TextBoxNameAdmin.Size = new System.Drawing.Size(265, 48);
            this.TextBoxNameAdmin.TabIndex = 3;
            this.TextBoxNameAdmin.MouseLeave += new System.EventHandler(this.TextBoxNameAdmin_MouseLeave);
            this.TextBoxNameAdmin.MouseHover += new System.EventHandler(this.TextBoxNameAdmin_MouseHover);
            // 
            // TextBoxMdpAdmin
            // 
            this.TextBoxMdpAdmin.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxMdpAdmin.BaseColor = System.Drawing.Color.White;
            this.TextBoxMdpAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.TextBoxMdpAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMdpAdmin.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxMdpAdmin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxMdpAdmin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxMdpAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMdpAdmin.Location = new System.Drawing.Point(88, 342);
            this.TextBoxMdpAdmin.Name = "TextBoxMdpAdmin";
            this.TextBoxMdpAdmin.PasswordChar = '*';
            this.TextBoxMdpAdmin.Radius = 10;
            this.TextBoxMdpAdmin.SelectedText = "";
            this.TextBoxMdpAdmin.Size = new System.Drawing.Size(265, 48);
            this.TextBoxMdpAdmin.TabIndex = 3;
            this.TextBoxMdpAdmin.MouseLeave += new System.EventHandler(this.TextBoxMdpAdmin_MouseLeave);
            this.TextBoxMdpAdmin.MouseHover += new System.EventHandler(this.TextBoxMdpAdmin_MouseHover);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::First_projetFMC.Properties.Resources.User_LockedMpd2_50px;
            this.guna2PictureBox2.Location = new System.Drawing.Point(27, 345);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(51, 37);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::First_projetFMC.Properties.Resources.userfmc_50px;
            this.gunaPictureBox1.Location = new System.Drawing.Point(24, 279);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(53, 37);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 6;
            this.gunaPictureBox1.TabStop = false;
            // 
            // BtnAnnulerAdmin
            // 
            this.BtnAnnulerAdmin.AnimationHoverSpeed = 0.07F;
            this.BtnAnnulerAdmin.AnimationSpeed = 0.03F;
            this.BtnAnnulerAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnnulerAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAnnulerAdmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.BtnAnnulerAdmin.BorderColor = System.Drawing.Color.Black;
            this.BtnAnnulerAdmin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnAnnulerAdmin.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnAnnulerAdmin.CheckedForeColor = System.Drawing.Color.White;
            this.BtnAnnulerAdmin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnAnnulerAdmin.CheckedImage")));
            this.BtnAnnulerAdmin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnAnnulerAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAnnulerAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAnnulerAdmin.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAnnulerAdmin.Image = global::First_projetFMC.Properties.Resources.cross_mark_button_50px;
            this.BtnAnnulerAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAnnulerAdmin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAnnulerAdmin.Location = new System.Drawing.Point(31, 445);
            this.BtnAnnulerAdmin.Name = "BtnAnnulerAdmin";
            this.BtnAnnulerAdmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAnnulerAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAnnulerAdmin.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAnnulerAdmin.OnHoverImage = null;
            this.BtnAnnulerAdmin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnAnnulerAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAnnulerAdmin.Radius = 15;
            this.BtnAnnulerAdmin.Size = new System.Drawing.Size(159, 48);
            this.BtnAnnulerAdmin.TabIndex = 5;
            this.BtnAnnulerAdmin.Text = "Annuler";
            this.BtnAnnulerAdmin.Click += new System.EventHandler(this.BtnAnnulerAdmin_Click);
            // 
            // SeConnectAdministrateur
            // 
            this.SeConnectAdministrateur.AnimationHoverSpeed = 0.07F;
            this.SeConnectAdministrateur.AnimationSpeed = 0.03F;
            this.SeConnectAdministrateur.BackColor = System.Drawing.Color.Transparent;
            this.SeConnectAdministrateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SeConnectAdministrateur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.SeConnectAdministrateur.BorderColor = System.Drawing.Color.Black;
            this.SeConnectAdministrateur.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SeConnectAdministrateur.CheckedBorderColor = System.Drawing.Color.Black;
            this.SeConnectAdministrateur.CheckedForeColor = System.Drawing.Color.White;
            this.SeConnectAdministrateur.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SeConnectAdministrateur.CheckedImage")));
            this.SeConnectAdministrateur.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SeConnectAdministrateur.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SeConnectAdministrateur.FocusedColor = System.Drawing.Color.Empty;
            this.SeConnectAdministrateur.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeConnectAdministrateur.ForeColor = System.Drawing.Color.White;
            this.SeConnectAdministrateur.Image = global::First_projetFMC.Properties.Resources.enter2_50px;
            this.SeConnectAdministrateur.ImageSize = new System.Drawing.Size(20, 20);
            this.SeConnectAdministrateur.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SeConnectAdministrateur.Location = new System.Drawing.Point(243, 448);
            this.SeConnectAdministrateur.Name = "SeConnectAdministrateur";
            this.SeConnectAdministrateur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SeConnectAdministrateur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SeConnectAdministrateur.OnHoverForeColor = System.Drawing.Color.White;
            this.SeConnectAdministrateur.OnHoverImage = null;
            this.SeConnectAdministrateur.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SeConnectAdministrateur.OnPressedColor = System.Drawing.Color.Black;
            this.SeConnectAdministrateur.Radius = 15;
            this.SeConnectAdministrateur.Size = new System.Drawing.Size(159, 48);
            this.SeConnectAdministrateur.TabIndex = 5;
            this.SeConnectAdministrateur.Text = "Se connecter";
            this.SeConnectAdministrateur.Click += new System.EventHandler(this.SeConnectAdministrateur_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::First_projetFMC.Properties.Resources.user_shield_100px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(149, 123);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(139, 119);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LblIncorrecte
            // 
            this.LblIncorrecte.AutoSize = true;
            this.LblIncorrecte.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncorrecte.ForeColor = System.Drawing.Color.Red;
            this.LblIncorrecte.Location = new System.Drawing.Point(76, 402);
            this.LblIncorrecte.Name = "LblIncorrecte";
            this.LblIncorrecte.Size = new System.Drawing.Size(0, 28);
            this.LblIncorrecte.TabIndex = 2;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 519);
            this.Controls.Add(this.LblIncorrecte);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.BtnAnnulerAdmin);
            this.Controls.Add(this.SeConnectAdministrateur);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.TextBoxMdpAdmin);
            this.Controls.Add(this.TextBoxNameAdmin);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAdmin";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaTextBox TextBoxNameAdmin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaTextBox TextBoxMdpAdmin;
        private Guna.UI.WinForms.GunaAdvenceButton SeConnectAdministrateur;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAnnulerAdmin;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI.WinForms.GunaLabel LblIncorrecte;
    }
}