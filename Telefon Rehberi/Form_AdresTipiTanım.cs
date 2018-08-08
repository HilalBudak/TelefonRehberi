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
    public partial class Form_AdresTipiTanım : Form

    {

        int Updated;
        int Id;

        public Form_AdresTipiTanım(string adrestipiadi, int updated)
        {
            InitializeComponent();
            Updated = updated;
            textEdit1.Text = adrestipiadi;

        }

        public Form_AdresTipiTanım(string adrestipiadi, int updated, int adrestipiid)
        {
            InitializeComponent();
            Updated = updated;
            textEdit1.Text = adrestipiadi;
            Id=adrestipiid;
            

        }
        public Form_AdresTipiTanım()
        {
            InitializeComponent();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            IdeaV2WBS.IdeaV2 service = new IdeaV2WBS.IdeaV2();
            service.AdresTipiKaydet( textEdit1.Text, Id, Updated);
            this.Close();
        }
    }

}
