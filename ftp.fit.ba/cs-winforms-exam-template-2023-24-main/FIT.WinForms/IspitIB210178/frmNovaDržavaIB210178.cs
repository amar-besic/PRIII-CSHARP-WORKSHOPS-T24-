﻿using FIT.Data;
using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmNovaDržavaIB210178 : Form
    {

        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaDržavaIB210178()
        {
            InitializeComponent();
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (ofdZastava.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(ofdZastava.FileName);
               
            }


        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var Zastava = pbZastava.Image.ToByteArray();
                var Naziv = tbNaziv.Text;
                var Status = cbAktivan.Checked;


                var novaDrzava = new DrzaveIB210178()
                {
                    Naziv = Naziv,
                    Status = Status,
                    Zastava = Zastava
                };

                db.DrzaveIB210178.Add(novaDrzava);
                db.SaveChanges();
                DialogResult = DialogResult.OK; 
                
            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue) &&
                    Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue);


        }
    }
}
