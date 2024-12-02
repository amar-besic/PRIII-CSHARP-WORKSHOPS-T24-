using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210178
{
    public class PredmetiIB210178
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Semestar { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
