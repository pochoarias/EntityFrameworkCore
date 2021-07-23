using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Models
{
    public class School : BaseObject
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public School(string name) : base()
        {
            Name = name;
        }


    }
}
