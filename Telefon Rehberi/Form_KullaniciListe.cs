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
    public partial class Form_KullaniciListe : Form
    {
       
        
        public Form_KullaniciListe()
        {
            InitializeComponent();
        }

        private void Form_KullaniciListe_Load(object sender, EventArgs e)
        {
            kullanicigetir();
        }

        private void kullanicigetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            string adSoyad, email;

            if (txtAdSoyad.Text != "")
                adSoyad = txtAdSoyad.Text;
            else
                adSoyad = null;

            if (txtEMail.Text != "")
                email = txtEMail.Text;
            else
                email = null;

            DataSet ds = Serv.KullaniciListesi(adSoyad, email,Guvenlik.KullaniciId);
            gridKullanici.DataSource = ds.Tables[0];
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            kullanicigetir();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Form_KullaniciTanim form = new Form_KullaniciTanim();
            form.ShowDialog();
            kullanicigetir();
        }

        private void btnKullaniciDuzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DataRow selectedRow = gridilceView.GetDataRow(gridilceView.FocusedRowHandle);
            DataRow selectedRow = gridKullaniciView.GetFocusedDataRow();

            if (selectedRow != null)
            {
                DateTime? dogumtarihi = null;
                int? ilce_id = null;
                int? il_id = null;
                int? ustkullaniciid= null;

                string adsoyad = selectedRow["AdSoyad"].ToString();
                string email = selectedRow["Email"].ToString();
                string sifre = selectedRow["Sifre"].ToString();
                string aciklama = selectedRow["Aciklama"].ToString();
                if (selectedRow["UstKullaniciId"] != null && selectedRow["UstKullaniciId"] != DBNull.Value)
                     ustkullaniciid = Convert.ToInt32(selectedRow["UstKullaniciId"]);

                if (selectedRow["DogumTarihi"] != null && selectedRow["DogumTarihi"] != DBNull.Value)
                    dogumtarihi = Convert.ToDateTime(selectedRow["DogumTarihi"]);

                string cinsiyet = selectedRow["Cinsiyet"].ToString();
                int rol_id = Convert.ToInt32(selectedRow["RolId"]);
                int kullanici_id = Convert.ToInt32(selectedRow["KullaniciId"]);
                int durum_id = Convert.ToInt32(selectedRow["DurumId"]);

                if (selectedRow["IlceId"] != null && selectedRow["IlceId"] != DBNull.Value)
                    ilce_id = Convert.ToInt32(selectedRow["IlceId"]);

                if (selectedRow["IlId"] != null && selectedRow["IlId"] != DBNull.Value)
                    il_id = Convert.ToInt32(selectedRow["IlId"]);

                    Form_KullaniciTanim form = new Form_KullaniciTanim(kullanici_id,1,il_id,ilce_id,
                        adsoyad,email,sifre,aciklama,cinsiyet,dogumtarihi,rol_id, ustkullaniciid);
                    form.ShowDialog();

                    kullanicigetir();
            

                }
            }

        private void txtAdSoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridKullanici_Click(object sender, EventArgs e)
        {

        }
        }

  

     
        
   
}
