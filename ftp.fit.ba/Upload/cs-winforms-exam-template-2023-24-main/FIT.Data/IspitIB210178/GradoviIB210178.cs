using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210178
{
    public class GradoviIB210178
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public int DrzavaId { get; set; }
        public DrzaveIB210178 Drzava { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
