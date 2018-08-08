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
    public partial class Form_KullaniciDurumTanim : Form
    {
        int id;
        int Updated;

        public Form_KullaniciDurumTanim()
        {
            InitializeComponent();
        }
        public Form_KullaniciDurumTanim(string durumadi, int durumid, int updated)
        {
            InitializeComponent();
            txtDurum.Text = durumadi;
            id = durumid;
            Updated = updated;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            service.KullaniciDurumuKaydet(txtDurum.Text, id, Updated);
            this.Close();
        }


    }
}
