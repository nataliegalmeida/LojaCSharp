

Console.WriteLine (" === MINHA COMPRA===");

Console.WriteLine("Digite o nome do produto : ");
string? nomeProduto = Console.ReadLine();

Console.WriteLine ("Digite a quantidade: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o preço ");
double preco = Convert.ToDouble(Console.ReadLine());

double totalCompra = quantidade * preco;

Console.WriteLine ("\n=== PRODUTO CADASTRADO ===");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Preço: R$ {preco:F2}");
Console.WriteLine($"Valor total do produto {nomeProduto}: R$ {totalCompra:F2}");
