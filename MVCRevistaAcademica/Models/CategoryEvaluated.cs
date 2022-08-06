using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class CategoryEvaluated
    {
        [Key]
        public int IdCategory { get; set; }
        public string Category { get; set; }
    }
}