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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelOgrenciNumara_Click(object sender, EventArgs e)
        {

        }

        //ogretmen no sifre kontrolü 
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void buttonOgretmenGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from TblOgretmen where NUMARA=@p1 and SIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxOgretmenNumara.Text);
            komut.Parameters.AddWithValue("@p2", textBoxOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmen frm = new FrmOgretmen();
                frm.numara = maskedTextBoxOgretmenNumara.Text;
                frm.Show();
                MessageBox.Show("Sisteme hosgeldiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı numara ya da sifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }

        private void buttonOgrenciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from TblOgrenci where NUMARA =@p1 and SIFRE =@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p2", textBoxOgrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenci frm = new FrmOgrenci();
                frm.numara = maskedTextBoxOgrenciNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı numara ya da sifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }
    }
}
