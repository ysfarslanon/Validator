using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExample
{
    public static class Extension
    {
        
        public static bool IsValid(this string password, params IRules[] rules)
        {
            foreach (var rule in rules)
            {
                if (!rule.Rule(password))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
