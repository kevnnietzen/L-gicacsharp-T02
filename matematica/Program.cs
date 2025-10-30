
//declarando constantes 
const int valor1 = 10;
const int valor2 = 5;


//soma
int soma = valor1 + valor2;
Console.WriteLine($"soma: {valor1} + {valor2} = {soma}");

//subtração
int subtracao = valor1 - valor2;
Console.WriteLine($"subtração: {valor1} - {valor2} = {subtracao}");

//Multiplicação 
int multiplicacao = valor1 * valor2;
Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");

//Divisão (resultado)
int divisao  = valor1 / valor2;
Console.WriteLine($"divisão: {valor1} / {valor2} = {divisao}");

int restoDivisao = valor1 % valor2;
Console.WriteLine($"Resto de divisão de: {valor1} / {valor2} = {restoDivisao}");

//potenciação (usando Math.pow para calcular a potência)
double potencial = Math.Pow(valor1, valor2);
Console.WriteLine($"potenciação: {valor1} elevado a {valor2} = {potencial}");

//Exemplo 1: Sem parêmteses 
int resultado1 = 3 + 5 * 2;
Console.WriteLine($"Resultado 1 (sem parênteses): 3 + 5 * 2 = {resultado1}");

//Explo 1: com parênteses
int resultado2 = (3 + 5) * 2;
Console.WriteLine($"Resultado 2 (com parênteses): (3 + 5) * 2 = {resultado2}");

//Explo 2: sem parênteses
int resultado3 = 8 / 4 + 3;
Console.WriteLine($"Resultado 3 (com parênteses): 8 / 4 + 3 = {resultado3}");

//Explo 4: com parênteses
double resultado4 = 8.0 / (4 + 3);
Console.WriteLine($"Resultado 4 (com parênteses): 8 / (4 + 3) = {resultado4}");