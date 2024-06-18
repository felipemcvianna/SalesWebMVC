using SalesWeb.Models.Enumables;

namespace SalesWeb.Models;

public class SalesRecord
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public double Amount { get; set; }
    public SalesStatus SaleStatus { get; set; }
    public Seller Seller { get; set; }

    public SalesRecord()
    {
    }

    public SalesRecord(int id, DateTime data,  double amount, SalesStatus Salesstatus, Seller seller)
    {
        Id = id;
        Data = data;
        Amount = amount;
        SaleStatus = Salesstatus;
        Seller = seller;
    }
}