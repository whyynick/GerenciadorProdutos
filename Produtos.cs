using System.Data.Common;

class Produto
{ 
    public int Id {get;init;}
    public string? Nome {get;set;}
    public double Preco {get;set;}



    public Produto(int id, string nome, double preco)
    {
        this.Id = id;
        this.Nome = nome;
        this.Preco = preco;
    }
}