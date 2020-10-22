using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung {
    class LohnBuchhaltung {

        public static double Einkommensberechnung(Mitarbeiter m) {
            double einkommen = 0;

            if (m is Angestellte) {
                einkommen = ((Angestellte)m).gehalt * .9;
            } else if (m is Arbeiter) {
                einkommen = ((Arbeiter)m).stdlohn * 160 * .9;
            }

            return einkommen;
        }

    }
}
