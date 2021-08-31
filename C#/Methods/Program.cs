using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crie um método, Um método é definido com o nome do método , segudo por parênteses()
            Exemplo:*/

            static void MyMethod() {
                // codigo q vai ser executado
            }


            // Exemplo Explicado
            // MyMethod() é o nome do método
            // static significa que o método pertence a classe PRogram e não a um objeto da classe Program.
            // void significa que esse método não possui um valor de retorno.



            // Chame um Método 
            // Para chamar (executar) um método, escreva o nome do método seguido por dois parênteses () e um ponto e vírgula;
            
           
            static void MyMethod1() {
                Console.WriteLine("Fui executado")
            }
            MyMethod1();
            
        }
        }
    
}
