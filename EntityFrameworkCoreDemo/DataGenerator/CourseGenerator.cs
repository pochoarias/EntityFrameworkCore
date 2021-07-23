using EntityFrameworkCoreDemo.Helpers;
using EntityFrameworkCoreDemo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.DataGenerator
{
    public class CourseGenerator
    {
        private const int AMOUT_COURSES = 10;

        public static IList<Course> GetCourses()
        {
            var courses = new List<Course>();
            for (int i = 0; i < AMOUT_COURSES; i++)
            {
                var courseName = Utils.StringGenerator();
                var course = new Course()
                {
                    Name = courseName,
                    Schedule = Schedules.Day

                };
                courses.Add(course);
            }
            return courses;
        }

    }
}
