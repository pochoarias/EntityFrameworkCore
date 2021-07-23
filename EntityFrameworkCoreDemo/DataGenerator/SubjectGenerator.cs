using EntityFrameworkCoreDemo.Helpers;
using EntityFrameworkCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.DataGenerator
{
    public class SubjectGenerator
    {

        private const int AMOUT_COURSES = 10;

        public static IList<Subject> GetSubjects()
        {
            var subjects = new List<Subject>();
            for (int i = 0; i < AMOUT_COURSES; i++)
            {
                var subjectName = Utils.StringGenerator();
                var subject = new Subject()
                {
                    Name = subjectName
                };
                subjects.Add(subject);
            }
            return subjects;
        }
    }
}
