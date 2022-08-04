using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRevistaAcademica.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AcademicDegree { get; set; }
        public string Specialization { get; set; }
        public string Position { get; set; }
        public string Institution { get; set; }
        public Residence Residence { get; set; }
        public string Direction { get; set; }
    }
}