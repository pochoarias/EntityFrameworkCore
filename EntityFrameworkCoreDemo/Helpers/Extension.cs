using EntityFrameworkCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Helpers
{
    public static class Extension
    {
        public static IList<Course> AssignSchool<T>(this IList<Course> courses, T school) where T : BaseObject
        {
            foreach (var item in courses)
            {
                item.Schoold = school.Id;
            }

            return courses;
        }

        public static IList<Subject> AssignCourses<T>(this IList<Subject> subjects, IList<T> courses) where T : BaseObject
        {
            foreach (var course in courses)
            {
                foreach (var subject in subjects)
                {
                    subject.CourseId = course.Id;
                }
            }

            return subjects;
        }

        public static IList<Student> AssignCourses<T>(this IList<Student> students, IList<T> courses) where T : BaseObject
        {
            foreach (var course in courses)
            {
                foreach (var student in students)
                {
                    student.CourseId = course.Id;
                }
            }

            return students;
        }
    }
}
