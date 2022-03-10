using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefaceBasic
{
    public interface Ifun
    {
        int fun();
    }
    public class A : Ifun
    {
        public int fun()
        {
            return 100;
        }
    }
    public class B : Ifun
    {
        public int fun()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Run run = new Run();
            run.Runner();
        }
    }
    public class Run
    {
        private Ifun obj;
        public void Runner()
        {
            Console.WriteLine(obj.fun());
        }
    }
}
