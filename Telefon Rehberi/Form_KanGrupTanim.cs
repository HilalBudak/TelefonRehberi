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
    public partial class Form_KanGrupTanim : Form
    {
        int update;
        int id;

        public Form_KanGrupTanim()
        {
            InitializeComponent();
        }
        public Form_KanGrupTanim(int updated) 
        {
            InitializeComponent();
            update = updated;
        }
        public Form_KanGrupTanim(int idd, int updated, string isim)
        {
            InitializeComponent();
            update = updated;
            id = idd;
            txtKan.Text = isim;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            service.KanGruplariKaydet(txtKan.Text, id, update);
            this.Close();

        }
    }
}
