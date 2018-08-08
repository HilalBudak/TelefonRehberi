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
    public partial class Form_IlceListesi : Form
    {
        public Form_IlceListesi()
        {
            InitializeComponent();
        }

        private void Form_IlceListesi_Load(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.IlListesi();
            lkuIl.Properties.DataSource = ds.Tables[0];
            //lkuIl.Properties.DataSource = Serv.IlListesi();

        }

        private void lkuIl_Properties_EditValueChanged(object sender, EventArgs e) //ekranı refresh et
        {
            int ilid = Convert.ToInt32(lkuIl.EditValue);
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();

            DataSet ds = Serv.IlceListesi(ilid);
            gridilce.DataSource = ds.Tables[0];

        }

        private void btnIlceKayit_Click(object sender, EventArgs e)
        {
            if (lkuIl.EditValue != null)
            {
                Form_IlceTanim form = new Form_IlceTanim(lkuIl.Text, Convert.ToInt32(lkuIl.EditValue), 0);
                form.ShowDialog();
                lkuIl_Properties_EditValueChanged(null, null);
            }
        }

        private void btnIlceDuzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DataRow selectedRow = gridilceView.GetDataRow(gridilceView.FocusedRowHandle);
            DataRow selectedRow = gridilceView.GetFocusedDataRow();

            if (selectedRow != null)
            {
                string ilce_adi = selectedRow["IlceAd"].ToString();
                int ilce_id = Convert.ToInt32(selectedRow["IlceId"]);

                if (lkuIl.EditValue != null)
                {
                    Form_IlceTanim form = new Form_IlceTanim(lkuIl.Text, Convert.ToInt32(lkuIl.EditValue), ilce_id, ilce_adi, 1);
                    form.ShowDialog();

                    lkuIl_Properties_EditValueChanged(null,null);

                }
            }
        }

        private void lkuIl_EditValueChanged(object sender, EventArgs e)
        {

        }  
    }
}
