using Microsoft.VisualBasic;

Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

void ListarProdutos()
{
    foreach (var p in produtos)
    {
        Console.WriteLine($"ID: {p.Value.Id}");
        Console.WriteLine($"Nome: {p.Value.Nome}");
        Console.WriteLine($"Preço: {p.Value.Preco}");
    }
}

Produto produto01 = new Produto(1,"Teclado",120.00);
Produto produto02 = new Produto(2,"Mouse",80.00);
Produto produto03 = new Produto(3,"Monitor",900.00);
Produto produto04 = new Produto(4,"Headset",250.00);
Produto produto05 = new Produto(5,"Notebook",3500.00);

produtos[produto01.Id] = produto01;
produtos[produto02.Id] = produto02;
produtos[produto03.Id] = produto03;
produtos[produto04.Id] = produto04;
produtos[produto05.Id] = produto05;


ListarProdutos();