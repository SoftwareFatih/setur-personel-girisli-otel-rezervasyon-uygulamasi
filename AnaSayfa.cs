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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            var f1 = (Personel)Application.OpenForms["Personel"];
            if (f1 == null)
            {
                personel.MdiParent = this;
                personel.Dock = DockStyle.Fill;
                personel.Show();
            }
        }

        private void oTELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otel otel = new Otel();
            var f1 = (Otel)Application.OpenForms["Otel"];
            if (f1 == null)
            {
                otel.MdiParent = this;
                otel.Dock = DockStyle.Fill;
                otel.Show();
            }
        }

        private void rEZERVASYONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rezervasyon rezervasyon = new frm_rezervasyon();
            var f1 = (frm_rezervasyon)Application.OpenForms["frm_rezervasyon"];
            if (f1 == null)
            {
                rezervasyon.MdiParent = this;
                rezervasyon.Dock = DockStyle.Fill;
                rezervasyon.Show();
            }
        }
    }
}
