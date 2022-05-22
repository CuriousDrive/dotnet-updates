using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using Northwind.Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class NorthwindController : ControllerBase
{
    private readonly ILogger<NorthwindController> _logger;
    private readonly NorthwindContext _northwindContext;

    public NorthwindController(ILogger<NorthwindController> logger,
        NorthwindContext northwindContext)
    {
        _logger = logger;
        _northwindContext = northwindContext;
    }

    [HttpGet(Name = "GetCategories")]
    public async Task<IEnumerable<Category>> Get()
    {
        // insert categories
        var category = new Category();
        category.CategoryName = "Hardware";
        category.Description = "Screws, Bolts, Tools";

        _northwindContext.Categories.Add(category);
        await _northwindContext.SaveChangesAsync();
        
        Console.WriteLine("Auto Generated Id is : " + category.CategoryId);

        // return categories        
        return await _northwindContext.Categories.ToListAsync();
    }
}