namespace AracKiralamaSistemi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.txtAracMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.dateTimeTeslim = new System.Windows.Forms.DateTimePicker();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.dateTimeKiralama = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboArac = new System.Windows.Forms.ComboBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silBtn = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAracEkle);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.txtAracModel);
            this.groupBox1.Controls.Add(this.txtAracMarka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAÇ EKLE";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(85, 134);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(86, 37);
            this.btnAracEkle.TabIndex = 6;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(56, 94);
            this.txtPlaka.Multiline = true;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(115, 21);
            this.txtPlaka.TabIndex = 5;
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(56, 62);
            this.txtAracModel.Multiline = true;
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(115, 21);
            this.txtAracModel.TabIndex = 4;
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Location = new System.Drawing.Point(56, 32);
            this.txtAracMarka.Multiline = true;
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Size = new System.Drawing.Size(115, 21);
            this.txtAracMarka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.silBtn);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.dateTimeTeslim);
            this.groupBox2.Controls.Add(this.btnKiralama);
            this.groupBox2.Controls.Add(this.dateTimeKiralama);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboArac);
            this.groupBox2.Controls.Add(this.txtMusteri);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(296, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAÇ KİRALA";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(275, 32);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(115, 21);
            this.txtTelefon.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefon:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(290, 127);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(86, 37);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dateTimeTeslim
            // 
            this.dateTimeTeslim.Location = new System.Drawing.Point(95, 127);
            this.dateTimeTeslim.Name = "dateTimeTeslim";
            this.dateTimeTeslim.Size = new System.Drawing.Size(171, 20);
            this.dateTimeTeslim.TabIndex = 10;
            // 
            // btnKiralama
            // 
            this.btnKiralama.Location = new System.Drawing.Point(290, 85);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(86, 37);
            this.btnKiralama.TabIndex = 6;
            this.btnKiralama.Text = "Araç Kirala";
            this.btnKiralama.UseVisualStyleBackColor = true;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // dateTimeKiralama
            // 
            this.dateTimeKiralama.Location = new System.Drawing.Point(96, 94);
            this.dateTimeKiralama.Name = "dateTimeKiralama";
            this.dateTimeKiralama.Size = new System.Drawing.Size(171, 20);
            this.dateTimeKiralama.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Teslim Tarihi:";
            // 
            // comboArac
            // 
            this.comboArac.FormattingEnabled = true;
            this.comboArac.Location = new System.Drawing.Point(95, 62);
            this.comboArac.Name = "comboArac";
            this.comboArac.Size = new System.Drawing.Size(115, 21);
            this.comboArac.TabIndex = 7;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(95, 32);
            this.txtMusteri.Multiline = true;
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(115, 21);
            this.txtMusteri.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kiralama Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Araç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 229);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(388, 85);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(86, 37);
            this.silBtn.TabIndex = 14;
            this.silBtn.Text = "Kira Kaydı Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(388, 127);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 37);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Kira Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAracMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboArac;
        private System.Windows.Forms.Button btnKiralama;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeTeslim;
        private System.Windows.Forms.DateTimePicker dateTimeKiralama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

