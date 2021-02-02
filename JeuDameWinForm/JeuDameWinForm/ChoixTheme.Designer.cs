namespace JeuDameWinForm
{
    partial class ChoixTheme
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBoo = new System.Windows.Forms.RadioButton();
            this.rbDbz = new System.Windows.Forms.RadioButton();
            this.rbStarWars = new System.Windows.Forms.RadioButton();
            this.rbClassic = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choix du thème à utiliser";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBoo);
            this.groupBox1.Controls.Add(this.rbDbz);
            this.groupBox1.Controls.Add(this.rbStarWars);
            this.groupBox1.Controls.Add(this.rbClassic);
            this.groupBox1.Location = new System.Drawing.Point(199, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbBoo
            // 
            this.rbBoo.AutoSize = true;
            this.rbBoo.Location = new System.Drawing.Point(376, 19);
            this.rbBoo.Name = "rbBoo";
            this.rbBoo.Size = new System.Drawing.Size(102, 17);
            this.rbBoo.TabIndex = 3;
            this.rbBoo.Text = "Dragon Ball Boo";
            this.rbBoo.UseVisualStyleBackColor = true;
            // 
            // rbDbz
            // 
            this.rbDbz.AutoSize = true;
            this.rbDbz.Location = new System.Drawing.Point(267, 19);
            this.rbDbz.Name = "rbDbz";
            this.rbDbz.Size = new System.Drawing.Size(80, 17);
            this.rbDbz.TabIndex = 2;
            this.rbDbz.Text = "Dragon Ball";
            this.rbDbz.UseVisualStyleBackColor = true;
            // 
            // rbStarWars
            // 
            this.rbStarWars.AutoSize = true;
            this.rbStarWars.Location = new System.Drawing.Point(141, 19);
            this.rbStarWars.Name = "rbStarWars";
            this.rbStarWars.Size = new System.Drawing.Size(72, 17);
            this.rbStarWars.TabIndex = 1;
            this.rbStarWars.Text = "Star Wars";
            this.rbStarWars.UseVisualStyleBackColor = true;
            // 
            // rbClassic
            // 
            this.rbClassic.AutoSize = true;
            this.rbClassic.Checked = true;
            this.rbClassic.Location = new System.Drawing.Point(32, 19);
            this.rbClassic.Name = "rbClassic";
            this.rbClassic.Size = new System.Drawing.Size(70, 17);
            this.rbClassic.TabIndex = 0;
            this.rbClassic.TabStop = true;
            this.rbClassic.Text = "Classique";
            this.rbClassic.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(209, 184);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // ChoixTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 242);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ChoixTheme";
            this.Text = "ChoixTheme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStarWars;
        private System.Windows.Forms.RadioButton rbClassic;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rbDbz;
        private System.Windows.Forms.RadioButton rbBoo;
    }
}