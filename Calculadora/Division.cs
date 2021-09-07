using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {
        int dividendo, divisor;
        //decimal n1, n2;

        public static int Div(int dividendo, int divisor)
        {
            try
            {
                return dividendo / divisor;
            }
            catch(DivideByZeroException) {
               
                throw new InvalidOperationException("No se puede dividir entre 0");
            }
            
        }
        public static int Debt(int dividendo, int divisor)
        {
            return dividendo % divisor;
        }
    }
}
