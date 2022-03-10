using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class SameNotDerived
    {
        public void Test()
        {
            AccessTest a = new AccessTest();
            a.a = 10;
            a.b = 20;
            // a.c = 30;  //can't directly accesss protected members.
            // this.c = 30;  
            a.d = 40;
            //a.e = 50;  private member not accessible.
        }
    }
}
