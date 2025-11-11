//Condicional IF
using System.ComponentModel.Design;

string nome = "Josuke Higashikaua";

if(nome == "Josuke Higashikaua")
{
    Console.WriteLine("Olá,Josuke Higashikaua!");
}
string texto = "";

if (string.IsNullOrEmpty(texto)) ;
{
    Console.WriteLine("string está vazia");
}

//Condicional IF/ELSE
int idade = 16;

if (idade >= 18) //se
{
    Console.WriteLine("Você é maior de idade");
}
else //se não
{
    Console.WriteLine("Você é menor de idade");
}

int numero = 7;

if (numero % 2 == 0)
{
    Console.WriteLine("Numero par");
}
else
{
    Console.WriteLine("Numero impar");
}

//condicional usando else if
double nota = 6.5;

if (nota >= 9.0)
{
    Console.WriteLine("aprovado com excelência");
}
else if (nota >= 7.0)
{
    Console.WriteLine("aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("você está em recuperação");
}
else if (nota >= 3.0)
{
    Console.WriteLine("Você está com risco de reprovação");
}
else
{
    Console.WriteLine("Você foi reprovado");
}

//switch
double pontuacao = 9.5;

//Arrendonadando para o valor mais próximo

int faixaNota = (int)Math.Floor(pontuacao);

switch (faixaNota)
{
    case 10:
        Console.WriteLine("aprovado com excelêcia");
        break;
    case 9:
    case 8:
        Console.WriteLine("aprovado");
        break;
    case 7:
    case 6:
        Console.WriteLine("você está em recuperação");
        break;
        case 5:
        case 4:
        case 3:
        Console.WriteLine("você está em risco de reprovação");
        break;
    default:
        Console.WriteLine("voce foi reprovado");
        break;
}

