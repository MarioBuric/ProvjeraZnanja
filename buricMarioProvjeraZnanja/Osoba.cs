using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricMarioProvjeraZnanja
{
    class Osoba
    {
        string ime;
        string prezime;
        string oib;
        string datum;

        public Osoba()
        {
        }

        public Osoba(string ime, string prezime, string oib, string datum)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oib = oib;
            this.datum = datum;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Oib { get => oib; set => oib = value; }
        public string Datum { get => datum; set => datum = value; }

        
    }
}
