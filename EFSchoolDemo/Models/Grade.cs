using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchoolDemo.Models
{
    [DebuggerDisplay("{Course.Name} - {Student.Name}: Score")]
    [Microsoft.EntityFrameworkCore.PrimaryKey(nameof(CourseId), nameof(StudentId))]
    internal class Grade
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public float Score { get; set; }
    }    
}
