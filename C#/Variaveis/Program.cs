using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // type variableName = value;
            // exemplo de sintaxe de variaveis

            string name = "John";
            Console.WriteLine(name);

            int myNum = 15;
            myNum = 20; // alterando valor da variavel para 20
            Console.WriteLine(myNum);

            Console.WriteLine(name + " tem " + myNum + " anos");

            // trabalhando com constantes
             const int my1Num = 15;
            // my1Num = 20; // erro constantes n aceitam mudança de valores
        
            // outros tipos
            int idade = 18;
            double peso = 75.8;
            char operacao = '+';
            bool temCartaoDeCredito = true;
            string nome = "arthur";


            // concatenação 
            string name1 ="John";
            Console.WriteLine("Hello" + name1);

            string firstName = "John";
            string lastname = "Doe";
            string fullname = firstName + lastname;
            Console.WriteLine(fullname);

            // Soma de inteiros
            int num1 = 5;
            int num2 = 6;
            Console.WriteLine(num1 + num2); // print o valor de x + y
        
            // Declarar muitas variáveis
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
        }
    }
}
