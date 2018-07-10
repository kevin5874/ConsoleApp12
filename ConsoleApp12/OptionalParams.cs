using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class OptionalParams
    {



        public int DoMath(int x, int y = 0)
            {
                x += y;
                return x;
            }

    }
}
