using setur.DataBase;
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

namespace setur
{
    public partial class frm_rezervasyonEkle : Form
    {
        DBConnect dBConnect = new DBConnect();
        public frm_rezervasyonEkle()
        {
            InitializeComponent();
        }

        private void frm_rezervasyonEkle_Load(object sender, EventArgs e)
        {
            verileriGetir();
        }
        void verileriGetir()
        {
            DataTable table = new DataTable();
            table = dBConnect.ExecuteTable("select * from OTEL");
            cb_otel.DataSource = new BindingSource(table, null);
            cb_otel.DisplayMember = "Adı"; //kolon adi görüntülenecek
            cb_otel.ValueMember = "ID"; //arkaplanda saklanacak veri

            DataTable tablePersonel = new DataTable();
            tablePersonel = dBConnect.ExecuteTable("select * from PERSONEL");
            cb_personel.DataSource = new BindingSource(tablePersonel, null);
            cb_personel.DisplayMember = "ADI"; //kolon adi görüntülenecek
            cb_personel.ValueMember = "ID"; //arkaplanda saklanacak veri
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string query;
            if (lbl_idBilgi.Text == "-1")
            {
                query = "insert into REZERVASYON(MusteriAdı,MusteriSoyadi,OtelID" +
                    ",BaslangicTarihi,BitisTarihi,Odeme,PersonelID)" +
                    " values('" + txt_musteriAdi.Text + "'";
                query += ",'" + txt_musteriSoyadi.Text + "'";
                query += "," + cb_otel.ValueMember + "";
                query += ",'" + dtp_baslangicTarihi.Value + "'";
                query += ",'" + dtp_bitisTarihi.Value+ "'";
                query += ",'" + txt_odeme.Text + "'";
                query += "," + cb_personel.ValueMember + "";
                query += ")";
                dBConnect.ExecuteNonQuery(query);
                MessageBox.Show("Rezervasyon Yapıldı");
               
            }
            else
            {
                //query = "update PERSONEL set" +
                //    " ADI='" + txt_adi.Text + "'," +
                //    " SOYADI='" + txt_soyadi.Text + "'" +
                //    " where ID=" + lbl_idBilgi.Text;
                //conn.ExecuteNonQuery(query);
                //MessageBox.Show("Güncelleme Başarılı");
            }
            var f1 = (Personel)Application.OpenForms["Personel"];
            //f1.personelGetir();
        }
    }
}
