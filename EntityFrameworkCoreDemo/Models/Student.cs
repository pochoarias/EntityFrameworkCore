using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Models
{
    public class Student : BaseObject
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }


        public Student(string name, int age) :base()
        {
            Name = name;
            Age = age;
        }

        public Student() : base()
        {
            Name = "undefiend";
            Age = -1;
        }
    }
}
