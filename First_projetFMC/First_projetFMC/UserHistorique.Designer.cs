namespace First_projetFMC
{
    partial class UserHistorique
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHistorique));
            this.dataGridViewHistoriqueAction = new System.Windows.Forms.DataGridView();
            this.DateDansHistorique = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnHistoHier = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnHistoSemaine = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnHistoJour = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnHistoTous = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnHistoMois = new Guna.UI.WinForms.GunaAdvenceButton();
            this.LogoRafraichirHisto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriqueAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoRafraichirHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoriqueAction
            // 
            this.dataGridViewHistoriqueAction.AllowUserToAddRows = false;
            this.dataGridViewHistoriqueAction.AllowUserToDeleteRows = false;
            this.dataGridViewHistoriqueAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistoriqueAction.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistoriqueAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistoriqueAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHistoriqueAction.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewHistoriqueAction.Location = new System.Drawing.Point(12, 170);
            this.dataGridViewHistoriqueAction.Name = "dataGridViewHistoriqueAction";
            this.dataGridViewHistoriqueAction.ReadOnly = true;
            this.dataGridViewHistoriqueAction.RowHeadersVisible = false;
            this.dataGridViewHistoriqueAction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewHistoriqueAction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistoriqueAction.Size = new System.Drawing.Size(1173, 524);
            this.dataGridViewHistoriqueAction.TabIndex = 36;
            // 
            // DateDansHistorique
            // 
            this.DateDansHistorique.BaseColor = System.Drawing.Color.White;
            this.DateDansHistorique.BorderColor = System.Drawing.Color.Silver;
            this.DateDansHistorique.CustomFormat = null;
            this.DateDansHistorique.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateDansHistorique.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateDansHistorique.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateDansHistorique.ForeColor = System.Drawing.Color.Black;
            this.DateDansHistorique.Location = new System.Drawing.Point(228, 111);
            this.DateDansHistorique.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateDansHistorique.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateDansHistorique.Name = "DateDansHistorique";
            this.DateDansHistorique.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateDansHistorique.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateDansHistorique.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateDansHistorique.OnPressedColor = System.Drawing.Color.Black;
            this.DateDansHistorique.Size = new System.Drawing.Size(223, 30);
            this.DateDansHistorique.TabIndex = 37;
            this.DateDansHistorique.Text = "jeudi 3 août 2023";
            this.DateDansHistorique.Value = new System.DateTime(2023, 8, 3, 10, 45, 13, 136);
            this.DateDansHistorique.ValueChanged += new System.EventHandler(this.DateDansHistorique_ValueChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(18, 111);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(177, 28);
            this.gunaLabel1.TabIndex = 39;
            this.gunaLabel1.Text = "Spécifier la date";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(16, 17);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(177, 43);
            this.gunaLabel2.TabIndex = 40;
            this.gunaLabel2.Text = "Historique";
            // 
            // BtnHistoHier
            // 
            this.BtnHistoHier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnHistoHier.AnimationHoverSpeed = 0.07F;
            this.BtnHistoHier.AnimationSpeed = 0.03F;
            this.BtnHistoHier.BackColor = System.Drawing.Color.Transparent;
            this.BtnHistoHier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.BtnHistoHier.BorderColor = System.Drawing.Color.White;
            this.BtnHistoHier.BorderSize = 2;
            this.BtnHistoHier.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnHistoHier.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnHistoHier.CheckedForeColor = System.Drawing.Color.White;
            this.BtnHistoHier.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnHistoHier.CheckedImage")));
            this.BtnHistoHier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnHistoHier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnHistoHier.FocusedColor = System.Drawing.Color.Empty;
            this.BtnHistoHier.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoHier.ForeColor = System.Drawing.Color.White;
            this.BtnHistoHier.Image = null;
            this.BtnHistoHier.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnHistoHier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoHier.Location = new System.Drawing.Point(451, 700);
            this.BtnHistoHier.Name = "BtnHistoHier";
            this.BtnHistoHier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.BtnHistoHier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHistoHier.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHistoHier.OnHoverImage = null;
            this.BtnHistoHier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoHier.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHistoHier.Radius = 10;
            this.BtnHistoHier.Size = new System.Drawing.Size(180, 47);
            this.BtnHistoHier.TabIndex = 41;
            this.BtnHistoHier.Text = "Hier";
            this.BtnHistoHier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnHistoHier.Click += new System.EventHandler(this.BtnHistoHier_Click);
            // 
            // BtnHistoSemaine
            // 
            this.BtnHistoSemaine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnHistoSemaine.AnimationHoverSpeed = 0.07F;
            this.BtnHistoSemaine.AnimationSpeed = 0.03F;
            this.BtnHistoSemaine.BackColor = System.Drawing.Color.Transparent;
            this.BtnHistoSemaine.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.BtnHistoSemaine.BorderColor = System.Drawing.Color.White;
            this.BtnHistoSemaine.BorderSize = 2;
            this.BtnHistoSemaine.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnHistoSemaine.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnHistoSemaine.CheckedForeColor = System.Drawing.Color.White;
            this.BtnHistoSemaine.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnHistoSemaine.CheckedImage")));
            this.BtnHistoSemaine.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnHistoSemaine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnHistoSemaine.FocusedColor = System.Drawing.Color.Empty;
            this.BtnHistoSemaine.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoSemaine.ForeColor = System.Drawing.Color.White;
            this.BtnHistoSemaine.Image = null;
            this.BtnHistoSemaine.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnHistoSemaine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoSemaine.Location = new System.Drawing.Point(253, 700);
            this.BtnHistoSemaine.Name = "BtnHistoSemaine";
            this.BtnHistoSemaine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.BtnHistoSemaine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHistoSemaine.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHistoSemaine.OnHoverImage = null;
            this.BtnHistoSemaine.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoSemaine.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHistoSemaine.Radius = 10;
            this.BtnHistoSemaine.Size = new System.Drawing.Size(180, 47);
            this.BtnHistoSemaine.TabIndex = 41;
            this.BtnHistoSemaine.Text = "Semaine";
            this.BtnHistoSemaine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnHistoSemaine.Click += new System.EventHandler(this.BtnHistoSemaine_Click);
            // 
            // BtnHistoJour
            // 
            this.BtnHistoJour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnHistoJour.AnimationHoverSpeed = 0.07F;
            this.BtnHistoJour.AnimationSpeed = 0.03F;
            this.BtnHistoJour.BackColor = System.Drawing.Color.Transparent;
            this.BtnHistoJour.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.BtnHistoJour.BorderColor = System.Drawing.Color.White;
            this.BtnHistoJour.BorderSize = 2;
            this.BtnHistoJour.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnHistoJour.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnHistoJour.CheckedForeColor = System.Drawing.Color.White;
            this.BtnHistoJour.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnHistoJour.CheckedImage")));
            this.BtnHistoJour.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnHistoJour.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnHistoJour.FocusedColor = System.Drawing.Color.Empty;
            this.BtnHistoJour.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoJour.ForeColor = System.Drawing.Color.White;
            this.BtnHistoJour.Image = null;
            this.BtnHistoJour.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnHistoJour.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoJour.Location = new System.Drawing.Point(641, 700);
            this.BtnHistoJour.Name = "BtnHistoJour";
            this.BtnHistoJour.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.BtnHistoJour.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHistoJour.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHistoJour.OnHoverImage = null;
            this.BtnHistoJour.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoJour.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHistoJour.Radius = 10;
            this.BtnHistoJour.Size = new System.Drawing.Size(180, 47);
            this.BtnHistoJour.TabIndex = 41;
            this.BtnHistoJour.Text = "Jour";
            this.BtnHistoJour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnHistoJour.Click += new System.EventHandler(this.BtnHistoJour_Click);
            // 
            // BtnHistoTous
            // 
            this.BtnHistoTous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnHistoTous.AnimationHoverSpeed = 0.07F;
            this.BtnHistoTous.AnimationSpeed = 0.03F;
            this.BtnHistoTous.BackColor = System.Drawing.Color.Transparent;
            this.BtnHistoTous.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.BtnHistoTous.BorderColor = System.Drawing.Color.White;
            this.BtnHistoTous.BorderSize = 2;
            this.BtnHistoTous.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnHistoTous.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnHistoTous.CheckedForeColor = System.Drawing.Color.White;
            this.BtnHistoTous.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnHistoTous.CheckedImage")));
            this.BtnHistoTous.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnHistoTous.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnHistoTous.FocusedColor = System.Drawing.Color.Empty;
            this.BtnHistoTous.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoTous.ForeColor = System.Drawing.Color.White;
            this.BtnHistoTous.Image = null;
            this.BtnHistoTous.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnHistoTous.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoTous.Location = new System.Drawing.Point(844, 700);
            this.BtnHistoTous.Name = "BtnHistoTous";
            this.BtnHistoTous.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.BtnHistoTous.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHistoTous.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHistoTous.OnHoverImage = null;
            this.BtnHistoTous.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoTous.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHistoTous.Radius = 10;
            this.BtnHistoTous.Size = new System.Drawing.Size(180, 47);
            this.BtnHistoTous.TabIndex = 41;
            this.BtnHistoTous.Text = "Tous";
            this.BtnHistoTous.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnHistoTous.Click += new System.EventHandler(this.BtnHistoTous_Click);
            // 
            // BtnHistoMois
            // 
            this.BtnHistoMois.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnHistoMois.AnimationHoverSpeed = 0.07F;
            this.BtnHistoMois.AnimationSpeed = 0.03F;
            this.BtnHistoMois.BackColor = System.Drawing.Color.Transparent;
            this.BtnHistoMois.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.BtnHistoMois.BorderColor = System.Drawing.Color.White;
            this.BtnHistoMois.BorderSize = 2;
            this.BtnHistoMois.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnHistoMois.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnHistoMois.CheckedForeColor = System.Drawing.Color.White;
            this.BtnHistoMois.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnHistoMois.CheckedImage")));
            this.BtnHistoMois.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnHistoMois.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnHistoMois.FocusedColor = System.Drawing.Color.Empty;
            this.BtnHistoMois.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistoMois.ForeColor = System.Drawing.Color.White;
            this.BtnHistoMois.Image = null;
            this.BtnHistoMois.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnHistoMois.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoMois.Location = new System.Drawing.Point(42, 700);
            this.BtnHistoMois.Name = "BtnHistoMois";
            this.BtnHistoMois.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.BtnHistoMois.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnHistoMois.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnHistoMois.OnHoverImage = null;
            this.BtnHistoMois.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnHistoMois.OnPressedColor = System.Drawing.Color.Black;
            this.BtnHistoMois.Radius = 10;
            this.BtnHistoMois.Size = new System.Drawing.Size(180, 47);
            this.BtnHistoMois.TabIndex = 41;
            this.BtnHistoMois.Text = "Mois";
            this.BtnHistoMois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnHistoMois.Click += new System.EventHandler(this.BtnHistoMois_Click);
            // 
            // LogoRafraichirHisto
            // 
            this.LogoRafraichirHisto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoRafraichirHisto.Image = global::First_projetFMC.Properties.Resources.refresh_50px;
            this.LogoRafraichirHisto.Location = new System.Drawing.Point(1111, 91);
            this.LogoRafraichirHisto.Name = "LogoRafraichirHisto";
            this.LogoRafraichirHisto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LogoRafraichirHisto.ShadowDecoration.Parent = this.LogoRafraichirHisto;
            this.LogoRafraichirHisto.Size = new System.Drawing.Size(50, 50);
            this.LogoRafraichirHisto.TabIndex = 43;
            this.LogoRafraichirHisto.TabStop = false;
            this.LogoRafraichirHisto.Click += new System.EventHandler(this.LogoRafraichirHisto_Click);
            // 
            // UserHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(70)))), ((int)(((byte)(132)))));
            this.Controls.Add(this.LogoRafraichirHisto);
            this.Controls.Add(this.BtnHistoTous);
            this.Controls.Add(this.BtnHistoJour);
            this.Controls.Add(this.BtnHistoSemaine);
            this.Controls.Add(this.BtnHistoMois);
            this.Controls.Add(this.BtnHistoHier);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DateDansHistorique);
            this.Controls.Add(this.dataGridViewHistoriqueAction);
            this.Name = "UserHistorique";
            this.Size = new System.Drawing.Size(1202, 768);
            this.Load += new System.EventHandler(this.UserHistorique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriqueAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoRafraichirHisto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistoriqueAction;
        private Guna.UI.WinForms.GunaDateTimePicker DateDansHistorique;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton BtnHistoHier;
        private Guna.UI.WinForms.GunaAdvenceButton BtnHistoSemaine;
        private Guna.UI.WinForms.GunaAdvenceButton BtnHistoJour;
        private Guna.UI.WinForms.GunaAdvenceButton BtnHistoTous;
        private Guna.UI.WinForms.GunaAdvenceButton BtnHistoMois;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LogoRafraichirHisto;
    }
}
