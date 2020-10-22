using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung {
    [Serializable]
    public abstract class Mitarbeiter { // von abstrakten Klassen können keine Objekte instanziiert werden
        public string personalnr { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }

        public Mitarbeiter(string personalnr, string vorname, string nachname) {
            this.personalnr = personalnr;
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public Mitarbeiter() {

        }

        // virtuelle Methoden können in abgeleiteten Klassen überschrieben
        public virtual string Daten() {
            return "Mitarbeiter: " + this.personalnr + " " + this.vorname + " " + this.nachname + "\n";
        }

    }
}
