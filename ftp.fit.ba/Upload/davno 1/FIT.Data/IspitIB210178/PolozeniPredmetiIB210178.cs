using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210178
{
    public class PolozeniPredmetiIB210178
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        Student Student { get; set; }   
        public int PredmetId { get; set; }
        PredmetiIB210178 Predmet {  get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}
