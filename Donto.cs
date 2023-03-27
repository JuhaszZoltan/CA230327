using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA230327
{
    internal class Donto
    {
        public RomaiSorszam Ssz { get; set; }
        public DateTime Datum { get; set; }
        public string Gyoztes { get; set; }
        public string Eredmeny { get; set; }
        public string Vesztes { get; set; }
        public string Helyszin { get; set; }
        public string VarosAllam { get; set; }
        public int Nezoszam { get; set; }
        public int GyoztesPont { get; private set; }
        public int VesztesPont { get; private set; }

        public Donto(string s)
        {
            string[] v = s.Split(';');
            Ssz = new RomaiSorszam(v[0]);
            Datum = DateTime.Parse(v[1]);
            Gyoztes = v[2];
            Eredmeny = v[3];
            string[] w = v[3].Split('-');
            GyoztesPont = int.Parse(w[0]);
            VesztesPont = int.Parse(w[1]);
            Vesztes = v[4];
            Helyszin = v[5];
            VarosAllam = v[6];
            Nezoszam = int.Parse(v[7]);
        }  
    }
}
