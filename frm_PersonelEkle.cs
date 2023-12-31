﻿using setur.DataBase;
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
    public partial class frm_PersonelEkle : Form
    {
        DBConnect conn = new DBConnect();
        public frm_PersonelEkle()
        {
            InitializeComponent();
        }
        public frm_PersonelEkle(int id)
        {
            InitializeComponent();
            personelGetir(id);
            btn_kaydet.Text = "GÜNCELLE";
            this.Text = "PERSONEL GÜNCELLE";

        }
        void personelGetir(int id)
        {
            string query = "select * from PERSONEL " +
                "where ID=" + id.ToString();
            DataTable table = conn.ExecuteTable(query);
            DataRow row = table.Rows[0];
            lbl_idBilgi.Text = row[0].ToString();
            txt_adi.Text = row["ADI"].ToString();
            txt_soyadi.Text = row["SOYADI"].ToString();
            lbl_id.Visible = true;
            lbl_idBilgi.Visible = true;


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string query;
            if (lbl_idBilgi.Text=="-1")
            {
                query = "insert into PERSONEL(ADI,SOYADI)" +
                    " values('" + txt_adi.Text + "','" + txt_soyadi.Text + "')";
                conn.ExecuteNonQuery(query);
                MessageBox.Show("Kayıt Başarılı");
                txt_adi.Text = "";
                txt_soyadi.Text = "";
            }
            else
            {
                query = "update PERSONEL set" +
                    " ADI='" + txt_adi.Text + "'," +
                    " SOYADI='" + txt_soyadi.Text + "'" +
                    " where ID=" + lbl_idBilgi.Text;
                conn.ExecuteNonQuery(query);
                MessageBox.Show("Güncelleme Başarılı");
            }
            var f1 = (Personel)Application.OpenForms["Personel"];
            f1.personelGetir();
        }
    }
}
