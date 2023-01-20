using System;
using System.ComponentModel.DataAnnotations;

namespace GeoProfs.Models
{
    public class Werknemer
    {
        [Key]
        public int Id { get; set; }
        public int Functie_id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public int BSN { get; set; }
        public int Telefoonnummer { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public int Contract_uren { get; set; }
        public double Uurloon { get; set; }
    }
}
