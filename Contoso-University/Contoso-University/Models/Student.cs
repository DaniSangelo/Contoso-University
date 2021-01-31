using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso_University.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        //[StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        //[StringLength(50)]
        //[Column("FirstName")] //the property FirstMidName will be mapped to database as firstname
        public string FirstMidName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime EnrollmentDate { get; set; }


        /*
         If the property just have get method, then it isn't mapped to database. I could use [NotMapped] annotation for this purpose.
         */
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
