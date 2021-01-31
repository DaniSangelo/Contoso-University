using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso_University.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //allow to insert the primary key to the course instead of data base to do that
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
