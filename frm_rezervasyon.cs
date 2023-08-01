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
    public partial class frm_rezervasyon : Form
    {
        public frm_rezervasyon()
        {
            InitializeComponent();
        }

        private void btn_rezervasyonEkle_Click(object sender, EventArgs e)
        {
            frm_rezervasyonEkle frm_rezervasyonEkle = new frm_rezervasyonEkle();
            frm_rezervasyonEkle.ShowDialog();
        }
    }
}
