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
    public partial class Form_AdresTipiListe : Form
    {
        public Form_AdresTipiListe()
        {
            InitializeComponent();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {

            Form_AdresTipiTanım form = new Form_AdresTipiTanım();
            form.ShowDialog();
            adrestiplerigetir();
        }
        private void adrestiplerigetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.AdresTipiListesi();
            gridAdresTipi.DataSource = ds.Tables[0];
        }

        private void Form_AdresTipiListe_Load(object sender, EventArgs e)
        {
            adrestiplerigetir();
        }

        private void btnAdresTipiDuzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow selectedRow = gridAdresTipiVİew.GetFocusedDataRow();

            if (selectedRow != null)
            {
                string adrestipiadi = selectedRow["AdresTipiAdi"].ToString();
                int adrestipiid = Convert.ToInt32(selectedRow["AdresTipiId"]);

                Form_AdresTipiTanım form = new Form_AdresTipiTanım(adrestipiadi, 1, adrestipiid);
                form.ShowDialog();
                adrestiplerigetir();
            }

        }

      

       
    }
}
