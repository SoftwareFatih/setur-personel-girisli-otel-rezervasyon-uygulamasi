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
    public partial class Otel : Form
    {
        DBConnect dBConnect = new DBConnect();
        int otelID = -1;
        public Otel()
        {
            InitializeComponent();
        }

        private void Otel_Load(object sender, EventArgs e)
        {
            otelGetir();
        }
        public void otelGetir()
        {
            DataTable dataTable = new DataTable();
            dataTable = dBConnect.ExecuteTable("select * from OTEL");
            dgv_otel.DataSource = dataTable;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            frm_OtelEkle frm_otelEkle = new frm_OtelEkle();
            frm_otelEkle.ShowDialog();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            frm_OtelEkle frm_otelEkle = new frm_OtelEkle(otelID);
            frm_otelEkle.ShowDialog();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silmek istediğinize" +
                " emin misiniz!"
                , "Dikkat", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                string query = "delete from OTEL where ID=" +
                    "" + otelID.ToString();
                dBConnect.ExecuteNonQuery(query);
                MessageBox.Show("Otel Silindi");
                otelGetir();
            }
        }

        private void dgv_otel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                otelID = Convert.ToInt16(dgv_otel.SelectedRows[0].Cells[0].Value);
                btn_guncelle.Enabled = true;
                btn_sil.Enabled = true;
            }
            catch (Exception)
            {
                otelID = -1;
                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;
            }
        }
    }
}
