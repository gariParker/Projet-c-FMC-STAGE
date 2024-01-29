namespace First_projetFMC
{
    partial class ChargementFirstInterface
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
            this.CercleChargement = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CercleChargement
            // 
            this.CercleChargement.FillColor = System.Drawing.Color.Yellow;
            this.CercleChargement.Location = new System.Drawing.Point(38, 67);
            this.CercleChargement.Name = "CercleChargement";
            this.CercleChargement.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CercleChargement.ShadowDecoration.Parent = this.CercleChargement;
            this.CercleChargement.ShowPercentage = true;
            this.CercleChargement.Size = new System.Drawing.Size(196, 179);
            this.CercleChargement.TabIndex = 0;
            this.CercleChargement.ValueChanged += new System.EventHandler(this.CercleChargement_ValueChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(270, 95);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(355, 128);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "F  M  C";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChargementFirstInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(691, 326);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.CercleChargement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChargementFirstInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChargementFirstInterface";
            this.Load += new System.EventHandler(this.ChargementFirstInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar CercleChargement;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}