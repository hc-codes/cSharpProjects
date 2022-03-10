using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSample
{
    class DateTimeFun
    {
        public void Fun()
        {
            var dob = new DateTime(1998, 8, 28);
            var now = DateTime.Now;
            var res = now - dob;
            Console.WriteLine(res.Days);
            Console.WriteLine(res.Days / 30.4);
            Console.WriteLine(res.Days / (30 * 12));
        }
    }
}
