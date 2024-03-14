namespace metot
{
    partial class Form1
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
            this.labelDurum = new System.Windows.Forms.Label();
            this.btnAla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAraEkle = new System.Windows.Forms.Button();
            this.listeSehirler = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSehirler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(36, 192);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(37, 13);
            this.labelDurum.TabIndex = 25;
            this.labelDurum.Text = "Dulum";
            // 
            // btnAla
            // 
            this.btnAla.Location = new System.Drawing.Point(363, 100);
            this.btnAla.Name = "btnAla";
            this.btnAla.Size = new System.Drawing.Size(75, 23);
            this.btnAla.TabIndex = 24;
            this.btnAla.Text = "Ala";
            this.btnAla.UseVisualStyleBackColor = true;
            this.btnAla.Click += new System.EventHandler(this.btnAla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(282, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(201, 100);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAraEkle
            // 
            this.btnAraEkle.Location = new System.Drawing.Point(120, 100);
            this.btnAraEkle.Name = "btnAraEkle";
            this.btnAraEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAraEkle.TabIndex = 21;
            this.btnAraEkle.Text = "Araya Ekle";
            this.btnAraEkle.UseVisualStyleBackColor = true;
            this.btnAraEkle.Click += new System.EventHandler(this.btnAraEkle_Click);
            // 
            // listeSehirler
            // 
            this.listeSehirler.FormattingEnabled = true;
            this.listeSehirler.Location = new System.Drawing.Point(485, 15);
            this.listeSehirler.Name = "listeSehirler";
            this.listeSehirler.Size = new System.Drawing.Size(120, 95);
            this.listeSehirler.TabIndex = 20;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(530, 137);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(39, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSehirler
            // 
            this.txtSehirler.Location = new System.Drawing.Point(94, 45);
            this.txtSehirler.Name = "txtSehirler";
            this.txtSehirler.Size = new System.Drawing.Size(100, 20);
            this.txtSehirler.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Şehir Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "sılara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Tersten Sılara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.btnAla);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAraEkle);
            this.Controls.Add(this.listeSehirler);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSehirler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Button btnAla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAraEkle;
        private System.Windows.Forms.ListBox listeSehirler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSehirler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

