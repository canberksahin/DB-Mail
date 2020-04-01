namespace Mesajlasma
{
    partial class MesajDetay
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
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblGonderen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı :";
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(110, 43);
            this.lblAlici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(51, 20);
            this.lblAlici.TabIndex = 1;
            this.lblAlici.Text = "label2";
            // 
            // lblGonderen
            // 
            this.lblGonderen.AutoSize = true;
            this.lblGonderen.Location = new System.Drawing.Point(110, 9);
            this.lblGonderen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGonderen.Name = "lblGonderen";
            this.lblGonderen.Size = new System.Drawing.Size(51, 20);
            this.lblGonderen.TabIndex = 3;
            this.lblGonderen.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gönderen :";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(110, 75);
            this.lblKonu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(51, 20);
            this.lblKonu.TabIndex = 5;
            this.lblKonu.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Konu :";
            // 
            // rtxtMesaj
            // 
            this.rtxtMesaj.Location = new System.Drawing.Point(17, 105);
            this.rtxtMesaj.Name = "rtxtMesaj";
            this.rtxtMesaj.ReadOnly = true;
            this.rtxtMesaj.Size = new System.Drawing.Size(261, 180);
            this.rtxtMesaj.TabIndex = 7;
            this.rtxtMesaj.Text = "";
            // 
            // MesajDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 315);
            this.Controls.Add(this.rtxtMesaj);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGonderen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlici);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MesajDetay";
            this.Text = "Mesaj Detay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblGonderen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtMesaj;
    }
}