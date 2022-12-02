using EFScaffoldingDemo.Data;
using Microsoft.EntityFrameworkCore;

using EveryloopContext db = new();

if (!db.Database.CanConnect())
{
    Console.WriteLine("Connection failed!");
    return;
}



var products = db.Products
                //.Where(product => product.Id <= 10)
                //.Include(product => product.OrderDetails)
                //.ThenInclude(orderDetails => orderDetails.Order)
                //.ThenInclude(order => order.Customer)
                //.Include(product => product.Category)
                //.Include(product => product.Supplier)
                .ToList();

//var categories = db.Categories.Where(c => c.Id <= 3).ToList();

//db.Entry(products[1]).Reference(p => p.Category).Load();
//db.Entry(products[2]).Reference(p => p.Category).Load();
//db.Entry(products[1]).Collection(p => p.OrderDetails).Load();
//db.Entry(products[1].OrderDetails.ElementAt(7)).Reference(o => o.Order);



Console.WriteLine();
