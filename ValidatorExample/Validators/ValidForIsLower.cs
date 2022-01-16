using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExample.Validators
{
    class ValidForIsLower : IRules
    {
        public bool Rule(string str)
        {
            bool result = str.Any(item => char.IsLower(item));
            if(!result)
                Console.WriteLine("Küçük harf eksik.");
            return result;
        }
    }
}
