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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

       public string numara;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            labelNumara.Text = numara;

            SqlCommand komut = new SqlCommand("select*from TblOgrenci where NUMARA=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[1] + " " + dr[2];
                pictureBoxOgrenci.ImageLocation = dr[5].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select*from TblNotlar where OGRID=(select ID from TblOgrenci where NUMARA=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", labelNumara.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Sınav1.Text = dr2[1].ToString();
                Sınav2.Text = dr2[2].ToString();
                Sınav3.Text = dr2[3].ToString();
                Proje.Text = dr2[4].ToString();
                Ortalama.Text = dr2[5].ToString();
            }
            bgl.baglanti().Close();
            if (Convert.ToDouble(Ortalama.Text)>=50)
            {
                Durum.Text = "Geçti";
            }
            else
            {
                Durum.Text = "Kaldı";
            }
        }

        private void buttonMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = labelNumara.Text;
            frm.Show();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void buttonHesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gercekten kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
