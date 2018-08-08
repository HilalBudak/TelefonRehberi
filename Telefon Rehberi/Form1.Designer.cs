namespace Deneme_11
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKisiNo = new System.Windows.Forms.TextBox();
            this.txtkisiaciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dteDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEgitimDurumlari = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbsektor = new System.Windows.Forms.ComboBox();
            this.lblsektor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtad.Location = new System.Drawing.Point(98, 52);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(169, 20);
            this.txtad.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(98, 78);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(169, 20);
            this.txtsoyad.TabIndex = 3;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(314, 52);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 43);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(98, 104);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(169, 20);
            this.txtTckn.TabIndex = 6;
            this.txtTckn.TextChanged += new System.EventHandler(this.txtTckn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tckn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kisi No";
            // 
            // txtKisiNo
            // 
            this.txtKisiNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKisiNo.Location = new System.Drawing.Point(98, 26);
            this.txtKisiNo.Name = "txtKisiNo";
            this.txtKisiNo.ReadOnly = true;
            this.txtKisiNo.Size = new System.Drawing.Size(86, 20);
            this.txtKisiNo.TabIndex = 2;
            // 
            // txtkisiaciklama
            // 
            this.txtkisiaciklama.Location = new System.Drawing.Point(98, 130);
            this.txtkisiaciklama.Multiline = true;
            this.txtkisiaciklama.Name = "txtkisiaciklama";
            this.txtkisiaciklama.Size = new System.Drawing.Size(169, 90);
            this.txtkisiaciklama.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Açıklama";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Tarihi";
            this.label4.Click += new System.EventHandler(this.label6_Click);
            // 
            // dteDogumTarihi
            // 
            this.dteDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDogumTarihi.Location = new System.Drawing.Point(98, 226);
            this.dteDogumTarihi.Name = "dteDogumTarihi";
            this.dteDogumTarihi.Size = new System.Drawing.Size(102, 20);
            this.dteDogumTarihi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Eğ. Durumu";
            // 
            // cmbEgitimDurumlari
            // 
            this.cmbEgitimDurumlari.DisplayMember = "egitimdurum_adi";
            this.cmbEgitimDurumlari.FormattingEnabled = true;
            this.cmbEgitimDurumlari.Location = new System.Drawing.Point(98, 252);
            this.cmbEgitimDurumlari.Name = "cmbEgitimDurumlari";
            this.cmbEgitimDurumlari.Size = new System.Drawing.Size(169, 21);
            this.cmbEgitimDurumlari.TabIndex = 11;
            this.cmbEgitimDurumlari.ValueMember = "egitimdurum_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(98, 282);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(169, 21);
            this.cmbCinsiyet.TabIndex = 11;
            // 
            // cmbsektor
            // 
            this.cmbsektor.FormattingEnabled = true;
            this.cmbsektor.Location = new System.Drawing.Point(98, 309);
            this.cmbsektor.Name = "cmbsektor";
            this.cmbsektor.Size = new System.Drawing.Size(169, 21);
            this.cmbsektor.TabIndex = 12;
            // 
            // lblsektor
            // 
            this.lblsektor.AutoSize = true;
            this.lblsektor.Location = new System.Drawing.Point(22, 312);
            this.lblsektor.Name = "lblsektor";
            this.lblsektor.Size = new System.Drawing.Size(38, 13);
            this.lblsektor.TabIndex = 13;
            this.lblsektor.Text = "Sektör";
            this.lblsektor.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 367);
            this.Controls.Add(this.lblsektor);
            this.Controls.Add(this.cmbsektor);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEgitimDurumlari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dteDogumTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkisiaciklama);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtKisiNo);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKisiNo;
        private System.Windows.Forms.TextBox txtkisiaciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dteDogumTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEgitimDurumlari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbsektor;
        public System.Windows.Forms.Label lblsektor;
        private System.Windows.Forms.Button button1;
    }
}

