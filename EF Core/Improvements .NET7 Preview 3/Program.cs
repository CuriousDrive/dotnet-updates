using Northwind.Data;

using(var northwindContext = new NorthwindContext())
{
    var employeeCount = northwindContext.Employees.Count();
    Console.WriteLine($"There are {employeeCount} employees in Northwind");
}

