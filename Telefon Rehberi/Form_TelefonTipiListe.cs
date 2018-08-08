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
    public partial class Form_TelefonTipiListe : Form
    {
        public Form_TelefonTipiListe()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form_TelefonTipiTanim form = new Form_TelefonTipiTanim(0);
            form.ShowDialog();
            TelefonTipigetir();
        }
        

        private void Form_TelefonTipiListe_Load(object sender, EventArgs e)
        {
            TelefonTipigetir();
        }
        private void TelefonTipigetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.TelefonTipiListesi();
            gridControl1.DataSource = ds.Tables[0];
        }

        private void TelefonTipiDüzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             DataRow selectedRow = gridView1.GetFocusedDataRow();

             if (selectedRow != null)
             {
                 string Tipadi = selectedRow["TelefonTipiAdi"].ToString();
                 int TelefonTipiid = Convert.ToInt32(selectedRow["TelefonTipiId"]);

                 Form_TelefonTipiTanim form = new Form_TelefonTipiTanim(Tipadi,TelefonTipiid, 1 );
                 form.ShowDialog();
                 TelefonTipigetir();
             }
        }
    }
}
