namespace JeuDameWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTurn = new System.Windows.Forms.Label();
            this.panelPriseNoir = new System.Windows.Forms.Panel();
            this.panelPriseBlanc = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(380, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 609);
            this.panel1.TabIndex = 0;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.Location = new System.Drawing.Point(587, 9);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(170, 25);
            this.labelTurn.TabIndex = 1;
            this.labelTurn.Text = "Tour du joueur 1";
            // 
            // panelPriseNoir
            // 
            this.panelPriseNoir.Location = new System.Drawing.Point(1040, 148);
            this.panelPriseNoir.Name = "panelPriseNoir";
            this.panelPriseNoir.Size = new System.Drawing.Size(186, 609);
            this.panelPriseNoir.TabIndex = 2;
            // 
            // panelPriseBlanc
            // 
            this.panelPriseBlanc.BackColor = System.Drawing.Color.Transparent;
            this.panelPriseBlanc.Location = new System.Drawing.Point(132, 148);
            this.panelPriseBlanc.Name = "panelPriseBlanc";
            this.panelPriseBlanc.Size = new System.Drawing.Size(180, 609);
            this.panelPriseBlanc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 833);
            this.Controls.Add(this.panelPriseBlanc);
            this.Controls.Add(this.panelPriseNoir);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Panel panelPriseNoir;
        private System.Windows.Forms.Panel panelPriseBlanc;
    }
}

