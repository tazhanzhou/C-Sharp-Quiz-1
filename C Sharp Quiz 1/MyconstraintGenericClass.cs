using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Quiz_1
{
    class MyconstraintGenericClass
    {
        public static void MyConstraintGenericMethod<T>(T className) where T : Employee
        {
            Console.WriteLine("This is {0} for constraint generic class test", className.name);
        }
    }
}
