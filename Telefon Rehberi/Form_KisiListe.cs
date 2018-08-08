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
    public partial class Form_KisiListe : Form
    {
        public Form_KisiListe()
        {
            InitializeComponent();
        }

        private void btn_duzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DataRow selectedRow = gridilceView.GetDataRow(gridilceView.FocusedRowHandle);
            DataRow selectedRow = KisiListeView.GetFocusedDataRow();

            if (selectedRow != null)
            {
                string adsoyad = selectedRow["AdSoyad"].ToString();
                string email = selectedRow["Email"].ToString();
                string medenidurum = selectedRow["MedeniDurumu"].ToString();
                string unvan = selectedRow["Unvani"].ToString();
                DateTime dogumtarihi = Convert.ToDateTime(selectedRow["DogumTarihi"]);
                string cinsiyet = selectedRow["Cinsiyeti"].ToString();
                int kisiid = Convert.ToInt32(selectedRow["KisiId"]);
                int kullaniciid = Convert.ToInt32(selectedRow["KullaniciId"]);
                int kangrubuid = Convert.ToInt32(selectedRow["KanGrubuId"]);
               // Image fotograf = selectedRow["Fotografi"];
                string sirket = selectedRow["Sirket"].ToString();
                bool iletisimizni =Convert.ToBoolean(selectedRow["IletisimIzni"]);
                bool aktif = Convert.ToBoolean(selectedRow["Aktif"]);

                Image fotograf = null;

                Form_KisiTanim form = new Form_KisiTanim(kisiid, 1, medenidurum, unvan, adsoyad, email, sirket, aktif, iletisimizni, cinsiyet,
                                                        dogumtarihi, kullaniciid, kangrubuid,fotograf);
                form.ShowDialog();

                kisigetir();


            }
        }

        private void Form_KisiListe_Load(object sender, EventArgs e)
        {
            kisigetir();
        }

        private void kisigetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            string adsoyad, email;

            if (txtAdSoyad.Text != "")
                adsoyad = txtAdSoyad.Text;
            else
                adsoyad = null;

            if (txtEMail.Text != "")
                email = txtEMail.Text;
            else
                email = null;

            DataSet ds = Serv.KisiListesi(adsoyad, email, Guvenlik.KullaniciId);
            gridControl1.DataSource = ds.Tables[0];
        }

        private void txtAdSoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIlKayit_Click(object sender, EventArgs e)
        {
            Form_KisiTanim kisi = new Form_KisiTanim(0);
            kisi.ShowDialog();
            kisigetir();

           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
