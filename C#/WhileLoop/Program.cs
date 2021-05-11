using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Os loops podem executar um bloco de código, desde que uma condição especificada seja alcançada.
            // Os loops são úteis porque economizam tempo, reduzem os erros e tornam o código mais legível.
        
            // while (condição)
            // {
            //     bloco de codigo 
            // }
        

            int i = 0;
            while (i < 5){
                Console.WriteLine(i);
                i++;

            }

                // The Do/While Loop
                // do
                // {
                //     bloco de codigo
                // }
                // while(condição)
            int i1 = 0;
            do {
                Console.WriteLine(i1);
                i++;
            }
            while (i1 < 5);

        }
    }
}
