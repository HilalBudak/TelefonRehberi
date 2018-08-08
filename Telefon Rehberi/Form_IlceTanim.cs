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
    public partial class Form_IlceTanim : Form
    {
        public int yeniId = 0;
        int IlId = 0;
        int IlceId = 0;
        int Updated;

        public Form_IlceTanim()
        {
            InitializeComponent();
        }

        public Form_IlceTanim(string il_adi, int il_id, int update_insert)
        {
            InitializeComponent();

            lblIl.Text = il_adi;
            IlId = il_id;
            Updated = update_insert;
        }

        public Form_IlceTanim(string il_adi, int il_id, int ilce_id , string ilce_adi, int update_insert)
        {
            InitializeComponent();

            lblIl.Text = il_adi;
            IlId = il_id;
            Updated = update_insert;

            txtIlce.Text = ilce_adi;
            IlceId = ilce_id;

        }

        private void Form_IlceTanim_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            
            yeniId = service.IlceKaydet(txtIlce.Text,Updated,IlceId,IlId);
            
            this.Close();
        }

        private void txtIlce_EditValueChanged(object sender, EventArgs e)
        {

        }
    }


}
