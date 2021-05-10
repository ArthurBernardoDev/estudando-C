using System;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para isso, C# tem um tipo de dados, que pode pegar os valores ou .booltruefalse
            bool temCasa = true;
            bool naoTemCasa = false;
            Console.WriteLine(temCasa);
            Console.WriteLine(naoTemCasa);

            // expressão booleana é uma expressão que devolve um valor booleano ou true false
            // exemplo 
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);
            //ou ate mais facil 
            Console.WriteLine(10 > 9);

            int x1 = 10;
            Console.WriteLine(x1 == 10);

            Console.WriteLine(10 == 15);
        }
    }
}
