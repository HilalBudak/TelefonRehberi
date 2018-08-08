namespace Deneme_11
{
    partial class Form_IlListesi
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
            this.btnIlKayit = new DevExpress.XtraEditors.SimpleButton();
            this.gridIl = new DevExpress.XtraGrid.GridControl();
            this.gridilView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIlDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridilView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnIlKayit);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(737, 83);
            this.panelControl1.TabIndex = 0;
            // 
            // btnIlKayit
            // 
            this.btnIlKayit.Location = new System.Drawing.Point(551, 13);
            this.btnIlKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlKayit.Name = "btnIlKayit";
            this.btnIlKayit.Size = new System.Drawing.Size(115, 50);
            this.btnIlKayit.TabIndex = 2;
            this.btnIlKayit.Text = "Yeni Ekle";
            this.btnIlKayit.Click += new System.EventHandler(this.btnIlKayit_Click);
            // 
            // gridIl
            // 
            this.gridIl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridIl.Location = new System.Drawing.Point(0, 91);
            this.gridIl.MainView = this.gridilView;
            this.gridIl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridIl.Name = "gridIl";
            this.gridIl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIlDuzenle,
            this.repositoryItemTextEdit1});
            this.gridIl.Size = new System.Drawing.Size(737, 527);
            this.gridIl.TabIndex = 1;
            this.gridIl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridilView});
            // 
            // gridilView
            // 
            this.gridilView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridilView.GridControl = this.gridIl;
            this.gridilView.Name = "gridilView";
            this.gridilView.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İl Adı ";
            this.gridColumn1.FieldName = "IlAd";
            this.gridColumn1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IlId";
            this.gridColumn2.FieldName = "IlId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.btnIlDuzenle;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // btnIlDuzenle
            // 
            this.btnIlDuzenle.AutoHeight = false;
            this.btnIlDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnIlDuzenle.Name = "btnIlDuzenle";
            this.btnIlDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnIlDuzenle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnIlDuzenle_ButtonClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Form_IlListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 618);
            this.Controls.Add(this.gridIl);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_IlListesi";
            this.Text = "Form_IlListesi";
            this.Load += new System.EventHandler(this.Form_IlListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridilView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIlKayit;
        private DevExpress.XtraGrid.GridControl gridIl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridilView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIlDuzenle;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}