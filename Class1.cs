using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK1PA_exercises
{
    internal class Hypoteka
    {
        public decimal VyseUveru { get; set; }
        public decimal UrokSazba { get; set; }
        public int DobaSplaceni { get; set; }

        public Hypoteka(decimal vyseUveru, decimal urokSazba, int dobaSplaceni)
        {
            VyseUveru = vyseUveru;
            UrokSazba = urokSazba;
            DobaSplaceni = dobaSplaceni;
        }

        public decimal VypocetSplatky()
        {
            decimal v = 1 / (1 + (UrokSazba / 100 / 12));
            decimal vUmocnene = v;
            for (int i = 0; i < (DobaSplaceni * 12); i++)
            {
                vUmocnene = vUmocnene * v;
            }

            return Math.Round(((UrokSazba / 100 / 12) * VyseUveru) / (1 - vUmocnene),2);
        }



    }
}
