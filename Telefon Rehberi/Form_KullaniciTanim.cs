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
    public partial class Form_KullaniciTanim : Form
    {
        int Updated;
        string aciklama2 = "";
        

        public Form_KullaniciTanim()
        {
            InitializeComponent();
        }
        public Form_KullaniciTanim(int update_insert)
        {
              InitializeComponent();
              Updated = update_insert;

        }

        public Form_KullaniciTanim(int id, int update_insert, int? ilid, int? ilceid, string adsoyad, string email, string sifre,
                                    string aciklama,string cinsiyet, DateTime? dogumtarihi, int rolid, int? ustkullaniciid)
        {
            InitializeComponent();
            Updated = update_insert;
            txtKisiNo.Text = id.ToString();
            lkuIl.EditValue = ilid.ToString();
            lkuIlce.EditValue = ilceid.ToString();
            txtAdSoyad.Text = adsoyad;
            txtEmail.Text = email;
            txtSifre.Text = sifre;
            memoAciklama.Text = aciklama;
            lkuCinsiyet.EditValue = cinsiyet;
            dteDogumTarihi.EditValue = dogumtarihi;
            lkuRol.EditValue = rolid;
            lkuUstKullanici.EditValue = ustkullaniciid;

        }    

        private void Form_KullaniciTanim_Load(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.IlListesi();
            lkuIl.Properties.DataSource = ds.Tables[0];
            lkuUstKullanici.Properties.DataSource = Serv.UstKullaniciListesi().Tables[0];


            List<string> cinsiyetlist = new List<string>();
            cinsiyetlist.Add("Kadın");
            cinsiyetlist.Add("Erkek");
            lkuCinsiyet.Properties.DataSource = cinsiyetlist;

            lkuRol.Properties.DataSource = Serv.RolListesi(Guvenlik.RolId).Tables[0];

            /****/
            if (Guvenlik.RolId == 2)
            {
                lkuUstKullanici.ReadOnly = true;
                lkuUstKullanici.EditValue = Guvenlik.KullaniciId;
            }

                

        }
        

        private void lkuIl_EditValueChanged(object sender, EventArgs e)
        {
            if (lkuIl.EditValue != null && lkuIl.EditValue != DBNull.Value && lkuIl.EditValue.ToString() != "")
            {
                int ilid = Convert.ToInt32(lkuIl.EditValue);
                IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();

                DataSet ds = Serv.IlceListesi(ilid);
                lkuIlce.Properties.DataSource = ds.Tables[0];
            }
        }

        private void lkuRol_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("E mail alanı boş geçilemez ");
                return;
            }

            if (txtAdSoyad.Text == "")
            {
                MessageBox.Show("AdSoyad alanı boş geçilemez ");
                return;
            }
            if (txtSifre.Text == "")
            {
                MessageBox.Show("Şifre alanı boş geçilemez ");
                return;
            }
            if (memoAciklama.Text == "")
            {
                MessageBox.Show("Açıklama alanı boş geçilemez ");
                return;
            }
            if (lkuCinsiyet.EditValue == null)
            {
                MessageBox.Show("Cinsiyet alanı boş geçilemez ");
                return;
            }
            if (lkuIl.EditValue == null)
            {
                MessageBox.Show("İl alanı boş geçilemez ");
                return;
            }
            if (lkuIlce.EditValue == null)
            {
                MessageBox.Show("İlçe alanı boş geçilemez ");
                return;
            }
            if (lkuRol.EditValue == null)
            {
                MessageBox.Show("Rol alanı boş geçilemez ");
                return;
            }
            if (dteDogumTarihi.EditValue == null)
            {
                MessageBox.Show("Doğum Tarihi boş geçilemez ");
                return;
            }

            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();

            int kisiId = 0;

            if (txtKisiNo.Text != "")
                kisiId = Convert.ToInt32(txtKisiNo.Text);
            else
                kisiId = -1;

            bool temp =Serv.KullaniciKaydet(kisiId, txtEmail.Text, txtSifre.Text, 1, txtAdSoyad.Text, lkuIl.EditValue.ToString(), lkuIlce.EditValue.ToString(),
                                    lkuCinsiyet.EditValue.ToString(), Convert.ToDateTime(dteDogumTarihi.EditValue), memoAciklama.Text, Updated,
                                    Convert.ToInt32(lkuRol.EditValue),
                                    Convert.ToInt32(lkuUstKullanici.EditValue),Guvenlik.KullaniciId,out aciklama2);

            if (temp == true){
                MessageBox.Show(aciklama2);
                this.Close();
              
            }
            else
            {
                MessageBox.Show(aciklama2);
                
            }
            
            

        }

        private void btnIlceKaydet_Click(object sender, EventArgs e)
        {
            if (lkuIl.EditValue != null)
            {
                Form_IlceTanim form = new Form_IlceTanim(lkuIl.Text, Convert.ToInt32(lkuIl.EditValue), 0);
                form.ShowDialog();


                lkuIl_EditValueChanged(null, null);
                lkuIlce.EditValue = form.yeniId;

            }
        }

        private void btnIlKaydet_Click(object sender, EventArgs e)
        {
            
          
                Form_IlTanim form = new Form_IlTanim(0);
                form.ShowDialog();


                IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
                DataSet ds = Serv.IlListesi();
                lkuIl.Properties.DataSource = ds.Tables[0];

                lkuIl.EditValue = form.yeniId;

          
            

            
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

    }
}
