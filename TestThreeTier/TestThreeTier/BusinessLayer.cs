using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThreeTier
{
    class BusinessLayer
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public void AddRecord()
        {
            string q = $"insert into testdb([user],pass) values ('{Username}','{Password}')";
            DBClass.Insert(q);

        }
        public DataSet View()
        {
            string q = $"select * from testdb";
            return DBClass.Select(q);
        }
        public DataSet ViewItem()
        {
            string q = $"select * from item";
            return DBClass.Select(q);
        }

        internal DataSet GetSingleUsername()
        {
            string q = $"select * from testdb where [user] = '{Username}'";
            return DBClass.Select(q);
        }
        public DataSet Check(int q)
        {
            string query = $"select quantity from item where name = 'Cb'";
            return DBClass.Select(query);
        }
            public void update(int q)
        {
        }
    }
}
