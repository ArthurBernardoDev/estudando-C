using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
           // condições e Declarações de if
           /* 
           Menos de: a < b
            Menos ou igual a: a <= b
            Maior que: a > b
            Maior ou igual a: a >= b
            Igual a == b
            Não igual a: a != b
           */
        

            // declaração do if

            // if(condição) { bloco de codigo executado se o if for true}
       
            if (20 > 18) {
                Console.WriteLine("20 é maior que 18");
            }

            int x = 20;
            int y = 18;
            if (x > y) {
                Console.WriteLine("X é maior que y");
            } //  No exemplo acima usamos duas variáveis, x e y,para testar se x é maior que y (usando o operador). Como x é 20, e y é 18, e sabemos que 20 é maior que 18, imprimimos para a tela que "x é maior que y".>

            // A declaração do else  
            /* 
            If (condição) { se a condição for true

            } else { se a condição for false

            }
            */
            int time = 20;
            if (time < 18){
                Console.WriteLine("Bom dia.");
            } else { 
                Console.WriteLine("Boa tarde.");
            }

            // O outra declaração de if 

            /* 
            if (condição) { 
                se a condição for true
            } else if (condição2) { 
                se a condição for false a condição 1
            } else { 
                se a condição 1 e 2 forem falsas
            }
            */
            int tempo = 22;
            if (tempo < 10) {
                Console.WriteLine("Bom dia !");
            } else if ( tempo < 20) {
                Console.WriteLine("Boa tarde !");
            } else {
                Console.WriteLine("Boa noite");
            }


            // Você pode simplesmente escrever:

            //exemplo
        int time1 = 20;
        string result = (time1 < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
        }
    }
}
