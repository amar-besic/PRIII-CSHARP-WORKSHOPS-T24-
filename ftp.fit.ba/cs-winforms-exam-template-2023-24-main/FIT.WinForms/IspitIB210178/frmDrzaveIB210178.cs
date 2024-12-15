using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            Dodljeljivanje();
        }

        private void Dodljeljivanje()
        {

            var Drzave = db.DrzaveIB210178.ToList();
            var Gradovi = db.GradoviIB210178.ToList();
            
            
            for (int i = 0; i < db.GradoviIB210178.Count(); i++)    {
                for (int j = 0; j < db.DrzaveIB210178.Count(); j++) {
                    if (Gradovi[i].DrzavaId == Drzave[j].Id)
                        Drzave[j].brojGradova += 1;
                }
            }
            
            
            dgvDrzave.DataSource = Drzave;
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var otvoriNovaDrzava = new frmNovaDržavaIB210178();

            if(otvoriNovaDrzava.ShowDialog()== DialogResult.OK)
            {
                Dodljeljivanje();
            }
            
        }

    }
}
