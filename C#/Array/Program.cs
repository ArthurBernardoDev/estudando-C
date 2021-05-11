using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //             Crie um Array
            // Os arrays são usados ​​para armazenar vários valores em uma única variável, em vez de declarar variáveis ​​separadas para cada valor.

            // Para declarar uma matriz, defina o tipo de variável com colchetes :

            // string[] carros;

            // agora inserimos valor para a string
            
            string[] cars = {"Volve", "BMW", "Ford", "Mazda"};

            // para criar matriz de inteiros
            int[] myNum = {10, 20, 30, 40};

            // acessando elementos de um array 
            string[] cars1 = {"Volve", "BMW", "Ford", "Mazda"};
            Console.WriteLine(cars1[0]); // Volve

            // para mudar o valor de um array
            cars[0] = "Opel";

            string[] cars2 = {"Volvo", "BMW", "Ford", "Mazda"};
                cars2[0] = "Opel";
                Console.WriteLine(cars2[0]);

            // comprimento da matriz
            // Para descobrir quantos elementos uma matriz possui, use a Lengthpropriedade:
            string[] cars3 = {"Volve", "BMQ", "Ford", "Mazda"};
            Console.WriteLine(cars3.Length);

            //             Loop por meio de uma matriz
            // Você pode percorrer os elementos da matriz com o forloop e usar a Length propriedade para especificar quantas vezes o loop deve ser executado.

            // O exemplo a seguir gera todos os elementos da matriz cars :

            string[] cars4 = {"Volve", "BMQ", "Ford", "Mazda"};
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars4[1]);
            }

                //             O loop foreach
                // Também existe um foreachloop, que é usado exclusivamente para percorrer os elementos de uma matriz :

                // Sintaxe
                // foreach (type variableName in arrayName) 
                // {
                //   // code block to be executed
                // }
                // O exemplo a seguir gera todos os elementos da matriz cars , usando um foreachloop:
            
            string[] cars5 = {"Volve", "BMQ", "Ford", "Mazda"};
            foreach (string i in cars5) {
                Console.WriteLine(i);
            }
        
        }
    }
}
