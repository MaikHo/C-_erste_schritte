using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {
    class Mitarbeiter {
        private int personalnummer;
        
        // Methoden - Syntax: [Zugriffsmodifizierer] Rückgabewert Bezeichner(){ }
        // Setter-Methode
        public void SetPersonalnummer(int personalnummer) {
            this.personalnummer = personalnummer;
        }

        // Getter-Methode
        public int GetPersonalnummer() {
            return this.personalnummer;
        }

        // Properties
        private string _nachname;
        public string nachname {
            set { // Set-Accessor
                this._nachname = value;
            }
            get { // Get-Accessor
                return this._nachname;
            }
        }

        // Property Kurzform / automatisch implementierte Eigenschaften
        public string vorname { get; set; }
        public double gehalt { get; set; }
        public byte urlaubstage { get; private set; }

        public void MacheUrlaub(byte anzahl_urlaubstage) {
            this.urlaubstage -= anzahl_urlaubstage;
        }

        public Mitarbeiter() {
            this.urlaubstage = 30;
        }

        public Mitarbeiter(string vorname, string nachname, int personalnummer, double gehalt) {
            this.vorname = vorname;
            this._nachname = nachname;
            this.personalnummer = personalnummer;
            this.gehalt = gehalt;
            this.urlaubstage = 30;
        }

    }
}
