using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {
        decimal dividendo, divisor;
        
        //decimal n1, n2;

        public static decimal Div(Int32 dividendo, int divisor)
        {
            try
            {
                return dividendo / divisor;
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException("Ups");
            }

            //if (divisor == 0)
            //    throw new DivideByZeroException();
            //return dividendo / divisor;

        }
        //public static int Debt(int dividendo, int divisor)
        //{
        //    return dividendo % divisor;
        //}
    }
}
