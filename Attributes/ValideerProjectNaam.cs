using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBargainVbEx.Attributes
{
    public class ValideerProjectNaam : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string projNaam )
            {
                return projNaam.StartsWith("PROJ_") && projNaam.Length == 9;
            }
            return false;
        }
    }
}
