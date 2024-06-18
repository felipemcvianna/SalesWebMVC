using Microsoft.AspNetCore.Mvc;
using SalesWeb.Services;

namespace SalesWeb.Controllers;

public class SellersController : Controller
{
    private readonly SellerService SellerService;

    public SellersController(SellerService SellerService)
    {
        this.SellerService = SellerService;
    }
    // GET
    public IActionResult HomePage()
    {
        var list = this.SellerService.GetAllSeller();
        return View(list);
    }
    public IActionResult Edit()
    {
        return View();
    }
}