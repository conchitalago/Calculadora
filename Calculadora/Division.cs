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
            if(divisor != 0)
            {
                return dividendo / divisor;
            }
            else
            {
                throw new DivideByZeroException();
           }

            //try
            //{
            //    return dividendo / divisor;
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Ups!No se puede dividir entre 0");
            //    return 0;

            //}



        }
        //public static int Debt(int dividendo, int divisor)
        //{
        //    return dividendo % divisor;
        //}
    }
}
