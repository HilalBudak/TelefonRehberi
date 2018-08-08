namespace Deneme_11
{
    partial class Form_AdresTipiListe
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
            this.gridAdresTipi = new DevExpress.XtraGrid.GridControl();
            this.gridAdresTipiVİew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdresTipiDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdresTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdresTipiVİew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdresTipiDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAdresTipi
            // 
            this.gridAdresTipi.Location = new System.Drawing.Point(-2, 103);
            this.gridAdresTipi.MainView = this.gridAdresTipiVİew;
            this.gridAdresTipi.Name = "gridAdresTipi";
            this.gridAdresTipi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAdresTipiDuzenle});
            this.gridAdresTipi.Size = new System.Drawing.Size(655, 362);
            this.gridAdresTipi.TabIndex = 0;
            this.gridAdresTipi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAdresTipiVİew});
            // 
            // gridAdresTipiVİew
            // 
            this.gridAdresTipiVİew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridAdresTipiVİew.GridControl = this.gridAdresTipi;
            this.gridAdresTipiVİew.Name = "gridAdresTipiVİew";
            this.gridAdresTipiVİew.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Adres Tipi Adı";
            this.gridColumn1.FieldName = "AdresTipiAdi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "AdresTipiId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.btnAdresTipiDuzenle;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // btnAdresTipiDuzenle
            // 
            this.btnAdresTipiDuzenle.AutoHeight = false;
            this.btnAdresTipiDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnAdresTipiDuzenle.Name = "btnAdresTipiDuzenle";
            this.btnAdresTipiDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAdresTipiDuzenle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAdresTipiDuzenle_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnYeniEkle);
            this.panelControl1.Location = new System.Drawing.Point(-2, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(655, 105);
            this.panelControl1.TabIndex = 1;
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(489, 32);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 0;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // Form_AdresTipiListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 464);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridAdresTipi);
            this.Name = "Form_AdresTipiListe";
            this.Text = "Form_AdresTipiListe";
            this.Load += new System.EventHandler(this.Form_AdresTipiListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdresTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdresTipiVİew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdresTipiDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAdresTipi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAdresTipiVİew;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnYeniEkle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAdresTipiDuzenle;
    }
}