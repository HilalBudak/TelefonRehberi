namespace Deneme_11
{
    partial class Form_BilgiDuzenle
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
            this.txtKullaniciId = new DevExpress.XtraEditors.TextEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.txtEMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txteskisifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtyenisifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsifretekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteskisifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyenisifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifretekrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciId
            // 
            this.txtKullaniciId.Location = new System.Drawing.Point(133, 25);
            this.txtKullaniciId.Name = "txtKullaniciId";
            this.txtKullaniciId.Properties.ReadOnly = true;
            this.txtKullaniciId.Size = new System.Drawing.Size(160, 20);
            this.txtKullaniciId.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(31, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(51, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Kullanıcı ID";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(133, 77);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Properties.ReadOnly = true;
            this.txtEMail.Size = new System.Drawing.Size(160, 20);
            this.txtEMail.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "E - Mail";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(133, 51);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(160, 20);
            this.txtAdSoyad.TabIndex = 14;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Location = new System.Drawing.Point(31, 54);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(46, 13);
            this.lblAdSoyad.TabIndex = 13;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txteskisifre
            // 
            this.txteskisifre.EditValue = "";
            this.txteskisifre.Location = new System.Drawing.Point(133, 103);
            this.txteskisifre.Name = "txteskisifre";
            this.txteskisifre.Size = new System.Drawing.Size(160, 20);
            this.txteskisifre.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Eski Şifre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(218, 181);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.EditValue = "";
            this.txtyenisifre.Location = new System.Drawing.Point(133, 129);
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.Size = new System.Drawing.Size(160, 20);
            this.txtyenisifre.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Yeni Şifre";
            // 
            // txtsifretekrar
            // 
            this.txtsifretekrar.EditValue = "";
            this.txtsifretekrar.Location = new System.Drawing.Point(133, 155);
            this.txtsifretekrar.Name = "txtsifretekrar";
            this.txtsifretekrar.Size = new System.Drawing.Size(160, 20);
            this.txtsifretekrar.TabIndex = 33;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Yeni Şifre (tekrar)";
            // 
            // Form_BilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 213);
            this.Controls.Add(this.txtsifretekrar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtyenisifre);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txteskisifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtKullaniciId);
            this.Controls.Add(this.lbl);
            this.Name = "Form_BilgiDuzenle";
            this.Text = "Form_BilgiDuzenle";
            this.Load += new System.EventHandler(this.Form_BilgiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteskisifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyenisifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifretekrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullaniciId;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.TextEdit txtEMail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl lblAdSoyad;
        private DevExpress.XtraEditors.TextEdit txteskisifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtyenisifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtsifretekrar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}