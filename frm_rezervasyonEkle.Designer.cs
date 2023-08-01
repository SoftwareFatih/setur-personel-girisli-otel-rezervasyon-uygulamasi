namespace setur
{
    partial class frm_rezervasyonEkle
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
            this.cb_otel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_musteriSoyadi = new System.Windows.Forms.TextBox();
            this.txt_musteriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_odeme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_personel = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_idBilgi = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_otel
            // 
            this.cb_otel.FormattingEnabled = true;
            this.cb_otel.Location = new System.Drawing.Point(121, 83);
            this.cb_otel.Name = "cb_otel";
            this.cb_otel.Size = new System.Drawing.Size(121, 21);
            this.cb_otel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otel:";
            // 
            // dtp_baslangicTarihi
            // 
            this.dtp_baslangicTarihi.Location = new System.Drawing.Point(121, 110);
            this.dtp_baslangicTarihi.Name = "dtp_baslangicTarihi";
            this.dtp_baslangicTarihi.Size = new System.Drawing.Size(155, 20);
            this.dtp_baslangicTarihi.TabIndex = 2;
            // 
            // txt_musteriSoyadi
            // 
            this.txt_musteriSoyadi.Location = new System.Drawing.Point(121, 57);
            this.txt_musteriSoyadi.Name = "txt_musteriSoyadi";
            this.txt_musteriSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txt_musteriSoyadi.TabIndex = 7;
            // 
            // txt_musteriAdi
            // 
            this.txt_musteriAdi.Location = new System.Drawing.Point(121, 31);
            this.txt_musteriAdi.Name = "txt_musteriAdi";
            this.txt_musteriAdi.Size = new System.Drawing.Size(121, 20);
            this.txt_musteriAdi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Müşteri Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // dtp_bitisTarihi
            // 
            this.dtp_bitisTarihi.Location = new System.Drawing.Point(121, 138);
            this.dtp_bitisTarihi.Name = "dtp_bitisTarihi";
            this.dtp_bitisTarihi.Size = new System.Drawing.Size(155, 20);
            this.dtp_bitisTarihi.TabIndex = 10;
            // 
            // txt_odeme
            // 
            this.txt_odeme.Location = new System.Drawing.Point(121, 168);
            this.txt_odeme.Name = "txt_odeme";
            this.txt_odeme.Size = new System.Drawing.Size(121, 20);
            this.txt_odeme.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ödeme:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Personel:";
            // 
            // cb_personel
            // 
            this.cb_personel.FormattingEnabled = true;
            this.cb_personel.Location = new System.Drawing.Point(121, 194);
            this.cb_personel.Name = "cb_personel";
            this.cb_personel.Size = new System.Drawing.Size(121, 21);
            this.cb_personel.TabIndex = 11;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(121, 237);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(84, 30);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_idBilgi
            // 
            this.lbl_idBilgi.AutoSize = true;
            this.lbl_idBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_idBilgi.Location = new System.Drawing.Point(118, 9);
            this.lbl_idBilgi.Name = "lbl_idBilgi";
            this.lbl_idBilgi.Size = new System.Drawing.Size(18, 13);
            this.lbl_idBilgi.TabIndex = 17;
            this.lbl_idBilgi.Text = "-1";
            this.lbl_idBilgi.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(26, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "ID:";
            this.lbl_id.Visible = false;
            // 
            // frm_rezervasyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 309);
            this.Controls.Add(this.lbl_idBilgi);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_odeme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_personel);
            this.Controls.Add(this.dtp_bitisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_musteriSoyadi);
            this.Controls.Add(this.txt_musteriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dtp_baslangicTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_otel);
            this.Name = "frm_rezervasyonEkle";
            this.Text = "frm_rezervasyonEkle";
            this.Load += new System.EventHandler(this.frm_rezervasyonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_otel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_baslangicTarihi;
        private System.Windows.Forms.TextBox txt_musteriSoyadi;
        private System.Windows.Forms.TextBox txt_musteriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_bitisTarihi;
        private System.Windows.Forms.TextBox txt_odeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_personel;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_idBilgi;
        private System.Windows.Forms.Label lbl_id;
    }
}