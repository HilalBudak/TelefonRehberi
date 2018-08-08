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
    public partial class Form_MDI : Form
    {
        public Form_MDI()
        {
            InitializeComponent();
            Program.MainForm = this;
        }

        private void Form_MDI_Load(object sender, EventArgs e)
        {

            Form_KullaniciGiris girisFormu = new Form_KullaniciGiris();
            //girisFormu.MdiParent = this;
            girisFormu.ShowDialog();
            navButton20.Caption = Guvenlik.Email;

            if (Guvenlik.RolId==2 && Guvenlik.UstKullaniciId!= null && Guvenlik.UstKullaniciId > 0)
            {
                navButton3.Visible = false;
            }

        }

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_KisiListe kisi = new Form_KisiListe();
            kisi.MdiParent = this;
            kisi.Show();
        }



        private void btnilcetanim_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_IlceListesi ilce = new Form_IlceListesi();

            ilce.ShowDialog();
        }

        private void btniltanim_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            
                Form_IlListesi il = new Form_IlListesi();

                il.ShowDialog();
            
        }

        private void btnAdresTipiEkrani_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_AdresTipiListe adrestipi = new Form_AdresTipiListe();

            adrestipi.ShowDialog();
        }

        private void btnKullaniciDurumlari_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_KullaniciDurumuListe kullanicidurum = new Form_KullaniciDurumuListe();

            kullanicidurum.ShowDialog();
        }

        private void navButton7_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_KanGrupListe liste = new Form_KanGrupListe();
            liste.ShowDialog();
        }

        private void navButton8_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_TelefonTipiListe liste = new Form_TelefonTipiListe();
            liste.ShowDialog();

        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Form_KullaniciListe liste = new Form_KullaniciListe();
       
            liste.ShowDialog();
        }

        private void navButton12_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            
            Form_BilgiDuzenle liste = new Form_BilgiDuzenle();
            liste.ShowDialog();
        }
    }
}
