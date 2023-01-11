using System;
using System.ComponentModel.DataAnnotations;

namespace GeoProfs.Models
{
    public class Werknemer
    {
        [Key]
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
    }
}
