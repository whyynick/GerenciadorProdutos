using Microsoft.VisualBasic;

Dictionary<int, Produto> produtos = new Dictionary<int, Produto>();

void ListarProdutos()
{
    foreach (var p in produtos)
    {
        Console.WriteLine($"ID: {p.Value.Id}");
        Console.WriteLine($"Nome: {p.Value.Nome}");
        Console.WriteLine($"Preço: R$ {p.Value.Preco:F2}");
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


bool menu = true;

while(menu == true){

    Console.WriteLine("========= - MENU - =========");
    Console.WriteLine("1 - Listar produtos");
    Console.WriteLine("2 - Buscar produto por ID");
    Console.WriteLine("3 - Excluir produto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("============================");

    string opt = Console.ReadLine();

    switch(opt){

        case "1":
            ListarProdutos();
            break;

        case "2":
            Console.Write("Digite o número de ID do item desejado:");
            int IdBuscado = int.Parse(Console.ReadLine());

                if (produtos.ContainsKey(IdBuscado))
                {
                    var encontrado = produtos[IdBuscado];
                    Console.WriteLine($"ID: {encontrado.Id}\nNome: {encontrado.Nome}\nPreço: R$ {encontrado.Preco:F2}");
                }

                else
                {
                    Console.WriteLine("Não existe nenhum produto com esse ID cadastado!");
                }
            break;
        
        case "3":
            Console.WriteLine("Digite o ID do produto que deseja remover:");
            int IdRemover = int.Parse(Console.ReadLine());

                if (produtos.ContainsKey(IdRemover)){
                    string? nomeRemovido = produtos[IdRemover].Nome;
                    produtos.Remove(IdRemover);
                    Console.WriteLine($"Produto {nomeRemovido} removido com sucesso!");
                }

                else{
                    Console.WriteLine("Não existe nenhum produto com esse ID cadastrado!");
                }
            break;

        case "0":
            menu = false;
            Console.WriteLine("Menu encerrado.");
            break;
        
        default:
            Console.WriteLine("Opção inválida, por favor escolha uma opção de 0 a 3 no menu!");
            break;
        
    }
};




