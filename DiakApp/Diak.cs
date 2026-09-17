using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public double Atlag { get; set; }
        public Diak()
        {
            Nev = "Kiss Peter";
            Atlag = 4.5;
        }
        public Diak (string kapottnev, double kapottatlag)
        {
            Nev = kapottnev;
            Atlag = kapottatlag;
        }
        public Diak(string csaknev)
        {
            Nev = csaknev;
            Atlag=2.5;
        }
    }
}
