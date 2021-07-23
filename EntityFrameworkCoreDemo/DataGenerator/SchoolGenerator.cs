using EntityFrameworkCoreDemo.Helpers;
using EntityFrameworkCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.DataGenerator
{
    public class SchoolGenerator
    {
        public static School GetSchool()
        {
            var schoolName = Utils.StringGenerator();
            var school = new School(schoolName);
            return school;
        }
    }
}
