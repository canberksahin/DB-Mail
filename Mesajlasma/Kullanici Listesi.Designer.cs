namespace Mesajlasma
{
    partial class Kullanici_Listesi
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
            this.dgvKisiListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKisiListesi
            // 
            this.dgvKisiListesi.AllowUserToAddRows = false;
            this.dgvKisiListesi.AllowUserToDeleteRows = false;
            this.dgvKisiListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKisiListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKisiListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKisiListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvKisiListesi.Name = "dgvKisiListesi";
            this.dgvKisiListesi.ReadOnly = true;
            this.dgvKisiListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKisiListesi.Size = new System.Drawing.Size(386, 306);
            this.dgvKisiListesi.TabIndex = 0;
            // 
            // Kullanici_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 306);
            this.Controls.Add(this.dgvKisiListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kullanici_Listesi";
            this.Text = "Kullanici Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKisiListesi;
    }
}