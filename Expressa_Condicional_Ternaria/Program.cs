using System;
using System.Globalization;
namespace Expressa_Condicional_Ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Expressão condicional ternaria

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
           /* a solução tem o mesmo resultado if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }*/
            Console.WriteLine(desconto);
        }
    }
}
