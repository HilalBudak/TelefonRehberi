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
    public partial class Form_BilgiDuzenle : Form
    {
        public Form_BilgiDuzenle()
        {
            InitializeComponent();
        }

        private void Form_BilgiDuzenle_Load(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
         
            int kullaniciid = Guvenlik.KullaniciId;
            string email = Guvenlik.Email;
            string adsoyad = Guvenlik.AdSoyad;
            string sifre = Guvenlik.Sifre;

            txtAdSoyad.Text = adsoyad;
            txtEMail.Text = email;
            txtKullaniciId.Text = kullaniciid.ToString();    
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();

            string yenisifre = null;
            int kullaniciId = 0;

            if (txteskisifre.Text != "" && Guvenlik.Sifre == txteskisifre.Text)
            {
                if (txtyenisifre.Text != "" && txtyenisifre.Text == txtsifretekrar.Text)
                {
                    yenisifre = txtyenisifre.Text;
                }
                else
                {
                    MessageBox.Show("Şifreler Boş veye Uyumsuz");
                    return;
                }  
            }

            if (txtKullaniciId.Text != "")
                kullaniciId = Convert.ToInt32(txtKullaniciId.Text);
            else
                kullaniciId = -1;

            Serv.Duzenle(kullaniciId, txtEMail.Text, yenisifre, txtAdSoyad.Text);
            MessageBox.Show("Kayıt Değiştirildi");
            this.Close();
        }             
    }
}
