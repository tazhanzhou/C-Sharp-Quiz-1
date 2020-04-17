using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Quiz_1
{
    public static class Dividable
    {
        public static void IsDividable(this int num)
        {
            if (num % 3 != 0)
            {
                Console.WriteLine("{0} cannot be divided by 3.",num);
            }
            else Console.WriteLine("{0} can be divided by 3.",num);
        }
    }
}
