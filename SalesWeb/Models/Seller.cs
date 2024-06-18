namespace SalesWeb.Models;

public class Seller
{
    public int  Id { get; set; }
    public string  Nome { get; set; }
    public string  Email { get; set; }
    public double Salario { get; set; }
    public DateTime BirthDate { get; set; }
    public Department Department { get; set; }
    public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

    public Seller()
    {
        
    }

    public Seller(int id, string nome, string email,  DateTime birthDate, double salario, Department department)
    {
        Id = id;
        Nome = nome;
        Email = email;
        BirthDate = birthDate;
        Salario = salario;
        Department = department;    
    }

    public void AddSales(SalesRecord sales)
    {
        this.Sales.Add(sales);
    }

    public void removeSales(SalesRecord sales)
    {
        this.Sales.Remove(sales);
    }

    public double TotalSales(DateTime DateInicial, DateTime DateFinal)
    {
        return this.Sales
            .Where(x => x.Data >= DateInicial & x.Data <= DateFinal)
            .Sum(x => x.Amount);
    }
}