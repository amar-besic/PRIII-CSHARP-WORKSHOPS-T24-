using FIT.Data.IspitIB210178;
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
            ucitajSat();

        }

        private void UcitajDrzave()
        {

            var Drzava = db.DrzaveIB210178.ToList();
            for (int i = 0; i < Drzava.Count(); i++)
            {
                Drzava[i].BrojGradova = db.GradoviIB210178.Where(x => x.DrzavaId == Drzava[i].Id).Count();
            }

            if (Drzava != null)
            {
                dgvDrzave.DataSource = null;
                dgvDrzave.DataSource = Drzava;
            }
        }

        private void Sat_Tick(object sender, EventArgs e)
        {
            ucitajSat();
        }

        private void ucitajSat()
        {
            tsslSat.Text = "Trenutno vrjeme: " + DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
