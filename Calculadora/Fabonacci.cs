using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Fabonacci
    {
        public static int Fab(int n1)
        {
            if (n1 <= 2)
                return 1;
            else
                return Fab(n1 - 1) + Fab(n1 - 2);
        }
    }
}
