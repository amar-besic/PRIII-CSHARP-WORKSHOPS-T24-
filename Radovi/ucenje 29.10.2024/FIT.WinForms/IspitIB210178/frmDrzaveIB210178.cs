using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB210178
{
    public partial class frmDrzaveIB210178 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmDrzaveIB210178()
        {
            InitializeComponent();
        }

        private void frmDrzaveIB210178_Load(object sender, EventArgs e)
        {

            dgvDrzave.AutoGenerateColumns = false;

            UcitajDrzave();
            UcitajVrijeme();

        }

        private void UcitajDrzave()
        {

            // drzave[0] = BIH --> Brojgradova -> 2
            // drzave[1] = JPN --> Brojgradova -> 1
            // drzave[2] = PAL --> Brojgradova -> 1

            var drzave = db.DrzaveIB210178.ToList();

            for (int i = 0; i < drzave.Count(); i++)
            {
                drzave[i].Brojgradova = db.GradoviIB210178
                    .Where(x => x.DrzavaId == drzave[i].Id)
                    .Count();
            }

            if (drzave != null)
            {
                dgvDrzave.DataSource = null;
                dgvDrzave.DataSource = drzave;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UcitajVrijeme();
        }

        private void UcitajVrijeme()
        {
            tsslSat.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void btnDržave_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIB210178 frmNova = new frmNovaDrzavaIB210178();

            if(frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajDrzave();
            }
        }
    }
}
