using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotBargainVbEx.Models
{
    public class Personeel : IdentityUser
    {
        // key & username in base class IdentityUser

        // m:n -> ICollection<n>
        public ICollection<Project> Projecten { get; set; }


        // m:1 -> FK(1)    & embedded ->  (full) 1.object
        public Vestiging Vestiging { get; set; }
        public int? VestigingId { get; set; }


        [Required]
        [PersonalData]
        public string Voornaam { get; set; }


        [Required]
        [PersonalData]
        public string Achternaam { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Voer je wachtwoord in")]
        public string Wachtwoord { get; set; }

        [Required]
        [NotMapped]
        [Compare( nameof (Wachtwoord))]
        [Display(Name = "Herhaal je wachtwoord" )]
        public string HerhaalWachtwoord { get; set; }
    }
}
