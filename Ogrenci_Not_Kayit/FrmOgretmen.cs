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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void OgrenciListesi()
        {
            SqlCommand komut = new SqlCommand("select*from TblOgrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewOgrenci.DataSource = dt;
        }
        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewNotlar.DataSource = dt;
        }

        public string numara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            labelOgretmenNumarasi.Text = numara;

            SqlCommand komut = new SqlCommand("select*from TblOgretmen where NUMARA = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelOgretmenAdi.Text = dr[1] + " " + dr[2];
            }
            bgl.baglanti().Close();

            OgrenciListesi();
            NotListesi();
        }
        //foto ekleme yapıldı
        string Fotograff;
        private void buttonFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fotograf = new OpenFileDialog();
            Fotograf.ShowDialog();
            string FotografYolu = Fotograf.FileName;
            pictureBoxOgrencifotusu.ImageLocation = FotografYolu;
            FotografYolu = Fotograff;
            //OpenFileDialog.ShowDialog();
            //Fotograf = OpenFileDialog.FileName();
            //pictureBoxOgrencifotusu.ImageLocation = Fotograf;
        }
        //not kaydedemiyor
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblOgrenci (ID,AD,SOYAD,NUMARA,SIFRE,FOTOGRAF) values (@p0,@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p0", textBoxOgrenciId.Text);
            komut.Parameters.AddWithValue("@p1", textBoxOgrenciAdi.Text);
            komut.Parameters.AddWithValue("@p2", textBoxOgrenciSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p4", textBoxOgrenciSifresi.Text);
            komut.Parameters.AddWithValue("@p5", pictureBoxOgrencifotusu.ImageLocation);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("insert into TblNotlar(Ad,Soyad,Sınav1,Sınav2,Sınav3,Proje,Ortalama,Durum,Numara) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) where OGRID=(select ID from TblOgrenci where Numara=@p9)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBoxOgrenciAdi.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxOgrenciSoyadi.Text);
            komut2.Parameters.AddWithValue("@p3", textBoxSınav1.Text);
            komut2.Parameters.AddWithValue("@p4", textBoxSınav2.Text);
            komut2.Parameters.AddWithValue("@p5", textBoxSınav3.Text);
            komut2.Parameters.AddWithValue("@p6", textBoxProje.Text);
            komut2.Parameters.AddWithValue("@p7", Convert.ToDecimal(textBoxOrtalama.Text));
            komut2.Parameters.AddWithValue("@p8", textBoxDurum.Text);
            komut2.Parameters.AddWithValue("@p9", maskedTextBoxOgrenciNumara.Text);
            komut2.ExecuteNonQuery();
           
            MessageBox.Show("Ogrenci sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgrenciListesi();
            NotListesi();
            bgl.baglanti().Close();
        }
       
        // düzeltildi
        private void dataGridViewOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewOgrenci.SelectedCells[0].RowIndex;
            textBoxOgrenciId.Text = dataGridViewOgrenci.Rows[secilen].Cells[0].Value.ToString();
            textBoxOgrenciAdi.Text = dataGridViewOgrenci.Rows[secilen].Cells[1].Value.ToString();
            textBoxOgrenciSoyadi.Text = dataGridViewOgrenci.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBoxOgrenciNumara.Text = dataGridViewOgrenci.Rows[secilen].Cells[3].Value.ToString();
            textBoxOgrenciSifresi.Text = dataGridViewOgrenci.Rows[secilen].Cells[4].Value.ToString();
            pictureBoxOgrencifotusu.ImageLocation= dataGridViewOgrenci.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("select*from TblNotlar where OGRID = (select ID from TblOgrenci where NUMARA = @p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxOgrenciNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxSınav1.Text = dr[1].ToString();
                textBoxSınav2.Text = dr[2].ToString();
                textBoxSınav3.Text = dr[3].ToString();
                textBoxProje.Text = dr[4].ToString();
                textBoxOrtalama.Text = dr[5].ToString();
                textBoxDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }
        //düzeltildi
        private void dataGridViewOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewOgrenci.SelectedCells[0].RowIndex;
            textBoxOgrenciId.Text = dataGridViewOgrenci.Rows[secilen].Cells[0].Value.ToString();
            textBoxOgrenciAdi.Text = dataGridViewOgrenci.Rows[secilen].Cells[1].Value.ToString();
            textBoxOgrenciSoyadi.Text = dataGridViewOgrenci.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBoxOgrenciNumara.Text = dataGridViewOgrenci.Rows[secilen].Cells[3].Value.ToString();
            textBoxOgrenciSifresi.Text = dataGridViewOgrenci.Rows[secilen].Cells[4].Value.ToString();
            pictureBoxOgrencifotusu.ImageLocation= dataGridViewOgrenci.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("select*from TblNotlar where OGRID = (select ID from TblOgrenci where NUMARA = @p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxOgrenciNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxSınav1.Text = dr[1].ToString();
                textBoxSınav2.Text = dr[2].ToString();
                textBoxSınav3.Text = dr[3].ToString();
                textBoxProje.Text = dr[4].ToString();
                textBoxOrtalama.Text = dr[5].ToString();
                textBoxDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        //sorunsuz calısıyor
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblOgrenci set AD=@p1, SOYAD=@p2, SIFRE = @p3, FOTOGRAF=@p5 where NUMARA = @p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxOgrenciAdi.Text);
            komut.Parameters.AddWithValue("@p2", textBoxOgrenciSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", textBoxOgrenciSifresi.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p5", pictureBoxOgrencifotusu.ImageLocation);
            komut.ExecuteNonQuery();
            

            SqlCommand komut2 = new SqlCommand("update TblNotlar set Sınav1=@p1, Sınav2=@p2, Sınav3=@p3, Proje = @p4,Ortalama=@p5,Durum=@p6 where OGRID=(select ID from TblOgrenci where Numara=@p7)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBoxSınav1.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxSınav2.Text);
            komut2.Parameters.AddWithValue("@p3", textBoxSınav3.Text);
            komut2.Parameters.AddWithValue("@p4", textBoxProje.Text);
            komut2.Parameters.AddWithValue("@p5",Convert.ToDecimal(textBoxOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6", textBoxDurum.Text);
            komut2.Parameters.AddWithValue("@p7", maskedTextBoxOgrenciNumara.Text);
            komut2.ExecuteNonQuery();

            MessageBox.Show("Ogrenci bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }
        //hesaplama doğru calısıyor
        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, sınav3, proje, ortalama;
            sınav1 = Convert.ToDouble(textBoxSınav1.Text);
            sınav2 = Convert.ToDouble(textBoxSınav2.Text);
            sınav3 = Convert.ToDouble(textBoxSınav3.Text);
            proje = Convert.ToDouble(textBoxProje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            textBoxOrtalama.Text = ortalama.ToString();
            if (ortalama<=50)
            {
                textBoxDurum.Text = "False";
            }
            else
            {
                textBoxDurum.Text = "True";
            }
        }

        private void buttonDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FrmDuyuruOlustur frm = new FrmDuyuruOlustur();
            frm.Show();
        }

        private void buttonDuyuruListesi_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void buttonMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = labelOgretmenNumarasi.Text;
            frm.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //notları getiriyor texboxlara ama buradan tıklayınca güncelleyemiyoruz
        private void dataGridViewNotlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewOgrenci.SelectedCells[0].RowIndex;
           // textBoxOgrenciId.Text = dataGridViewOgrenci.Rows[secilen].Cells[0].Value.ToString();
            textBoxOgrenciAdi.Text = dataGridViewNotlar.Rows[secilen].Cells[0].Value.ToString();
            textBoxOgrenciSoyadi.Text = dataGridViewNotlar.Rows[secilen].Cells[1].Value.ToString();
            textBoxSınav1.Text = dataGridViewNotlar.Rows[secilen].Cells[2].Value.ToString();
            textBoxSınav2.Text = dataGridViewNotlar.Rows[secilen].Cells[3].Value.ToString();
            textBoxSınav3.Text = dataGridViewNotlar.Rows[secilen].Cells[4].Value.ToString();
            textBoxProje.Text = dataGridViewNotlar.Rows[secilen].Cells[5].Value.ToString();
            textBoxOrtalama.Text = dataGridViewNotlar.Rows[secilen].Cells[6].Value.ToString();
            textBoxDurum.Text = dataGridViewNotlar.Rows[secilen].Cells[7].Value.ToString();
           // maskedTextBoxOgrenciNumara.Text = dataGridViewOgrenci.Rows[secilen].Cells[3].Value.ToString();
           // textBoxOgrenciSifresi.Text = dataGridViewOgrenci.Rows[secilen].Cells[4].Value.ToString();
           // pictureBoxOgrencifotusu.ImageLocation= dataGridViewOgrenci.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("select*from TblNotlar where OGRID = (select ID from TblOgrenci where NUMARA = @p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxOgrenciNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxSınav1.Text = dr[1].ToString();
                textBoxSınav2.Text = dr[2].ToString();
                textBoxSınav3.Text = dr[3].ToString();
                textBoxProje.Text = dr[4].ToString();
                textBoxOrtalama.Text = dr[5].ToString();
                textBoxDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
