using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExample
{
    public interface IRules
    {
        public bool Rule(string str);
    }
}
