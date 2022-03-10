using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBankAccount
{
    public interface IAccount
    {
        void CreateAccount();
    }

    public class CurrentAccount : IAccount
    {
        public void CreateAccount()
        {
            Console.WriteLine("\n\n\tCurrent Account Created Successfully...");
        }
    }
    public class SavingsAccount : IAccount
    {
        public void CreateAccount()
        {
            Console.WriteLine("\n\n\tSavings Account Created Successfully...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new SavingsAccount();
            IAccount account1 = new CurrentAccount();
            account.CreateAccount();
            account1.CreateAccount();
            Console.WriteLine();
        }
    }
}
