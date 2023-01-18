using GeoProfs.Models;
using System;
using System.Linq;

namespace GeoProfs.Data
{
    public class DbInitializer
    {
        public static void Initialize(GeoProfsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Werknemers.Any())
            {
                return;
            }

            Werknemer[] werknemers = new Werknemer[]
            {
                new Werknemer{ Functie_id=1, Voornaam="Jan", Achternaam="Janssen", Geboortedatum=DateTime.Parse("1998-09-01"), BSN=879437407, Telefoonnummer=0621773094, Email="jan.janssen@yahoo.nl", Wachtwoord="jan", Contract_uren=40, Uurloon=25.41 },
                new Werknemer{ Functie_id=2, Voornaam="Harrie", Achternaam="Boomsma", Geboortedatum=DateTime.Parse("1989-11-04"), BSN=572417907, Telefoonnummer=0627853064, Email="harrie189@hotmail.nl", Wachtwoord="harrie", Contract_uren=32, Uurloon=21.13 },
            };

            foreach(Werknemer werknemer in werknemers)
            {
                context.Werknemers.Add(werknemer);
            }

            context.SaveChanges();
        }

    }
}
