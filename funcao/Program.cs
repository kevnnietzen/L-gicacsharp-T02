using System;
class program
{
    static void Main()
    {
        //Chama uma função simples que imprime uma mensagem
        ImprimirMensagem();

        // Exemplo de funções para cálculo de áreas (modularizacao)
        Console.WriteLine("\n --- Áreas --- ");
        Console.WriteLine("Quadrado: " + CalcularAreaQuadrado(4));
        Console.WriteLine("Circulo: " + CalcularAreaCirculo(3));

        // Exemplo de programa dividindo em funções: entrada, processamento e saída
        Console.WriteLine("\n--- Média de notas ---");
        double[] notas = EntrarNotas(3);    //emtrada de notas 
        double media = CalcularMedia(notas); //Processamento
        Console.WriteLine("Média: " + media); //Sáida

    }

    // Função simples que exibe uma mensagem no console
    static void ImprimirMensagem() => Console.WriteLine("Olá, mundo!");

    // Função que calcula a área de um quadrado 

    static double CalcularAreaQuadrado(double Lado) => Lado * Lado;

    // Função para calcular a área de um círculo
    static double CalcularAreaCirculo(double Raio) => Math.PI * Raio * Raio;

    // Função que lê notas digitadas opelo usuario e armazena em um vetor

    static double[] EntrarNotas(int qtd)
    {
        double[] notas = new double[qtd];
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("Nota " + (i + 1) + ": ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        return notas;
    }

    // Função que calcula a média de um vetor de notas

    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double n in notas) soma += n;
        return soma / notas.Length;
    }

}