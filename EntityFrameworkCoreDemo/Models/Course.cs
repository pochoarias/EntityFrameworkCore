using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Models
{
    public class Course : BaseObject
    {
        [Required]
        public string Name { get; set; } //Course 1001 1002
        public List<Subject> Subject { get; set; }
        public List<Student> Student { get; set; }

        public string Schoold { get; set; }
        public School School { get; set; }

        public Schedules Schedule { get; set; }
    }
}