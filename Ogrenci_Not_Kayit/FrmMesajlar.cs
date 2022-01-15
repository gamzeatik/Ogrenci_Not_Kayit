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

namespace Ogrenci_Not_Kayit
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void GelenMesajlar()
        {
            SqlCommand komut = new SqlCommand("select*from TblMesajlar where ALICI = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewGelenKutusu.DataSource = dt;
        }
        void GidenMesajlar()
        {
            SqlCommand komut = new SqlCommand("select*from TblMesajlar where GONDEREN =@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewGidenKutusu.DataSource= dt;
        }

        public string numara;
        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            maskedTextBoxGonderen.Text = numara;
            GelenMesajlar();
            GidenMesajlar();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblMesajlar (GONDEREN,ALICI,BASLIK,ICERIK) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxGonderen.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBoxAlici.Text);
            komut.Parameters.AddWithValue("@p3", textBoxKonu.Text);
            komut.Parameters.AddWithValue("@p4", richTextBoxIcerik.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesaj iletildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            GelenMesajlar();
            GidenMesajlar();
        }

        private void dataGridViewGelenKutusu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewGelenKutusu.SelectedCells[0].RowIndex;
            maskedTextBoxGonderen.Text = dataGridViewGelenKutusu.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBoxAlici.Text = dataGridViewGelenKutusu.Rows[secilen].Cells[2].Value.ToString();
            textBoxKonu.Text = dataGridViewGelenKutusu.Rows[secilen].Cells[3].Value.ToString();
            richTextBoxIcerik.Text = dataGridViewGelenKutusu.Rows[secilen].Cells[4].Value.ToString();
        }

        private void dataGridViewGidenKutusu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewGidenKutusu.SelectedCells[0].RowIndex;
            maskedTextBoxGonderen.Text = dataGridViewGidenKutusu.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBoxAlici.Text = dataGridViewGidenKutusu.Rows[secilen].Cells[2].Value.ToString();
            textBoxKonu.Text = dataGridViewGidenKutusu.Rows[secilen].Cells[3].Value.ToString();
            richTextBoxIcerik.Text = dataGridViewGidenKutusu.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
