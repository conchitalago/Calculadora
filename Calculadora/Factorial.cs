using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Factorial
    {
        int num1;
        public static int Fact(int num1)
        {
            if (num1 > 1)
            {
                return num1 * Fact(num1 - 1);
            }
            if(num1 == 1)
            {
                return 1;
            }
            throw new NotImplementedException("Upss!!");
        }
    }
}
