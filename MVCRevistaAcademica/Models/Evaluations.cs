using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class Evaluations
    {
        [Key]
        public int IdEvaluation { get; set; }

        [ForeignKey("IdArticle")]
        public Article Article { get; set; }

        [ForeignKey("IdPerson")]
        public Person Person { get; set; }
        public DateTime EvaluationDate { get; set; }
    }
}