namespace SOHATS
{
    partial class Rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTaburcuOlmus = new System.Windows.Forms.RadioButton();
            this.rbTaburcuOlmamis = new System.Windows.Forms.RadioButton();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dgwHasta = new System.Windows.Forms.DataGridView();
            this.dosyano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevktarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktoradi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorsoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnOnizleme = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // rbTaburcuOlmus
            // 
            this.rbTaburcuOlmus.AutoSize = true;
            this.rbTaburcuOlmus.Location = new System.Drawing.Point(406, 12);
            this.rbTaburcuOlmus.Name = "rbTaburcuOlmus";
            this.rbTaburcuOlmus.Size = new System.Drawing.Size(199, 33);
            this.rbTaburcuOlmus.TabIndex = 3;
            this.rbTaburcuOlmus.TabStop = true;
            this.rbTaburcuOlmus.Text = "Taburcu Olmuş";
            this.rbTaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmamis
            // 
            this.rbTaburcuOlmamis.AutoSize = true;
            this.rbTaburcuOlmamis.Location = new System.Drawing.Point(406, 52);
            this.rbTaburcuOlmamis.Name = "rbTaburcuOlmamis";
            this.rbTaburcuOlmamis.Size = new System.Drawing.Size(225, 33);
            this.rbTaburcuOlmamis.TabIndex = 4;
            this.rbTaburcuOlmamis.TabStop = true;
            this.rbTaburcuOlmamis.Text = "Taburcu Olmamış";
            this.rbTaburcuOlmamis.UseVisualStyleBackColor = true;
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Location = new System.Drawing.Point(406, 92);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(97, 33);
            this.rbHepsi.TabIndex = 5;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSorgula.Location = new System.Drawing.Point(622, 12);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(108, 108);
            this.btnSorgula.TabIndex = 6;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTemizle.Location = new System.Drawing.Point(736, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 108);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYazdir.Location = new System.Drawing.Point(856, 12);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(105, 108);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCikis.Location = new System.Drawing.Point(1081, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(110, 108);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dgwHasta
            // 
            this.dgwHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dosyano,
            this.ad,
            this.soyad,
            this.sevktarihi,
            this.poliklinik,
            this.doktoradi,
            this.doktorsoyadi});
            this.dgwHasta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwHasta.Location = new System.Drawing.Point(0, 138);
            this.dgwHasta.Name = "dgwHasta";
            this.dgwHasta.RowHeadersWidth = 51;
            this.dgwHasta.Size = new System.Drawing.Size(1203, 420);
            this.dgwHasta.TabIndex = 11;
            // 
            // dosyano
            // 
            this.dosyano.HeaderText = "Dosya No";
            this.dosyano.MinimumWidth = 6;
            this.dosyano.Name = "dosyano";
            // 
            // ad
            // 
            this.ad.HeaderText = "Ad";
            this.ad.MinimumWidth = 6;
            this.ad.Name = "ad";
            // 
            // soyad
            // 
            this.soyad.HeaderText = "Soyad";
            this.soyad.MinimumWidth = 6;
            this.soyad.Name = "soyad";
            // 
            // sevktarihi
            // 
            this.sevktarihi.HeaderText = "Sevk Tarihi";
            this.sevktarihi.MinimumWidth = 6;
            this.sevktarihi.Name = "sevktarihi";
            // 
            // poliklinik
            // 
            this.poliklinik.HeaderText = "Poliklinik";
            this.poliklinik.MinimumWidth = 6;
            this.poliklinik.Name = "poliklinik";
            // 
            // doktoradi
            // 
            this.doktoradi.HeaderText = "Doktor Adı";
            this.doktoradi.MinimumWidth = 6;
            this.doktoradi.Name = "doktoradi";
            // 
            // doktorsoyadi
            // 
            this.doktorsoyadi.HeaderText = "Doktor Soyadi";
            this.doktorsoyadi.MinimumWidth = 6;
            this.doktorsoyadi.Name = "doktorsoyadi";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(188, 27);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(209, 34);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(188, 75);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(210, 34);
            this.dtpBitis.TabIndex = 2;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnOnizleme
            // 
            this.btnOnizleme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOnizleme.Location = new System.Drawing.Point(967, 12);
            this.btnOnizleme.Name = "btnOnizleme";
            this.btnOnizleme.Size = new System.Drawing.Size(108, 108);
            this.btnOnizleme.TabIndex = 9;
            this.btnOnizleme.Text = "Baskı\r\nÖnizle";
            this.btnOnizleme.UseVisualStyleBackColor = false;
            this.btnOnizleme.Click += new System.EventHandler(this.btnOnizleme_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 558);
            this.Controls.Add(this.btnOnizleme);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dgwHasta);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.rbHepsi);
            this.Controls.Add(this.rbTaburcuOlmamis);
            this.Controls.Add(this.rbTaburcuOlmus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taburcu";
            ((System.ComponentModel.ISupportInitialize)(this.dgwHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTaburcuOlmus;
        private System.Windows.Forms.RadioButton rbTaburcuOlmamis;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dgwHasta;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevktarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoradi;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorsoyadi;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnOnizleme;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}