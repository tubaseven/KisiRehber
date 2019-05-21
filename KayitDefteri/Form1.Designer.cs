namespace KayitDefteri
{
    partial class FrmKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_yeniSoyad;
            this.grp_yeniKisi = new System.Windows.Forms.GroupBox();
            this.rch_yeniAdres = new System.Windows.Forms.RichTextBox();
            this.btn_yeniIptal = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_yeniTel = new System.Windows.Forms.TextBox();
            this.txt_yeniSoyad = new System.Windows.Forms.TextBox();
            this.txt_yeniAd = new System.Windows.Forms.TextBox();
            this.lbl_yeniAdres = new System.Windows.Forms.Label();
            this.lbl_yeniTel = new System.Windows.Forms.Label();
            this.lbl_yeniAd = new System.Windows.Forms.Label();
            this.lst_Liste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_Guncelle = new System.Windows.Forms.GroupBox();
            this.rch_gncAdres = new System.Windows.Forms.RichTextBox();
            this.btn_gncIptal = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.txt_gncTel = new System.Windows.Forms.TextBox();
            this.txt_gncSoyad = new System.Windows.Forms.TextBox();
            this.txt_gncAd = new System.Windows.Forms.TextBox();
            this.lbl_gncAdres = new System.Windows.Forms.Label();
            this.lbl_gncTel = new System.Windows.Forms.Label();
            this.lbl_gncSoyad = new System.Windows.Forms.Label();
            this.lbl_gncAd = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lbl_yeniSoyad = new System.Windows.Forms.Label();
            this.grp_yeniKisi.SuspendLayout();
            this.grp_Guncelle.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_yeniSoyad
            // 
            lbl_yeniSoyad.AutoSize = true;
            lbl_yeniSoyad.Location = new System.Drawing.Point(24, 82);
            lbl_yeniSoyad.Name = "lbl_yeniSoyad";
            lbl_yeniSoyad.Size = new System.Drawing.Size(48, 17);
            lbl_yeniSoyad.TabIndex = 0;
            lbl_yeniSoyad.Text = "Soyad";
            // 
            // grp_yeniKisi
            // 
            this.grp_yeniKisi.Controls.Add(this.rch_yeniAdres);
            this.grp_yeniKisi.Controls.Add(this.btn_yeniIptal);
            this.grp_yeniKisi.Controls.Add(this.btn_Ekle);
            this.grp_yeniKisi.Controls.Add(this.txt_yeniTel);
            this.grp_yeniKisi.Controls.Add(this.txt_yeniSoyad);
            this.grp_yeniKisi.Controls.Add(this.txt_yeniAd);
            this.grp_yeniKisi.Controls.Add(this.lbl_yeniAdres);
            this.grp_yeniKisi.Controls.Add(this.lbl_yeniTel);
            this.grp_yeniKisi.Controls.Add(lbl_yeniSoyad);
            this.grp_yeniKisi.Controls.Add(this.lbl_yeniAd);
            this.grp_yeniKisi.Location = new System.Drawing.Point(12, 12);
            this.grp_yeniKisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_yeniKisi.Name = "grp_yeniKisi";
            this.grp_yeniKisi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_yeniKisi.Size = new System.Drawing.Size(425, 324);
            this.grp_yeniKisi.TabIndex = 0;
            this.grp_yeniKisi.TabStop = false;
            this.grp_yeniKisi.Text = "Yeni Kişi";
            // 
            // rch_yeniAdres
            // 
            this.rch_yeniAdres.Location = new System.Drawing.Point(113, 154);
            this.rch_yeniAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rch_yeniAdres.Name = "rch_yeniAdres";
            this.rch_yeniAdres.Size = new System.Drawing.Size(199, 98);
            this.rch_yeniAdres.TabIndex = 3;
            this.rch_yeniAdres.Text = "";
            // 
            // btn_yeniIptal
            // 
            this.btn_yeniIptal.Location = new System.Drawing.Point(228, 273);
            this.btn_yeniIptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_yeniIptal.Name = "btn_yeniIptal";
            this.btn_yeniIptal.Size = new System.Drawing.Size(100, 28);
            this.btn_yeniIptal.TabIndex = 2;
            this.btn_yeniIptal.Text = "İptal";
            this.btn_yeniIptal.UseVisualStyleBackColor = true;
            this.btn_yeniIptal.Click += new System.EventHandler(this.btn_yeniIptal_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(99, 273);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_yeniTel
            // 
            this.txt_yeniTel.Location = new System.Drawing.Point(113, 117);
            this.txt_yeniTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_yeniTel.Name = "txt_yeniTel";
            this.txt_yeniTel.Size = new System.Drawing.Size(199, 22);
            this.txt_yeniTel.TabIndex = 1;
            // 
            // txt_yeniSoyad
            // 
            this.txt_yeniSoyad.Location = new System.Drawing.Point(113, 82);
            this.txt_yeniSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_yeniSoyad.Name = "txt_yeniSoyad";
            this.txt_yeniSoyad.Size = new System.Drawing.Size(199, 22);
            this.txt_yeniSoyad.TabIndex = 1;
            // 
            // txt_yeniAd
            // 
            this.txt_yeniAd.Location = new System.Drawing.Point(113, 48);
            this.txt_yeniAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_yeniAd.Name = "txt_yeniAd";
            this.txt_yeniAd.Size = new System.Drawing.Size(199, 22);
            this.txt_yeniAd.TabIndex = 1;
            // 
            // lbl_yeniAdres
            // 
            this.lbl_yeniAdres.AutoSize = true;
            this.lbl_yeniAdres.Location = new System.Drawing.Point(28, 158);
            this.lbl_yeniAdres.Name = "lbl_yeniAdres";
            this.lbl_yeniAdres.Size = new System.Drawing.Size(45, 17);
            this.lbl_yeniAdres.TabIndex = 0;
            this.lbl_yeniAdres.Text = "Adres";
            // 
            // lbl_yeniTel
            // 
            this.lbl_yeniTel.AutoSize = true;
            this.lbl_yeniTel.Location = new System.Drawing.Point(24, 121);
            this.lbl_yeniTel.Name = "lbl_yeniTel";
            this.lbl_yeniTel.Size = new System.Drawing.Size(56, 17);
            this.lbl_yeniTel.TabIndex = 0;
            this.lbl_yeniTel.Text = "Telefon";
            // 
            // lbl_yeniAd
            // 
            this.lbl_yeniAd.AutoSize = true;
            this.lbl_yeniAd.Location = new System.Drawing.Point(28, 48);
            this.lbl_yeniAd.Name = "lbl_yeniAd";
            this.lbl_yeniAd.Size = new System.Drawing.Size(25, 17);
            this.lbl_yeniAd.TabIndex = 0;
            this.lbl_yeniAd.Text = "Ad";
            // 
            // lst_Liste
            // 
            this.lst_Liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_Liste.FullRowSelect = true;
            this.lst_Liste.Location = new System.Drawing.Point(40, 366);
            this.lst_Liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_Liste.Name = "lst_Liste";
            this.lst_Liste.Size = new System.Drawing.Size(869, 182);
            this.lst_Liste.TabIndex = 1;
            this.lst_Liste.UseCompatibleStateImageBehavior = false;
            this.lst_Liste.View = System.Windows.Forms.View.Details;
            this.lst_Liste.SelectedIndexChanged += new System.EventHandler(this.lst_Liste_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 277;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 328;
            // 
            // grp_Guncelle
            // 
            this.grp_Guncelle.Controls.Add(this.rch_gncAdres);
            this.grp_Guncelle.Controls.Add(this.btn_gncIptal);
            this.grp_Guncelle.Controls.Add(this.btn_Guncelle);
            this.grp_Guncelle.Controls.Add(this.txt_gncTel);
            this.grp_Guncelle.Controls.Add(this.txt_gncSoyad);
            this.grp_Guncelle.Controls.Add(this.txt_gncAd);
            this.grp_Guncelle.Controls.Add(this.lbl_gncAdres);
            this.grp_Guncelle.Controls.Add(this.lbl_gncTel);
            this.grp_Guncelle.Controls.Add(this.lbl_gncSoyad);
            this.grp_Guncelle.Controls.Add(this.lbl_gncAd);
            this.grp_Guncelle.Location = new System.Drawing.Point(488, 14);
            this.grp_Guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_Guncelle.Name = "grp_Guncelle";
            this.grp_Guncelle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_Guncelle.Size = new System.Drawing.Size(440, 322);
            this.grp_Guncelle.TabIndex = 0;
            this.grp_Guncelle.TabStop = false;
            this.grp_Guncelle.Text = "Kişi Güncelle";
            // 
            // rch_gncAdres
            // 
            this.rch_gncAdres.Location = new System.Drawing.Point(113, 158);
            this.rch_gncAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rch_gncAdres.Name = "rch_gncAdres";
            this.rch_gncAdres.Size = new System.Drawing.Size(199, 98);
            this.rch_gncAdres.TabIndex = 3;
            this.rch_gncAdres.Text = "";
            // 
            // btn_gncIptal
            // 
            this.btn_gncIptal.Location = new System.Drawing.Point(239, 273);
            this.btn_gncIptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_gncIptal.Name = "btn_gncIptal";
            this.btn_gncIptal.Size = new System.Drawing.Size(100, 28);
            this.btn_gncIptal.TabIndex = 2;
            this.btn_gncIptal.Text = "İptal";
            this.btn_gncIptal.UseVisualStyleBackColor = true;
            this.btn_gncIptal.Click += new System.EventHandler(this.btn_gncIptal_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(97, 273);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(100, 28);
            this.btn_Guncelle.TabIndex = 2;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // txt_gncTel
            // 
            this.txt_gncTel.Location = new System.Drawing.Point(113, 117);
            this.txt_gncTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gncTel.Name = "txt_gncTel";
            this.txt_gncTel.Size = new System.Drawing.Size(199, 22);
            this.txt_gncTel.TabIndex = 1;
            // 
            // txt_gncSoyad
            // 
            this.txt_gncSoyad.Location = new System.Drawing.Point(113, 82);
            this.txt_gncSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gncSoyad.Name = "txt_gncSoyad";
            this.txt_gncSoyad.Size = new System.Drawing.Size(199, 22);
            this.txt_gncSoyad.TabIndex = 1;
            // 
            // txt_gncAd
            // 
            this.txt_gncAd.Location = new System.Drawing.Point(113, 48);
            this.txt_gncAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gncAd.Name = "txt_gncAd";
            this.txt_gncAd.Size = new System.Drawing.Size(199, 22);
            this.txt_gncAd.TabIndex = 1;
            // 
            // lbl_gncAdres
            // 
            this.lbl_gncAdres.AutoSize = true;
            this.lbl_gncAdres.Location = new System.Drawing.Point(20, 149);
            this.lbl_gncAdres.Name = "lbl_gncAdres";
            this.lbl_gncAdres.Size = new System.Drawing.Size(45, 17);
            this.lbl_gncAdres.TabIndex = 0;
            this.lbl_gncAdres.Text = "Adres";
            // 
            // lbl_gncTel
            // 
            this.lbl_gncTel.AutoSize = true;
            this.lbl_gncTel.Location = new System.Drawing.Point(20, 117);
            this.lbl_gncTel.Name = "lbl_gncTel";
            this.lbl_gncTel.Size = new System.Drawing.Size(56, 17);
            this.lbl_gncTel.TabIndex = 0;
            this.lbl_gncTel.Text = "Telefon";
            // 
            // lbl_gncSoyad
            // 
            this.lbl_gncSoyad.AutoSize = true;
            this.lbl_gncSoyad.Location = new System.Drawing.Point(20, 82);
            this.lbl_gncSoyad.Name = "lbl_gncSoyad";
            this.lbl_gncSoyad.Size = new System.Drawing.Size(48, 17);
            this.lbl_gncSoyad.TabIndex = 0;
            this.lbl_gncSoyad.Text = "Soyad";
            // 
            // lbl_gncAd
            // 
            this.lbl_gncAd.AutoSize = true;
            this.lbl_gncAd.Location = new System.Drawing.Point(20, 48);
            this.lbl_gncAd.Name = "lbl_gncAd";
            this.lbl_gncAd.Size = new System.Drawing.Size(25, 17);
            this.lbl_gncAd.TabIndex = 0;
            this.lbl_gncAd.Text = "Ad";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.SilToolStripMenuItem_Click);
            // 
            // FrmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 608);
            this.Controls.Add(this.lst_Liste);
            this.Controls.Add(this.grp_Guncelle);
            this.Controls.Add(this.grp_yeniKisi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKayit";
            this.Text = "Form1";
            this.grp_yeniKisi.ResumeLayout(false);
            this.grp_yeniKisi.PerformLayout();
            this.grp_Guncelle.ResumeLayout(false);
            this.grp_Guncelle.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_yeniKisi;
        private System.Windows.Forms.TextBox txt_yeniTel;
        private System.Windows.Forms.TextBox txt_yeniSoyad;
        private System.Windows.Forms.TextBox txt_yeniAd;
        private System.Windows.Forms.Label lbl_yeniAdres;
        private System.Windows.Forms.Label lbl_yeniTel;
        private System.Windows.Forms.Label lbl_yeniAd;
        private System.Windows.Forms.ListView lst_Liste;
        private System.Windows.Forms.GroupBox grp_Guncelle;
        private System.Windows.Forms.TextBox txt_gncTel;
        private System.Windows.Forms.TextBox txt_gncSoyad;
        private System.Windows.Forms.TextBox txt_gncAd;
        private System.Windows.Forms.Label lbl_gncAdres;
        private System.Windows.Forms.Label lbl_gncTel;
        private System.Windows.Forms.Label lbl_gncSoyad;
        private System.Windows.Forms.Label lbl_gncAd;
        private System.Windows.Forms.Button btn_yeniIptal;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_gncIptal;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.RichTextBox rch_gncAdres;
        private System.Windows.Forms.RichTextBox rch_yeniAdres;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

