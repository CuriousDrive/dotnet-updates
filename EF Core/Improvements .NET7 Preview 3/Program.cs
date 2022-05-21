using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using Northwind.Models;

using (var northwindContext = new NorthwindContext())
{
    //insert
    var category = new Category();
    category.CategoryName = "Hardware";
    category.Description = "Screws, Bolts, Tools";

    northwindContext.Categories.Add(category);
    int result = await northwindContext.SaveChangesAsync();

    Console.WriteLine("New Id : " + result);


    // categories
    var categories = await northwindContext.Categories.ToListAsync();
    foreach (var item in categories)
    {
        Console.WriteLine(item.Id + " " + item.CategoryName);
    }
}

