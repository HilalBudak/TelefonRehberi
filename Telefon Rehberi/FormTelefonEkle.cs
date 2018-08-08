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
    public partial class FormTelefonEkle : Form
    {
        int telefonId;
        int kisiid;
        public FormTelefonEkle(int kisi_id)
        {
            kisiid = kisi_id;
            InitializeComponent();
        }

        private void FormTelefonEkle_Load(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            lkuTelefonEkle.Properties.DataSource = Serv.TelefonTipiListesi().Tables[0];
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            service.TelefonKaydet(telefonId,Convert.ToInt32( txtTelefonNo.Text), Convert.ToInt32(lkuTelefonEkle.EditValue),kisiid , Guvenlik.KullaniciId, 0);

            this.Close();
        }
    }
}
