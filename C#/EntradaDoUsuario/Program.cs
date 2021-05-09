using System;

namespace EntradaDoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            // pedindo ao usuario que escreva seu nome 
            Console.WriteLine("Escreva seu username: ");

            // Criando a variavel string para armazenar o input do nome do usuario
            string userName = Console.ReadLine();

            // mostrar na tela o valor da variavel (userName) concatenado com o seu username É:
            Console.WriteLine("Seu nome é: " + userName);

            /* 
            Portanto, você não pode obter informações de outro tipo de dados, 
            como, o programa a seguir causará um erro:
            Console.ReadLine()string int
            
            exemplo
            Console.WriteLine("Enter your age:");
            int age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);
            A mensagem de erro será algo assim:

            Cannot implicitly convert type 'string' to 'int'
            */
            // forma correta
            Console.WriteLine("Escreva sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A sua idade é: " + age);
        }
    }
}
