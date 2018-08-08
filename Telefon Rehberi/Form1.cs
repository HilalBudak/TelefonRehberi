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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtad.BackColor = Color.Aqua;

            HelinWBS.HelinService serv = new HelinWBS.HelinService();

            DataSet ds = serv.EgitimDurumlariLoad();
            DataSet ds2 = serv.SektorLoad();

            //DataSet ds = serv.SektorLoad();
           

            //DataRow newRow = ds.Tables[0].NewRow();
            //newRow["egitimdurum_id"] = -1;
            //newRow["egitimdurum_adi"] = DBNull.Value;
            //ds.Tables[0].Rows.Add(newRow);
            //ds.Tables[0].Rows.InsertAt(newRow, 0);

            if (ds != null && ds.Tables.Count > 0)
            {
                cmbEgitimDurumlari.DataSource = ds.Tables[0];
                cmbEgitimDurumlari.SelectedValue = 8;
            }
            
            if (ds2 != null && ds2.Tables.Count > 0)
            {
                cmbsektor.DataSource = ds2.Tables[0];
                             
            }
            //CinsiyetLoad_1();
            CinsiyetLoad_3();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //string ad, soyad;

            //ad = txtad.Text;
            //soyad = txtsoyad.Text;

            /********************************/

            Kisi yeniKisi = new Kisi();

            yeniKisi.Ad = txtad.Text;
            yeniKisi.Soyad = txtsoyad.Text;
            yeniKisi.Tckn = txtTckn.Text;
            yeniKisi.Aciklama = txtkisiaciklama.Text;
            yeniKisi.DogumTarihi = dteDogumTarihi.Value;
            yeniKisi.EgitimDurumuID = Convert.ToInt32( cmbEgitimDurumlari.SelectedValue);
            yeniKisi.Cinsiyet = cmbCinsiyet.SelectedValue.ToString();
            yeniKisi.sektorid =Convert.ToInt32(cmbsektor.SelectedValue);

            int KisiId = 0;
            string sonuc = "";

            yeniKisi.KisiKaydet(yeniKisi, out KisiId, out sonuc);

            if (KisiId > 0)
            {
                txtKisiNo.Text = KisiId.ToString();
                MessageBox.Show(sonuc);
            }
            else
            {
                MessageBox.Show(sonuc);
            }

        }

        private void txtTckn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CinsiyetLoad_1()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Cinsiyet");

            //DataRow row = dt.NewRow();
            //row["Cinsiyet"] = "";
            //dt.Rows.Add(row);

            //DataRow row3 = dt.NewRow();
            //row3["Cinsiyet"] = "Erkek";
            //dt.Rows.Add(row3);

            //DataRow row2 = dt.NewRow();
            //row2["Cinsiyet"] = "Kadın";
            //dt.Rows.Add(row2);

            //cmbCinsiyet.DataSource = dt;
            //cmbCinsiyet.DisplayMember = "Cinsiyet";
            //cmbCinsiyet.ValueMember = "Cinsiyet";

            /***********************************************/

            DataTable dt = new DataTable();
            dt.Columns.Add("Cinsiyet");

            DataRow row = dt.NewRow();
            row["Cinsiyet"] = "";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Cinsiyet"] = "Erkek";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Cinsiyet"] = "Kadın";
            dt.Rows.Add(row);

            cmbCinsiyet.DataSource = dt;
            cmbCinsiyet.DisplayMember = "Cinsiyet";
            cmbCinsiyet.ValueMember = "Cinsiyet";
        }

        private void CinsiyetLoad_2()
        {
            String[] cinsiyetList = new String[]{" ","Erkek","Kadın"};

            cmbCinsiyet.DataSource = cinsiyetList;
        }

        private void CinsiyetLoad_3()
        {
            //List<Cinsiyet> cinsList = new List<Cinsiyet>();

            //Cinsiyet cins1 = new Cinsiyet();
            //cins1.cinsiyet = "";
            //cinsList.Add(cins1);

            //Cinsiyet cins2 = new Cinsiyet();
            //cins2.cinsiyet = "Kadın";
            //cinsList.Add(cins2);

            //Cinsiyet cins3 = new Cinsiyet();
            //cins3.cinsiyet = "Erkek";
            //cinsList.Add(cins3);

            //cmbCinsiyet.DataSource = cinsList;
            //cmbCinsiyet.DisplayMember = "Cinsiyet";
            //cmbCinsiyet.ValueMember = "Cinsiyet";


            /******/

            List<Cinsiyet> cinsList = new List<Cinsiyet>();

            Cinsiyet cins = new Cinsiyet();
            cins.cinsiyet = "";
            cinsList.Add(cins);

            cins = new Cinsiyet();
            cins.cinsiyet = "Kadın";
            cinsList.Add(cins);

            cins = new Cinsiyet();
            cins.cinsiyet = "Erkek";
            cinsList.Add(cins);

            cmbCinsiyet.DataSource = cinsList;
            cmbCinsiyet.DisplayMember = "Cinsiyet";
            cmbCinsiyet.ValueMember = "Cinsiyet";
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
