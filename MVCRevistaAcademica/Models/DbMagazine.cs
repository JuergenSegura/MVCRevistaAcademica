using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class DbMagazine : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<CategoryEvaluated> CategoryEvaluated { get; set; }
        public DbSet<Evaluations> Evaluations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Residence> Residence { get; set; }
    }
}