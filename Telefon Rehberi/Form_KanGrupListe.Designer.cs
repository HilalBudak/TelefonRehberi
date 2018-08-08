namespace Deneme_11
{
    partial class Form_KanGrupListe
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
            this.btnYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridKanGrup = new DevExpress.XtraGrid.GridControl();
            this.gridKanGrupView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KanGrupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KanGrubuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKanGrupDuzenle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKanGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKanGrupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnYeniEkle);
            this.panelControl1.Location = new System.Drawing.Point(0, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(607, 112);
            this.panelControl1.TabIndex = 0;
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(491, 58);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 0;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // gridKanGrup
            // 
            this.gridKanGrup.Location = new System.Drawing.Point(0, 119);
            this.gridKanGrup.MainView = this.gridKanGrupView;
            this.gridKanGrup.Name = "gridKanGrup";
            this.gridKanGrup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDuzenle});
            this.gridKanGrup.Size = new System.Drawing.Size(607, 355);
            this.gridKanGrup.TabIndex = 1;
            this.gridKanGrup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKanGrupView});
            // 
            // gridKanGrupView
            // 
            this.gridKanGrupView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KanGrupId,
            this.KanGrubuAdi,
            this.btnKanGrupDuzenle});
            this.gridKanGrupView.GridControl = this.gridKanGrup;
            this.gridKanGrupView.Name = "gridKanGrupView";
            // 
            // KanGrupId
            // 
            this.KanGrupId.Caption = "KanGrupId";
            this.KanGrupId.FieldName = "KanGrubuId";
            this.KanGrupId.Name = "KanGrupId";
            // 
            // KanGrubuAdi
            // 
            this.KanGrubuAdi.Caption = "Kan Grubu Adı";
            this.KanGrubuAdi.FieldName = "KanGrubuAdi";
            this.KanGrubuAdi.Name = "KanGrubuAdi";
            this.KanGrubuAdi.OptionsColumn.AllowEdit = false;
            this.KanGrubuAdi.Visible = true;
            this.KanGrubuAdi.VisibleIndex = 0;
            // 
            // btnKanGrupDuzenle
            // 
            this.btnKanGrupDuzenle.ColumnEdit = this.btnDuzenle;
            this.btnKanGrupDuzenle.Name = "btnKanGrupDuzenle";
            this.btnKanGrupDuzenle.Visible = true;
            this.btnKanGrupDuzenle.VisibleIndex = 1;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.AutoHeight = false;
            this.btnDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDuzenle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDuzenle_ButtonClick);
            // 
            // Form_KanGrupListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 471);
            this.Controls.Add(this.gridKanGrup);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form_KanGrupListe";
            this.Text = "Form_KanGrupListe";
            this.Load += new System.EventHandler(this.Form_KanGrupListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKanGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKanGrupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnYeniEkle;
        private DevExpress.XtraGrid.GridControl gridKanGrup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKanGrupView;
        private DevExpress.XtraGrid.Columns.GridColumn KanGrupId;
        private DevExpress.XtraGrid.Columns.GridColumn KanGrubuAdi;
        private DevExpress.XtraGrid.Columns.GridColumn btnKanGrupDuzenle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDuzenle;
    }
}