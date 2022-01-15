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
    public partial class FrmDuyuruOlustur : Form
    {
        public FrmDuyuruOlustur()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand("select*from TblDuyurular", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmDuyuruOlustur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular(ICERIK) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richTextBoxDuyuru.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
        }

        string id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            richTextBoxDuyuru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text = id
;        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblDuyurular where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            bgl.baglanti().Close();
            Listele();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblDuyurular set ICERIK=@p1 where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richTextBoxDuyuru.Text);
            komut.Parameters.AddWithValue("@p2", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            Listele();
        }
    }
}
