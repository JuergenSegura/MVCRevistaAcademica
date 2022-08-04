using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public int Volumen { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public Person Person { get; set; }
        public DateTime ReceptionDate { get; set; }
        public string DOI { get; set; }

        [ForeignKey("ArticleTypeId")]
        public ArticleType ArticleType { get; set; }
    }
}