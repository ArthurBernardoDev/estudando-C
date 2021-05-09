using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Type casting é quando você atribui um valor de um tipode de dados a outro tipo.
            existem dois tipos de casting:
            Fundição Implícita (automaticamente) - convertendo um tipo menor
            em um tamnhado de tipo maior
            chat -> int -> long -> float -> double

            Fundição Explícita (manualamente) - convertendo um tipo maior em tipo de tamanho menor
            double -> float -> long -> int -> char
            */

            // Elenco implícito
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Elenco explícito
            double myDouble2 = 9.78;
            int myInt2 = (int) myDouble2;

            Console.WriteLine(myDouble2); 
            Console.WriteLine(myInt2); 

            // Métodos de conversão de tipos
            
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3)); // convertendo um int para uma string
            Console.WriteLine(Convert.ToDouble(myInt3)); // convertendo um int para double
            Console.WriteLine(Convert.ToInt32(myDouble3)); // convertendo um double para int
            Console.WriteLine(Convert.ToString(myBool)); // convertendo um boll para uma string
        }
    }
}
