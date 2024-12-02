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
            
            ucitajDrzave();
        }

        private void ucitajDrzave()
        {
            
            var drzave = db.DrzaveIB210178.ToList();
            if (drzave.Count != 0) {
                dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = drzave;
               
            }
            
            
        }
    }
}
