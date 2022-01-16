using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExample.Validators
{
    class ValidForIsDigit : IRules
    {
        
        public bool Rule(string str)
        {
            bool result= str.Any(item => char.IsDigit(item));
            if(!result)
                Console.WriteLine("Rakam eksik.");
            return result;
        }
    }
}
