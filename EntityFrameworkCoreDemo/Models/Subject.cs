using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Models
{
    public class Subject : BaseObject
    {
        public string Name { get; set; }
        public string  CourseId { get; set; }
        public Course Course { get; set; }

    }
}
