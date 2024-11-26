using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varosok_JobbagyMate
{
    internal class VarosAdatok
    {
        public string VarosNev { get; set; }
        public string OrszagNev { get; set; }
        public float Nepesseg { get; set; }

        public VarosAdatok(string s)
        {
            string[] v = s.Split(';');
            VarosNev = v[0];
            OrszagNev = v[1];
            Nepesseg = float.Parse(v[2]);
        }
    }
}
