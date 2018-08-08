namespace Deneme_11
{
    partial class Form_IlTanim
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
            this.lblIl = new DevExpress.XtraEditors.LabelControl();
            this.txtIl = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIl
            // 
            this.lblIl.Location = new System.Drawing.Point(26, 43);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(6, 13);
            this.lblIl.TabIndex = 0;
            this.lblIl.Text = "İl";
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(74, 40);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(263, 20);
            this.txtIl.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(262, 80);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form_IlTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 141);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.lblIl);
            this.Name = "Form_IlTanim";
            this.Text = "Form_IlTanim";
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblIl;
        private DevExpress.XtraEditors.TextEdit txtIl;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}