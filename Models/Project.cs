using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HotBargainVbEx.Attributes;

namespace HotBargainVbEx.Models
{
    public class Project
    {
        // m:n -> ICollection<n>
        public ICollection<Personeel> Personeelsleden { get; set; }

        public Status Status { get; set; }


        [Display( Name = "Naam van project")]
        [Key, Required]
        [ValideerProjectNaam(ErrorMessage = "Begin de naam met PROJ_ en voeg daar vier karakters aan toe.")]
        public string ProjectNaam { get; set; }


        [Display(Name = "Huidig projectbudget")]
        [DataType(DataType.Currency)]
        public decimal HuidigBudget { get; set; }
    }
}
