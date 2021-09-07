using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {
        double dividendo, divisor;
        
        //decimal n1, n2;

        public static double Div(double dividendo, double divisor)
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
