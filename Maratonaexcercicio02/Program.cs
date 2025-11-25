/*Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor,
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".*/

int parse = 5;
{
    Console.WriteLine("Digite aquantidade de numero no estoque");
    int quantidade = int.Parse(Console.ReadLine());
    {
        if (quantidade < 5)
        {
            Console.WriteLine("Estoque suficiente");
        }
        else
        {
            Console.WriteLine("Alerta: Baixo estoque.por favor, reabasteça este produto");
        }
    }
}

/*2.Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte
de uma promoção de vendas. Escreva um código que determine o valor total da
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um
desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um
desconto de 10%.". */

int valor = 200;

if (valor >= 200)
{
    Console.WriteLine("Desconto de 10% Aplicado");
}

else //if (valor <= 200)
{
    Console.WriteLine("Adicione Mais itens ao carrinho para ganhar um desconto de 10%");
}