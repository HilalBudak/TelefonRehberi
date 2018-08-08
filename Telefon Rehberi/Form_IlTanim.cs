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
    public partial class Form_IlTanim : Form
    {
        
        public int yeniId = 0;
        int Updated;
        int Id;

        public Form_IlTanim()
        {
            InitializeComponent();
        }

        public Form_IlTanim(int update_insert)
        {
            InitializeComponent();
            Updated = update_insert;

        }
        public Form_IlTanim(int id,int update_insert, string iladi)
        {
            InitializeComponent();
            Updated = update_insert;
            Id = id;
            txtIl.Text=iladi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            yeniId = service.IlKaydet(txtIl.Text, Id, Updated);
            this.Close();
        }


    }
}
