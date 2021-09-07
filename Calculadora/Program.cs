using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Introduce el dividendo:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el divisor:");
            n2 = Convert.ToInt32(Console.ReadLine());
            var resultado = Division.Div(n1,n2);
            Console.WriteLine("El resultado de la division es:" + resultado);
;        }
    }
}
