using KamersModel;
using System;

namespace KamersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak level aan
            // maak speler aan
            // zet speler in speelruimte (beginpositie)
            // begin het spel: zorg dat opdrachten kunnen gegeven worden
            var level = MaakLevelAan();
            var speler = MaakSpelerAan();
            level.ZetSpelerInLevel(speler);
            SpeelLevel();
        }

        private static void SpeelLevel()
        {
            Console.WriteLine("start van het spel");
            string commando = "";
            while(commando != "stop")
            {
                switch (commando)
                {
                    case "wie ben ik":
                        // toon informatie over de speler
                        break;
                    case "waar ben ik":
                        // toon de naam van de ruimte waar de speler zich bevindt
                        break;
                    case "ga naar":
                        // verplaats de speler naar een ander ruimte
                        break;
                    case "help":
                        // toon de commando's die kunnen ingetypt worden
                        break;
                    default:
                        break;
                }
                commando = Console.ReadLine().Trim();
            }
        }

        private static Speler MaakSpelerAan()
        {
            throw new NotImplementedException();
        }

        private static Level MaakLevelAan()
        {
            // een level is bv een huis
            var buiten = new Locatie("Buiten");
            var hal = new Locatie("Inkomhal");
            var keuken = new Locatie("Keuken");
            var living = new Locatie("Living");
            // de doorgangen tussen de ruimtes
            buiten.MaakDoorgangNaar(hal);
            hal.MaakDoorgangNaar(keuken);
            hal.MaakDoorgangNaar(living);
            // volgende 2 lijnen doen identiek hetzelfde
            living.MaakDoorgangNaar(keuken);
            Locatie.MaakDoorgang(living, keuken);
            // Maak level aan en voeg de plaatsen eraan toe
            return new Level(buiten); // buiten is de startpositie voor een speler
        }
    }
}
