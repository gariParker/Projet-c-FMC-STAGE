namespace First_projetFMC
{
    partial class FormChoix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoix));
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.choixpers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ChoixAdmin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Red;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(731, 4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(665, 4);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(214, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(330, 32);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Veuillez choisir votre poste";
            // 
            // choixpers
            // 
            this.choixpers.AnimationHoverSpeed = 0.07F;
            this.choixpers.AnimationSpeed = 0.03F;
            this.choixpers.BackColor = System.Drawing.Color.Transparent;
            this.choixpers.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.choixpers.BorderColor = System.Drawing.Color.Black;
            this.choixpers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.choixpers.CheckedBorderColor = System.Drawing.Color.Black;
            this.choixpers.CheckedForeColor = System.Drawing.Color.White;
            this.choixpers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("choixpers.CheckedImage")));
            this.choixpers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.choixpers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.choixpers.FocusedColor = System.Drawing.Color.Empty;
            this.choixpers.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choixpers.ForeColor = System.Drawing.Color.White;
            this.choixpers.Image = global::First_projetFMC.Properties.Resources.male_user_50px;
            this.choixpers.ImageSize = new System.Drawing.Size(20, 20);
            this.choixpers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.choixpers.Location = new System.Drawing.Point(446, 173);
            this.choixpers.Name = "choixpers";
            this.choixpers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.choixpers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.choixpers.OnHoverForeColor = System.Drawing.Color.White;
            this.choixpers.OnHoverImage = null;
            this.choixpers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.choixpers.OnPressedColor = System.Drawing.Color.Black;
            this.choixpers.Radius = 15;
            this.choixpers.Size = new System.Drawing.Size(203, 42);
            this.choixpers.TabIndex = 3;
            this.choixpers.Text = "Personnel";
            this.choixpers.Click += new System.EventHandler(this.choixpers_Click);
            // 
            // ChoixAdmin
            // 
            this.ChoixAdmin.AnimationHoverSpeed = 0.07F;
            this.ChoixAdmin.AnimationSpeed = 0.03F;
            this.ChoixAdmin.BackColor = System.Drawing.Color.Transparent;
            this.ChoixAdmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ChoixAdmin.BorderColor = System.Drawing.Color.Black;
            this.ChoixAdmin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ChoixAdmin.CheckedBorderColor = System.Drawing.Color.Black;
            this.ChoixAdmin.CheckedForeColor = System.Drawing.Color.White;
            this.ChoixAdmin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ChoixAdmin.CheckedImage")));
            this.ChoixAdmin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ChoixAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChoixAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.ChoixAdmin.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoixAdmin.ForeColor = System.Drawing.Color.White;
            this.ChoixAdmin.Image = global::First_projetFMC.Properties.Resources.admin_settings_male_50px;
            this.ChoixAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.ChoixAdmin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChoixAdmin.Location = new System.Drawing.Point(89, 173);
            this.ChoixAdmin.Name = "ChoixAdmin";
            this.ChoixAdmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChoixAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChoixAdmin.OnHoverForeColor = System.Drawing.Color.White;
            this.ChoixAdmin.OnHoverImage = null;
            this.ChoixAdmin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChoixAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.ChoixAdmin.Radius = 15;
            this.ChoixAdmin.Size = new System.Drawing.Size(203, 42);
            this.ChoixAdmin.TabIndex = 3;
            this.ChoixAdmin.Text = "Administrateurs";
            this.ChoixAdmin.Click += new System.EventHandler(this.ChoixAdmin_Click);
            // 
            // FormChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(786, 315);
            this.Controls.Add(this.choixpers);
            this.Controls.Add(this.ChoixAdmin);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChoix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton ChoixAdmin;
        private Guna.UI.WinForms.GunaAdvenceButton choixpers;
    }
}