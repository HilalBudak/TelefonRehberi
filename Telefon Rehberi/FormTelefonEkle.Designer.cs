namespace Deneme_11
{
    partial class FormTelefonEkle
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
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefonNo = new DevExpress.XtraEditors.TextEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkuTelefonEkle = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuTelefonEkle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(282, 142);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(165, 94);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(192, 20);
            this.txtTelefonNo.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(75, 97);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(36, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Telefon";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Telefon Tipi";
            // 
            // lkuTelefonEkle
            // 
            this.lkuTelefonEkle.Location = new System.Drawing.Point(165, 38);
            this.lkuTelefonEkle.Name = "lkuTelefonEkle";
            this.lkuTelefonEkle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuTelefonEkle.Properties.DisplayMember = "TelefonTipiAdi";
            this.lkuTelefonEkle.Properties.NullText = "";
            this.lkuTelefonEkle.Properties.ValueMember = "TelefonTipiId";
            this.lkuTelefonEkle.Size = new System.Drawing.Size(192, 20);
            this.lkuTelefonEkle.TabIndex = 40;
            // 
            // FormTelefonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 187);
            this.Controls.Add(this.lkuTelefonEkle);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.lbl);
            this.Name = "FormTelefonEkle";
            this.Text = "FormTelefonEkle";
            this.Load += new System.EventHandler(this.FormTelefonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuTelefonEkle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtTelefonNo;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkuTelefonEkle;
    }
}