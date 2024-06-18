namespace SalesWeb.Models;

public class Department
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

    public Department()
    {
        
    }

    public Department(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public void AddSeller(Seller seller)
    {
        this.Sellers.Add(seller);
    }

    public double TotalSales(DateTime DateInicial, DateTime DateFinal)
    { 
        return Sellers.Sum(x => x.TotalSales(DateInicial, DateFinal));
    }
}