using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class Residence
    {
        [Key]
        public int ResidenceId { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Canton { get; set; }
        public string District { get; set; }
    }
}