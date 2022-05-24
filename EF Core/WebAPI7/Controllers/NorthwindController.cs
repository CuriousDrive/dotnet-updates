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
        // New Category
        var category = new Category();
        category.CategoryName = "Hardware";
        category.Description = "Screws, Bolts, Tools";

        // Inserting
        _northwindContext.Categories.Add(category);
        await _northwindContext.SaveChangesAsync();
        
        Console.WriteLine("Auto Generated Id is : " + category.CategoryId);

        // Updating
        _northwindContext.Categories.Update(category);
        await _northwindContext.SaveChangesAsync();

        // Deleting
        _northwindContext.Categories.Remove(category);
        await _northwindContext.SaveChangesAsync();

        // return nothing        
        return new List<Category>();
    }
}
