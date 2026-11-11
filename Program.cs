

Console.WriteLine(" === MINHA COMPRA===");

Console.WriteLine("Digite o nome do produto : ");
string? nomeProduto = Console.ReadLine();

Console.WriteLine("Digite a quantidade: ");
int quantidade = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Digite o preço ");
double preco = Convert.ToDouble(Console.ReadLine());

// calculo para analise de desconto 

double totalCompra = quantidade * preco;
double desconto = 0;
double descontoTotal = totalCompra;

// verificação do desconto 

if (quantidade >= 5 && totalCompra> 5000)
{
    desconto = totalCompra * 0.10;
    descontoTotal = totalCompra - desconto;
    Console.WriteLine("Você ganhou um desconto de 10 %");
}
else if (quantidade<=3 || totalCompra <= 4000){
    desconto = totalCompra * 0.05;
    descontoTotal = totalCompra - desconto;
    Console.WriteLine ("Você ganhou um desconto de 5 %");
}
else
{
    Console.WriteLine(" Você não ganhou desconto");
}
Console.WriteLine("\n=== PRODUTO CADASTRADO ===");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Preço: R$ {preco:F2}");
Console.WriteLine($"Valor total do produto {nomeProduto}: R$ {totalCompra:F2}");
Console.WriteLine($"Valor final com desconto: R$ {descontoTotal:F2}");
