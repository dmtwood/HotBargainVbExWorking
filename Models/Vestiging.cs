using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBargainVbEx.Models
{
    public class Vestiging
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }
    }
}
