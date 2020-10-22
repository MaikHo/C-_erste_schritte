using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung {
    [Serializable]
    class Angestellte : Mitarbeiter {
        public double gehalt { get; set; }

        public Angestellte(string personalnr, string vorname, string nachname, double gehalt) : base(personalnr, vorname, nachname) {
            this.gehalt = gehalt;
           
        }

        public override string Daten() {
            return "Angestellte: " + this.personalnr + " " + this.vorname + " " + this.nachname + this.gehalt + "\n";
        }

        public override string ToString() {
            return "Angestellte: " + this.personalnr + " " + this.vorname + " " + this.nachname + this.gehalt + "\n";
        }

    }
}
