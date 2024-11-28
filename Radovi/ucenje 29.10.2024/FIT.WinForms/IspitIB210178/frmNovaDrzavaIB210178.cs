using FIT.Data;
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
    public partial class frmNovaDrzavaIB210178 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaDrzavaIB210178()
        {
            InitializeComponent();
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // D:\FIT\C-SHARP-ISPITNI\Slike helpers\egy.png
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);

            }


        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (Validiraj())
            {

                var naziv = tbNaziv.Text;
                var status = chbStatus.Checked; // true false

                // IMAGE -> BYTE[]
                var zastava = Ekstenzije.ToByteArray(pbZastava.Image);

                var novaDrzava = new DrzaveIB210178()
                {

                    //Id = 4, PUCA BAZA 
                    //Brojgradova = 5, PUCA BAZA 
                    Naziv = naziv,
                    Status = status,
                    Zastava = zastava

                    

                };

                db.DrzaveIB210178.Add(novaDrzava);
                db.SaveChanges();


                DialogResult = DialogResult.OK;

            }


        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbZastava, err,Kljucevi.ReqiredValue) && 
                Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue);
        }
    }
}
