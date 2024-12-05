using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        }



        private void UcitajDrzave()
        {
            var drzave = db.DrzaveIB210178.ToList();
            var gradovi = db.GradoviIB210178.ToList();

            //------| brojenje gradova |----------------------
            for (int i = 0; i < gradovi.Count(); i++)     
                for (int j = 0; j < drzave.Count; j++)       
                    if (gradovi[i].DrzavaId == drzave[j].Id)   
                        drzave[j].brojGradova++;
           //-------------------------------------------------

            dgvDrzave.DataSource = drzave;


        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var frmNovaDrzava = new frmNovaDržavaIB210178();

            if(frmNovaDrzava.ShowDialog() == DialogResult.OK)
            {
                UcitajDrzave();
            }
        }
    }
}