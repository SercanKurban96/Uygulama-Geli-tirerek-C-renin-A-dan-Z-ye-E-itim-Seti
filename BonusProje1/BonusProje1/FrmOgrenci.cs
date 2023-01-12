using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9H60TTH\SERCANKURBAN;Initial Catalog=BonusOkul;Integrated Security=True");

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbKulubu.DisplayMember = "KULUPAD";
            CmbKulubu.ValueMember = "KULUPID";
            CmbKulubu.DataSource = dt;
            baglanti.Close();
        }
        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {

            if (RdbtnKiz.Checked == true)
            {
                c = "KIZ";
            }
            if (RdbtnErkek.Checked == true)
            {
                c = "ERKEK";
            }
            ds.OgrenciEkle(TxtAdi.Text, TxtSoyadi.Text, byte.Parse(CmbKulubu.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme Yapıldı");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void CmbKulubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TxtOgrenciid.Text = CmbKulubu.SelectedValue.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtOgrenciid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrenciid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "KIZ")
            {
                RdbtnKiz.Checked = true;
            }
            else
            {
                RdbtnErkek.Checked = true;
            }
            CmbKulubu.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void RdbtnKiz_CheckedChanged(object sender, EventArgs e)
        {
            c = "KIZ";
        }

        private void RdbtnErkek_CheckedChanged(object sender, EventArgs e)
        {
            c = "ERKEK";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtAdi.Text, TxtSoyadi.Text, byte.Parse(CmbKulubu.SelectedValue.ToString()), c, int.Parse(TxtOgrenciid.Text));
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(TxtAra.Text);
        }
    }
}
