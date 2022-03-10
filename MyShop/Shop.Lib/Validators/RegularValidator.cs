using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Library.Validators
{
    public class RequiredValidator
    {
        public string Validate(string arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                return " is required.";
            }
            else if (arg.Length < 1 || arg.Length > 12)
                return " Not valid Length";
            return null;
        }
    }
}