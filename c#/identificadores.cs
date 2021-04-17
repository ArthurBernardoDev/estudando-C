static void Main(string[] args) {
    int a, b, c;
    a = int.Parse(Console.ReadLine());
    b = 1;
    for (c = 2; c <= a; c++)
    b = b * c;
    console.White(b);
    Console.ReadKey();
}
// funciona porém os identificadores a b c fazem com que o código fique mas complexo de se entender

static void Main(string[] args) {
// Programa para calcular o fatorial de um número
    int Numero, Fatorial, Contador;
    Console.Write("informe um número: ");
    Numero = int.Parse(console.ReadLine());
    Fatorial = 1;
    for (Contador = 2; Contador <= Numero; Contador++)
    Fatorial = Fatorial * Contador;
    console.Write("Fatorial de" + Numero + " = " + Fatorial);
    Console.ReadKey();
}

// mesmo funcionalidade escrita de uma forma melhor