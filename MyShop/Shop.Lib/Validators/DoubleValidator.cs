using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Library.Validators
{
    public class DoubleValidator : RequiredValidator
    {
        public new string Validate(string arg)
        {
            string res = base.Validate(arg);
            if (res == null)
            {
                try
                {
                    double.Parse(arg);
                }
                catch (Exception ex)
                {
                    return " " + ex.Message;
                }
            }
            return res;
        }
    }
}
