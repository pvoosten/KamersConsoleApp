using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Level
    {
        public Level(Locatie buiten)
        {
            Startpositie = buiten;
        }

        public Locatie Startpositie { get; }

        public void ZetSpelerInLevel(Speler speler)
        {
            // plaats de speler in de startruimte
            throw new NotImplementedException();
        }
    }
}
