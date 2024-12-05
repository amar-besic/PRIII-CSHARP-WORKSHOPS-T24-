using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210178
{
    public class SemestriIB210178
    {
        public int Id { get; set; }
        public int Oznaka { get; set; }
        public int Opis { get; set; }
        public int Aktivan { get; set; }

        public override string ToString()   {
            return Oznaka.ToString();
        }
    }
}
