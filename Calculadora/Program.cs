using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,res;
            Console.WriteLine("Introduce un numero");
            num = Convert.ToInt32(Console.ReadLine());
            res = Fabonacci.Fab(num);
            Console.WriteLine(res);

;        }
    }
}
