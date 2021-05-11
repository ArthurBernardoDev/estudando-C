using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
        // Quando você souber exatamente quantas vezes deseja percorrer um bloco de código, use o forloop em vez de um whileloop:

        // Sintaxe
        // for (statement 1; statement 2; statement 3) 
        // {
        //   // code block to be executed
        // }
        // A instrução 1 é executada (uma vez) antes da execução do bloco de código.

        // A instrução 2 define a condição para a execução do bloco de código.

        // A instrução 3 é executada (todas as vezes) após a execução do bloco de código.

        // O exemplo abaixo imprimirá os números de 0 a 4:
        
        for (int i = 0; i < 5; i++){
            Console.WriteLine(i);
        
        // Exemplo explicado
        // A instrução 1 define uma variável antes do início do loop ( int i = 0).

        // A instrução 2 define a condição para o loop ser executado ( ideve ser menor que 5). Se a condição for true, o loop começará novamente; se for false, o loop terminará.

        // A instrução 3 aumenta um valor ( i++) cada vez que o bloco de código no loop é executado.
        }
        
        for (int i = 0; i <=10; i = i + 2){
            Console.Write(i);

        //         O loop foreach
        // Também existe um foreachloop, que é usado exclusivamente para percorrer os elementos de uma matriz :
        }
        
        // Sintaxe
        // Loop foreach
        // foreach (type variavlNome in arrayName){
            // bloco de codigo
        // }
        
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
        
        
        
        }
    
    
    
    
    
    }
}
