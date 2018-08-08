namespace Deneme_11
{
    partial class Form_KullaniciListe
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtEMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.btnYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridKullanici = new DevExpress.XtraGrid.GridControl();
            this.gridKullaniciView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKullaniciDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullaniciView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullaniciDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtEMail);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnAra);
            this.panelControl1.Controls.Add(this.txtAdSoyad);
            this.panelControl1.Controls.Add(this.lblAdSoyad);
            this.panelControl1.Controls.Add(this.btnYeniEkle);
            this.panelControl1.Location = new System.Drawing.Point(0, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(875, 93);
            this.panelControl1.TabIndex = 2;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(81, 37);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(263, 20);
            this.txtEMail.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "E - Mail";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(362, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(81, 11);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(263, 20);
            this.txtAdSoyad.TabIndex = 4;
            this.txtAdSoyad.EditValueChanged += new System.EventHandler(this.txtAdSoyad_EditValueChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Location = new System.Drawing.Point(15, 14);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(46, 13);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(790, 35);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 1;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // gridKullanici
            // 
            this.gridKullanici.Location = new System.Drawing.Point(2, 65);
            this.gridKullanici.MainView = this.gridKullaniciView;
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnKullaniciDuzenle});
            this.gridKullanici.Size = new System.Drawing.Size(873, 462);
            this.gridKullanici.TabIndex = 3;
            this.gridKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKullaniciView});
            this.gridKullanici.Click += new System.EventHandler(this.gridKullanici_Click);
            // 
            // gridKullaniciView
            // 
            this.gridKullaniciView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn13,
            this.gridColumn12,
            this.gridColumn3});
            this.gridKullaniciView.GridControl = this.gridKullanici;
            this.gridKullaniciView.Name = "gridKullaniciView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "kullaniciId";
            this.gridColumn1.FieldName = "KullaniciId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "E - Mail";
            this.gridColumn2.FieldName = "Email";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 123;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Şifre";
            this.gridColumn4.FieldName = "Sifre";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "DurumId";
            this.gridColumn5.FieldName = "DurumId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ad Soyad";
            this.gridColumn6.FieldName = "AdSoyad";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 123;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ilId";
            this.gridColumn7.FieldName = "IlId";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "İlçe Id";
            this.gridColumn8.FieldName = "IlceId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Doğum Tarihi";
            this.gridColumn9.FieldName = "DogumTarihi";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 123;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cinsiyet";
            this.gridColumn10.FieldName = "Cinsiyet";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 123;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Açıklama";
            this.gridColumn11.FieldName = "Aciklama";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 300;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Rol Id";
            this.gridColumn13.FieldName = "RolId";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn12
            // 
            this.gridColumn12.ColumnEdit = this.btnKullaniciDuzenle;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            this.gridColumn12.Width = 63;
            // 
            // btnKullaniciDuzenle
            // 
            this.btnKullaniciDuzenle.AutoHeight = false;
            this.btnKullaniciDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnKullaniciDuzenle.Name = "btnKullaniciDuzenle";
            this.btnKullaniciDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnKullaniciDuzenle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnKullaniciDuzenle_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "UstKullaniciId";
            this.gridColumn3.FieldName = "UstKullaniciId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // Form_KullaniciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 526);
            this.Controls.Add(this.gridKullanici);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form_KullaniciListe";
            this.Text = "Form_KullaniciListe";
            this.Load += new System.EventHandler(this.Form_KullaniciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullaniciView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullaniciDuzenle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKullaniciView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnKullaniciDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYeniEkle;
        private DevExpress.XtraEditors.TextEdit txtEMail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl lblAdSoyad;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}