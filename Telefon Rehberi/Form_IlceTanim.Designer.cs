namespace Deneme_11
{
    partial class Form_IlceTanim
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIlce = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblIl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İlçe";
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(66, 34);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(252, 20);
            this.txtIlce.TabIndex = 1;
            this.txtIlce.EditValueChanged += new System.EventHandler(this.txtIlce_EditValueChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(243, 60);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblIl
            // 
            this.lblIl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblIl.Location = new System.Drawing.Point(66, 12);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(5, 16);
            this.lblIl.TabIndex = 3;
            this.lblIl.Text = "-";
            // 
            // Form_IlceTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 110);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form_IlceTanim";
            this.Text = "Form_IlceTanim";
            this.Load += new System.EventHandler(this.Form_IlceTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblIl;
    }
}