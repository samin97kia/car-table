using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using car.Models;

namespace car.Controllers;

public class HomeController : Controller
{
    
private readonly Context db;
public HomeController(Context x)
{
    db = x;
}


    public IActionResult Index()
    {
        ViewBag.result=db.Tbl_Cars.OrderByDescending(x=>x.id) .ToList();
        return View();
    }

    
public IActionResult addcar(Tbl_Car car)
    {
        db.Tbl_Cars.Add(car);
        db.SaveChanges();
        return RedirectToAction("index");
        
    }
public IActionResult delete ( int id)
    {
        var car = db.Tbl_Cars.Find(id);
db.Tbl_Cars.Remove(car);
db.SaveChanges();


return RedirectToAction("index");

    }
public IActionResult edit ( int id)
    {
        var car = db.Tbl_Cars.Find(id);

return View(car);
    }

public IActionResult updatecar ( Tbl_Car c)
    {
        var car = db.Tbl_Cars.Find(c.id);
        car.name = c.name;
        car.model = c.model;
        car.price = c.price;
        db.SaveChanges();

return RedirectToAction("index");


    }
}
