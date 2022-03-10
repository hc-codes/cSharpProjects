using Different;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class DifferentDerived : DAccessTest
    {
        public void Test()
        {
            DAccessTest a = new DAccessTest();
            a.da = 10;
            // a.db = 20; can't directly accesss protected members.
            this.db = 20; //but can access inherited member.
            // a.c = 30;  can't directly accesss protected members.
            this.dc = 30;  //but can access inherited member.
            //a.dd = 40;
            //a.de = 50;  private member not accessible.
        }
    }
}
