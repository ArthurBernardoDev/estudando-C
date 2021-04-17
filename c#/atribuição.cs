// 2 formas de atribuição

// primeira
static void Main(string[] args) { 
int idade;
double altura, peso, copiaPeso, IMC;
string nome;
boll temCNH;

// declarando as variáveis sem passar a atribuição imediata

idade = 23;
altura = 1.76;
peso = 78.9;
nome = "João da Silva";
temCNH = true;
copiaPeso = peso;
IMC = peso / (altura * altura);

}
// segunda
static void Main(string[] args) { 
    int idade = 23;
    double altura = 1.76, peso = 78.9;
    string nome = "João da Silva";
    bool temCNH = true;

    copiaPeso = peso;
    IMC = peso / (altura * altura);
    // declarando as variáveis passando atribuição
}