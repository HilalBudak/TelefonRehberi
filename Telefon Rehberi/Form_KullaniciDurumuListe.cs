using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_11
{
    public partial class Form_KullaniciDurumuListe : Form
    {
        public Form_KullaniciDurumuListe()
        {
            InitializeComponent();
        }
        private void kullanicidurumgetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.KullaniciDurumListesi();
            gridControl1.DataSource = ds.Tables[0];
        }
        private void Form_KullaniciDurumListe_Load(object sender, EventArgs e)
        {
            kullanicidurumgetir();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Form_KullaniciDurumTanim form = new Form_KullaniciDurumTanim();
            form.ShowDialog();
            kullanicidurumgetir();
        }

        private void btnDurumDuzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow selectedRow = gridKullaniciDurumuView.GetFocusedDataRow();

            if (selectedRow != null)
            {
                string durumadi = selectedRow["DurumAd"].ToString();
                int durumid = Convert.ToInt32(selectedRow["DurumId"]);

                Form_KullaniciDurumTanim form = new Form_KullaniciDurumTanim(durumadi, durumid, 1);
                form.ShowDialog();
                kullanicidurumgetir();
            }
        }

    }
}
