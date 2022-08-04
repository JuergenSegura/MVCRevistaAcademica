using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class ArticleType
    {
        [Key]
        public int ArticleTypeId { get; set; }
        public string Type { get; set; }

    }
}