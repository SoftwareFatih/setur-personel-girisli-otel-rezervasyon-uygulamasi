using setur.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setur
{
    public partial class frm_OtelEkle : Form
    {
        DBConnect conn = new DBConnect();
        public frm_OtelEkle()
        {
            InitializeComponent();
        }
        public frm_OtelEkle(int id)
        {
            InitializeComponent();
            otelGetir(id);
            btn_kaydet.Text = "GÜNCELLE";
            this.Text = "OTEL GÜNCELLE";
        }
        void otelGetir(int id)
        {
            string query = "select * from OTEL " +
                "where ID=" + id.ToString();
            DataTable table = conn.ExecuteTable(query);
            DataRow row = table.Rows[0];
            lbl_idBilgi.Text = row[0].ToString();
            txt_adi.Text = row["Adı"].ToString();
            txt_sehir.Text = row["Şehir"].ToString();
            txt_yildiz.Text = row["Yıldız"].ToString();
            txt_adres.Text = row["Adres"].ToString();
            txt_daireTipi.Text = row["DaireTipi"].ToString();
            lbl_id.Visible = true;
            lbl_idBilgi.Visible = true;


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string query;
            if (lbl_idBilgi.Text == "-1")
            {
                query = "insert into OTEL(Adı,Şehir,Yıldız,Adres,DaireTipi)" +
                    " values('" + txt_adi.Text + "','" + txt_sehir.Text + "'" +
                    ",'"+ txt_yildiz.Text+ "','" + txt_adres.Text + "','" + txt_daireTipi.Text + "')";
                conn.ExecuteNonQuery(query);
                MessageBox.Show("Kayıt Başarılı");
                txt_adi.Text = "";
                txt_sehir.Text = "";
                txt_yildiz.Text = "";
                txt_adres.Text = "";
                txt_daireTipi.Text = "";
            }
            else
            {
                query = "update OTEL set" +
                    " Adı='" + txt_adi.Text + "'," +
                    " Şehir='" + txt_sehir.Text + "'," +
                    " Yıldız='" + txt_yildiz.Text + "'," +
                    " Adres='" + txt_adres.Text + "'," +
                    " DaireTipi='" + txt_daireTipi.Text + "'" +
                    " where ID=" + lbl_idBilgi.Text;
                conn.ExecuteNonQuery(query);
                MessageBox.Show("Güncelleme Başarılı");
            }
            var f1 = (Otel)Application.OpenForms["Otel"];
            f1.otelGetir();
        }
    }
}
