using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Locatie
    {
        public string NaamLocatie { get; } // readonly property

        public Locatie(string naamLocatie)
        {
            NaamLocatie = naamLocatie;
            doorgangen = new List<Doorgang>();
        }

        List<Doorgang> doorgangen;

        /// <summary>
        /// Maakt een doorgang van deze locatie (this) naar een andere.
        /// </summary>
        /// <param name="hal">De locatie waarnaar een 
        /// doorgang moet gemaakt worden</param>
        public void MaakDoorgangNaar(Locatie hal)
        {
            doorgangen.Add(new Doorgang(this, hal));
        }

        public static void MaakDoorgang(Locatie van, Locatie naar)
        {
            van.MaakDoorgangNaar(naar);
        }
    }
}
