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
    public partial class Form_TelefonTipiTanim : Form
    {
        int Id;
        int Updated;
        
        public Form_TelefonTipiTanim()
        {

            InitializeComponent();
        }
        public Form_TelefonTipiTanim(string tip,int ıd , int updated)
        {
            InitializeComponent();

            textEdit1.Text = tip;
            Id = ıd;
            Updated = updated;
        }
        public Form_TelefonTipiTanim( int updated)
        {
            InitializeComponent();
            
           
            Updated = updated;
        

           
        }

        


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            service.TelefonTipiKaydet(textEdit1.Text, Id, Updated);
            this.Close();
        }
    }
}
