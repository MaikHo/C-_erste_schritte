using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int zahl { get; set; }

        /// <summary>
        /// Meine Testmethode
        /// </summary>
        /// <param name="value">Wert für dies und das</param>
        /// <returns>Return Wert</returns>
        public string Testmethode(int value) {
            return "Ihre Zahl ist: " + value;
        }

        // https://msdn.microsoft.com/de-de/library/5ast78ax.aspx
    }
}
