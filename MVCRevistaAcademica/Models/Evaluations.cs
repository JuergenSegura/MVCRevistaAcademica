using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class Evaluations
    {
        [Key]
        public int Id { get; set; }
        public Article Article { get; set; }
        public Person Person { get; set; }
        public DateTime EvaluationDate { get; set; }
    }
}