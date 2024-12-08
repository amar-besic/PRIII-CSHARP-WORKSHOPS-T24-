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
            Dodljeljivanje();
        }

        private void Dodljeljivanje()
        {
            dgvDrzave.AutoGenerateColumns=false;

            var Drzave = db.DrzaveIB210178.ToList();

            dgvDrzave.DataSource = Drzave;
        }
    }
}
