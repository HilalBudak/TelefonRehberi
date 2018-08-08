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
    public partial class Form_KanGrupListe : Form
    {
        public Form_KanGrupListe()
        {
            InitializeComponent();
        }

        private void kanGruplariGetir()
        {
            IdeaV2WBS.IdeaV2 Serv = new IdeaV2WBS.IdeaV2();
            DataSet ds = Serv.KanGruplariListesi();
            gridKanGrup.DataSource = ds.Tables[0];
        }
        private void Form_KanGrupListe_Load(object sender, EventArgs e)//refresh için gerekli
        {
            kanGruplariGetir();
        }

        private void btnDuzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow selectedRow = gridKanGrupView.GetFocusedDataRow();

            if (selectedRow != null)
            {
                string adi = selectedRow["KanGrubuAdi"].ToString();
                int id = Convert.ToInt32(selectedRow["KanGrubuId"]);

                Form_KanGrupTanim form = new Form_KanGrupTanim(id, 1, adi);
                form.ShowDialog();
                kanGruplariGetir();
            }
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Form_KanGrupTanim kan = new Form_KanGrupTanim();
            kan.ShowDialog();
            kanGruplariGetir();
        }
    }
}
