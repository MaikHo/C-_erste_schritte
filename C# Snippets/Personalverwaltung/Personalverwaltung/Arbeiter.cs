using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung {
    [Serializable]
    sealed class Arbeiter : Mitarbeiter { // von versiegelten Klassen kann nicht geerbt werden
        public double stdlohn { get; set; }

        public Arbeiter(string personalnr, string vorname, string nachname, double stdlohn) : base(personalnr, vorname, nachname) {
            this.stdlohn = stdlohn;
        }

        public override string Daten() {
            return "Arbeiter: " + this.personalnr + " " + this.vorname + " " + this.nachname + this.stdlohn +"\n";
        }

        public override string ToString() {
            return "Arbeiter: " + this.personalnr + " " + this.vorname + " " + this.nachname + this.stdlohn + "\n";
        }

    }

}
