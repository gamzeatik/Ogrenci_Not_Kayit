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
    public partial class FrmDuyuruListesi : Form
    {
        public FrmDuyuruListesi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDuyuruListesi_Load(object sender, EventArgs e)
        {
            ListBox lst = new ListBox();
            Point lstkonum = new Point(10, 10);
            lst.Name = "ListBox1";
            lst.Height = 1820;
            lst.Width = 864;
            lst.Font = new Font("Georgia", 14, FontStyle.Regular);
            lst.Location = lstkonum;
            this.Controls.Add(lst);

            SqlCommand komut = new SqlCommand("select*from TblDuyurular", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lst.Items.Add(dr[0] + " "+dr[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
