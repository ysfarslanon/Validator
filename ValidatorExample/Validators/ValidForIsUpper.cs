using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExample.Validators
{
    class ValidForIsUpper : IRules
    {
        
        public bool Rule(string str)
        {
            bool result = str.Any(item => char.IsUpper(item));

            if (!result)
                Console.WriteLine("Büyük harf eksik.");
            return result;
        }
    }
}
