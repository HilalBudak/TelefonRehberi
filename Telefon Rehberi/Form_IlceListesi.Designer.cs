namespace Deneme_11
{
    partial class Form_IlceListesi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnIlceKayit = new DevExpress.XtraEditors.SimpleButton();
            this.lkuIl = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridilce = new DevExpress.XtraGrid.GridControl();
            this.gridilceView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIlceDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridilce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridilceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlceDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.69692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.30308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnIlceKayit);
            this.panelControl1.Controls.Add(this.lkuIl);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(4, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(633, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // btnIlceKayit
            // 
            this.btnIlceKayit.Location = new System.Drawing.Point(527, 23);
            this.btnIlceKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlceKayit.Name = "btnIlceKayit";
            this.btnIlceKayit.Size = new System.Drawing.Size(100, 28);
            this.btnIlceKayit.TabIndex = 2;
            this.btnIlceKayit.Text = "Yeni Ekle";
            this.btnIlceKayit.Click += new System.EventHandler(this.btnIlceKayit_Click);
            // 
            // lkuIl
            // 
            this.lkuIl.Location = new System.Drawing.Point(105, 11);
            this.lkuIl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lkuIl.Name = "lkuIl";
            this.lkuIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuIl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlId", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IlAd", "Name2")});
            this.lkuIl.Properties.DisplayMember = "IlAd";
            this.lkuIl.Properties.NullText = "";
            this.lkuIl.Properties.ValueMember = "IlId";
            this.lkuIl.Properties.EditValueChanged += new System.EventHandler(this.lkuIl_Properties_EditValueChanged);
            this.lkuIl.Size = new System.Drawing.Size(303, 22);
            this.lkuIl.TabIndex = 1;
            this.lkuIl.EditValueChanged += new System.EventHandler(this.lkuIl_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(7, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İl";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridilce);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(4, 63);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(633, 486);
            this.panelControl2.TabIndex = 1;
            // 
            // gridilce
            // 
            this.gridilce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridilce.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridilce.Location = new System.Drawing.Point(2, 2);
            this.gridilce.MainView = this.gridilceView;
            this.gridilce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridilce.Name = "gridilce";
            this.gridilce.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIlceDuzenle});
            this.gridilce.Size = new System.Drawing.Size(629, 482);
            this.gridilce.TabIndex = 0;
            this.gridilce.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridilceView});
            // 
            // gridilceView
            // 
            this.gridilceView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridilceView.GridControl = this.gridilce;
            this.gridilceView.Name = "gridilceView";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İlçe Adı";
            this.gridColumn1.FieldName = "IlceAd";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 378;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IlId";
            this.gridColumn2.FieldName = "IlId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IlceId";
            this.gridColumn3.FieldName = "IlceId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = " ";
            this.gridColumn4.ColumnEdit = this.btnIlceDuzenle;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // btnIlceDuzenle
            // 
            this.btnIlceDuzenle.AutoHeight = false;
            this.btnIlceDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnIlceDuzenle.Name = "btnIlceDuzenle";
            this.btnIlceDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnIlceDuzenle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnIlceDuzenle_ButtonClick);
            // 
            // Form_IlceListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_IlceListesi";
            this.Text = "Form_IlceListesi";
            this.Load += new System.EventHandler(this.Form_IlceListesi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridilce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridilceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlceDuzenle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkuIl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridilce;
        private DevExpress.XtraGrid.Views.Grid.GridView gridilceView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIlceDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnIlceKayit;
    }
}