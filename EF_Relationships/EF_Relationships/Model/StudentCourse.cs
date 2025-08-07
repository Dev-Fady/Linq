using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relationships.Model
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public decimal? Grade { get; set; }
        public string Status { get; set; } = "Active";

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}
