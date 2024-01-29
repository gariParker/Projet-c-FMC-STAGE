namespace First_projetFMC
{
    partial class UserAccueil
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
            this.PictureFondEcran = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFondEcran)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureFondEcran
            // 
            this.PictureFondEcran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureFondEcran.BaseColor = System.Drawing.Color.White;
            this.PictureFondEcran.Image = global::First_projetFMC.Properties.Resources.Fond2;
            this.PictureFondEcran.Location = new System.Drawing.Point(0, 0);
            this.PictureFondEcran.Name = "PictureFondEcran";
            this.PictureFondEcran.Size = new System.Drawing.Size(1131, 760);
            this.PictureFondEcran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureFondEcran.TabIndex = 0;
            this.PictureFondEcran.TabStop = false;
            // 
            // UserAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(70)))), ((int)(((byte)(132)))));
            this.Controls.Add(this.PictureFondEcran);
            this.Name = "UserAccueil";
            this.Size = new System.Drawing.Size(1131, 760);
            this.Load += new System.EventHandler(this.UserAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureFondEcran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox PictureFondEcran;
    }
}
