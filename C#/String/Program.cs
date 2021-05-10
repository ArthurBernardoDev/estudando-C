using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
         // strings são usadas para armazenar texto.

         string greeting = "Hello";
         Console.WriteLine(greeting);

         string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         Console.WriteLine("The length of the txt sting is: " + txt.Length);
        
        string txt1 = "Hello World";
        Console.WriteLine(txt1.ToUpper()); // maisculo
        Console.WriteLine(txt1.ToLower()); // minusculo
        
        // concatenação de strings
        string firstName = "John ";
        string lastName = "Doe";
        string name = firstName + lastName;
        Console.WriteLine(name);


        string firstname = "Arthur";
        string lastname = "bernardo";
        string name1 = $"my full name é : {firstname} {lastname}";
        Console.WriteLine(name1);
        
        //Accessando Strings
        string myString = "Hello";
        Console.WriteLine(myString[0]);
        Console.WriteLine(myString.IndexOf("e"));

        // se você adicionar dois numeros, o resultado sera um numero
        int x = 10;
        int y = 20;
        int z = x + y;  // 10 + 20 = 30 
        // Se você adicionar duas strings, o resultado será uma concatenação de strings
        string x1 = "10";
        string y1 = "20";
        string z1 = x1 + y1;
        }
    }
}
