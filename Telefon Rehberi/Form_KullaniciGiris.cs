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
    public partial class Form_KullaniciGiris : Form
    {
        public Form_KullaniciGiris()
        {
            InitializeComponent();
        }

        private void Form_KullaniciGiris_Load(object sender, EventArgs e)
        {
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Program.MainForm.Close();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email Zorunludur");
                return;
            }

            if (txtSifre.Text == "")
            {
                MessageBox.Show("Şifre Girilmelidir");
                return;
            }

            /* kod bu aşamaya geldiyse hata yok demektir.
             * */

            string email = txtEmail.Text;
            string sifre = txtSifre.Text;
            string aciklama = "";
            int kullaniciID = 0;
            int rolid =0;
            int ustid=0;
            string adsoyad = "";


            IdeaV2WBS.IdeaV2 srv = new IdeaV2WBS.IdeaV2();
            bool sonuc = srv.GirisKontrol(email, sifre, "1.0", out aciklama, out kullaniciID,out rolid,out ustid,out adsoyad);

            if (sonuc == false)
            {
                MessageBox.Show(aciklama);
                Program.MainForm.Close();
            }
            else
            {
                Guvenlik.Email = email;
                Guvenlik.KullaniciId = kullaniciID;
                Guvenlik.RolId = rolid;
                Guvenlik.UstKullaniciId = ustid;
                Guvenlik.AdSoyad = adsoyad;
                Guvenlik.Sifre =sifre;
                this.Close();

            }



        }
    }
}
