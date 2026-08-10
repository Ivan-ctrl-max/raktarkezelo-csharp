using System;

namespace Raktarkezelo
{
    public class Termek
    {
        public string Nev { get; set; }
        public int Ar { get; set; }
        public int Darab { get; set; }

        public Termek(string nev, int ar, int darab)
        {
            this.Nev = nev;
            this.Ar = ar;
            this.Darab = darab;
        }

        public int GetOsszErtek()
        {
            return Ar * Darab;
        }
    }
}