//loop for
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
int soma  = 0;

for (int j = 1;  j <= 100; j++)
{
    soma++; // Soma o valor de j mais a variavel soma
}
Console.WriteLine("\n");
Console.WriteLine("A soma dos númerps de 1 a 100 é: " +  soma);
Console.WriteLine("\n");

/*for (;;)
{
    Console.WriteLine("Este é um loop infinito!");
}
*/

//Loop while (enquanto)
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++; // Incrementa o contador
}
Console.WriteLine("\n");

//loop do while
int novoContador = 2;

do
{
    Console.WriteLine(novoContador);
    novoContador++; //incrementa o contador
} while (novoContador <= 5);
Console.WriteLine("\n");
//loop infinito while
/*while (true)
{
    Console.WriteLine("Este é um loop infinito");
} */

//loop foreach

//uma lista de strings
List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

//usando o foreachpara percorrer a lisat
foreach (string nome in nomes )
{
    Console.WriteLine(nome); //imprime cadanome exibido na tela
}

//Um vetor de números para percorrer o vetor
int[] numeros = { 1, 2, 3, 4, 5, 6, 7 }; 

//Usando o foreach para percorrer o vetor
foreach (int numero in numeros )
{
    Console.WriteLine(numero);
}
//solicitando ao usuário a digitação
double preco, total = 0;
do
{
Console.Write("Digite o preco do produto (0 para finalizar): ");
preco = Convert.ToDouble(Console.ReadLine());
total += preco;
} while (preco != 0) ;

Console.WriteLine($"\nTotal da compra: R$ {total:F2}");