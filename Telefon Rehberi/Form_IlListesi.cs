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
    public partial class Form_IlListesi : Form
    {
        public Form_IlListesi()
        {
            InitializeComponent();
        }


        private void Form_IlListesi_Load(object sender, EventArgs e)
        {
            illerigetir();   
        }
      
        private void btnIlKayit_Click(object sender, EventArgs e)
        {
            Form_IlTanim form = new Form_IlTanim(0);
            form.ShowDialog();

            illerigetir();
        }

        private void illerigetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.IlListesi();
            gridIl.DataSource = ds.Tables[0];
        }

        private void btnIlDuzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
                //DataRow selectedRow = gridilceView.GetDataRow(gridilceView.FocusedRowHandle);
                DataRow selectedRow = gridilView.GetFocusedDataRow();

                if (selectedRow != null)
                {
                    string iladi = selectedRow["IlAd"].ToString();
                    int ilceid = Convert.ToInt32(selectedRow["IlId"]);

                        Form_IlTanim form = new Form_IlTanim( ilceid, 1, iladi);
                        form.ShowDialog();
                        illerigetir();
                }
            
        }

        private void gridIl_Click(object sender, EventArgs e)
        {

        }
    }
}
