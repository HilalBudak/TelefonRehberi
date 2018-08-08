using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deneme_11.IdeaV2WBS;

namespace Deneme_11
{
    public partial class Form_KisiTanim : Form
    {
        List<Telefonlar> telList = new List<Telefonlar>();
        int Updated;
        
        public Form_KisiTanim()
        {
            InitializeComponent();
        }

         public Form_KisiTanim(int update_insert)
        {
              InitializeComponent();
              Updated = update_insert;
        }

         public Form_KisiTanim(int id, int update_insert, string medenidurum, string unvan, string adsoyad, 
                               string email, string sirket,
                               bool aktif,bool iletisimizni,string cinsiyet, DateTime dogumtarihi, 
                               int kullaniciid, int kangrubuid , Image resim1 )
                               
        {
            InitializeComponent();
            Updated = update_insert;
            txtKisiNo.Text = id.ToString();
            lkumedenidurum.EditValue = medenidurum;
            txtunvan.Text = unvan;
            txtAdSoyad.Text = adsoyad;
            txtemail.Text = email;
            txtsirket.Text = sirket;
            chcdurum.Checked = aktif;
            chciletisimizni.Checked = iletisimizni;
            lkucinsiyet.EditValue = cinsiyet;
            dteDogumTarihi.EditValue = dogumtarihi;
            txtKullaniciNo.Text = kullaniciid.ToString();
            lkukan.EditValue = kangrubuid.ToString();
            pictureBox1.Image = resim1;
        }

         private void Form_KisiTanim_Load(object sender, EventArgs e)
         {
             IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            
             List<string>medenidurumlist=new List<string>();
             medenidurumlist.Add("Evli");
             medenidurumlist.Add("Bekar");
             lkumedenidurum.Properties.DataSource = medenidurumlist;

             List<string> cinsiyetlist = new List<string>();
             cinsiyetlist.Add("Kadın");
             cinsiyetlist.Add("Erkek");
             lkucinsiyet.Properties.DataSource = cinsiyetlist;

             lkukan.Properties.DataSource = Serv.KanGruplariListesi().Tables[0];

             if (txtKisiNo.Text != "")
                 TelefonGetir(Convert.ToInt32(txtKisiNo.Text));

             lkuTelefonTipiGetir.DataSource = Serv.TelefonTipiListesi().Tables[0];            
         }

         private void lkumedenidurum_EditValueChanged(object sender, EventArgs e)
         {

         }

         private void btnkaydet_Click(object sender, EventArgs e)
         {
             if (txtemail.Text == "")
             {
                 MessageBox.Show("E mail alanı boş geçilemez ");
                 return;
             }
             if (txtAdSoyad.Text == "")
             {
                 MessageBox.Show("AdSoyad alanı boş geçilemez ");
                 return;
             }                 
             if (lkucinsiyet.EditValue == null)
             {
                 MessageBox.Show("Cinsiyet alanı boş geçilemez ");
                 return;
             }
             if (lkumedenidurum.EditValue == null)
             {
                 MessageBox.Show("Medeni Durum alanı boş geçilemez ");
                 return;
             }
             if (txtunvan.Text == null)
             {
                 MessageBox.Show("Unvan alanı boş geçilemez ");
                 return;
             }
             if (lkukan.EditValue == null)
             {
                 MessageBox.Show("Kan Grup alanı boş geçilemez ");
                 return;
             }
             if (txtsirket.Text == null)
             {
                 MessageBox.Show("Şirket alanı boş geçilemez ");
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

                Byte[] resim = null;
                ImageConverter imgConverter = new ImageConverter();
                resim = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));

             Serv.KisiKaydet(kisiId, txtemail.Text,lkumedenidurum.EditValue.ToString(),txtunvan.Text, chciletisimizni.Checked,
                             Guvenlik.KullaniciId,Convert.ToInt32(lkukan.EditValue),chcdurum.Checked, txtAdSoyad.Text, 
                             lkucinsiyet.EditValue.ToString(),
                             Convert.ToDateTime(dteDogumTarihi.EditValue),  txtsirket.Text,
                             Updated, telList.ToArray(),resim);

             MessageBox.Show("Kayıt Başarılı");
             this.Close();            
         }

         private void TelefonGetir(int kisi_id)
         {
             if (telList.Count > 0)
                 telList.Clear();

             IdeaV2WBS.IdeaV2 serv = new IdeaV2WBS.IdeaV2();
             DataSet ds = serv.KisiTelefonlariGetir(kisi_id);
             foreach (DataRow row in ds.Tables[0].Rows)
             {
                 if (row != null)
                 {
                     Telefonlar newTel = new Telefonlar();

                     if (row["KisiId"] != null)
                         newTel.KisiId = Convert.ToInt32(row["KisiId"]);

                     if (row["KullaniciId"] != null)
                         newTel.KullaniciId = Convert.ToInt32(row["KullaniciId"]);

                     if (row["TelefonNo"] != null)
                        newTel.TelefonNo = row["TelefonNo"].ToString();

                     if (row["TelefonTipiId"] != null)
                        newTel.TelefonTipiId = Convert.ToInt32(row["TelefonTipiId"]);

                     if (row["TelefonId"] != null)
                        newTel.TelefonId = Convert.ToInt32(row["TelefonId"]);

                     telList.Add(newTel);
                 }
             }
             gridTelefon.DataSource = telList;
             gridTelefon.RefreshDataSource();
         }

         private void btntelefonekle_Click(object sender, EventArgs e)
         {
             FormTelefonEkle telefon = new FormTelefonEkle(Convert.ToInt32(txtKisiNo.Text));
             telefon.ShowDialog();
             TelefonGetir(Convert.ToInt32(txtKisiNo.Text));
         }

         private void button1_Click(object sender, EventArgs e)
         {
             openFileDialog1.ShowDialog();
             pictureBox1.ImageLocation = openFileDialog1.FileName;

         }
    }
}
