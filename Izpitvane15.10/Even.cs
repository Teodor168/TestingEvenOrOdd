using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane15._10
{
    public class Even
    {
        public bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
