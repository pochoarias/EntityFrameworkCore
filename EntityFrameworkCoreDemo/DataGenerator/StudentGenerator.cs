using EntityFrameworkCoreDemo.Helpers;
using EntityFrameworkCoreDemo.Models;
using System.Collections.Generic;

namespace EntityFrameworkCoreDemo.DataGenerator
{
    public class StudentGenerator
    {
        private const int AMOUT_Students = 10;

        public static IList<Student> GetStudents()
        {
            var students = new List<Student>();
            for (int i = 0; i < AMOUT_Students; i++)
            {
                var name = Utils.StringGenerator();
                var age = Utils.NumberGenerator();
                var student = new Student()
                {
                    Name = name ,
                    Age = age
                };
                students.Add(student);
            }
            return students;
        }
    }
}
