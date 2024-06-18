using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using SalesWeb.Data;
using SalesWeb.Models;

namespace SalesWeb.Services;

public class SellerService
{
    private readonly SalesWebContext _context;

    public SellerService(SalesWebContext context)
    {
        _context = context;
    }
    public List<Seller> GetAllSeller()
    {
        
        var list = _context.Seller.ToList();
        if (!list.Any())
        {
            throw new Exception("Error");
        }
        return list;
    }

    public void Remove(int id)
    {
        var RemoveSeller = _context.Seller.FirstOrDefault(x => x.Id == id);
        _context.Seller.Remove(RemoveSeller);
    }
}