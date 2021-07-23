using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Helpers
{
    public static class Utils
    {
        private const int NAME_LENGTH = 7;
        private static readonly Random random = new Random();

        public static string StringGenerator()
        {
            StringBuilder str_build = new StringBuilder();
            char letter;

            for (int i = 0; i < NAME_LENGTH; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }

        public static int NumberGenerator()
        {
            return random.Next(100);
        }


    }
}
