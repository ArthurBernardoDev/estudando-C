using System;

namespace tipoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
           // numeros inteiros = int 
           int myNum = 10000;
           Console.WriteLine(myNum);

           //numeros longos = long
           long myNum1 = 15000000000L;
           Console.WriteLine(myNum1);

           // ponto flutuante/virgula = float
            float myNum2 = 5.75F;
            Console.WriteLine(myNum2);

            // double tipode de dados para armazenar números fracionados 
            double myNum3 = 19.99D;
            Console.WriteLine(myNum3);

            //Números Científicos
            float f1 = 35e3f;
            double d1 = 12E4D;
            Console.WriteLine(f1);   
            Console.WriteLine(d1);   

            // booleanos tipo de dado que pode ser true ou false
            bool temCartaoDeCredito = true;
            bool temDivida = false;
            Console.WriteLine(temCartaoDeCredito);
            Console.WriteLine(temDivida);

            // Caracteres é um tipo de dado para armazenar um único caractere
            char minhaGrade = 'A';
            Console.WriteLine(minhaGrade);

            // Strings armazenar uma sequência de caracteres "texto"
            string initial = "Hello World";
            Console.WriteLine(initial);
        }   
    }
}
