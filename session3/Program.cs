using session3.Data;
using session3.Models;

namespace session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Applicationbdbcontext dbcontext = new Applicationbdbcontext();
            Product p1 = new Product() { Name = "phone", price = 800 };
            Product p2 = new Product() { Name = "laptop", price = 500 };
            Product p3 = new Product() { Name = "camera", price = 600 };
            Product p4 = new Product() { Name = "Phone charger", price = 40 };

            Order o1 = new Order() { address = "tulkarem" };
            Order o2 = new Order() { address = "nablus" };
            Order o3 = new Order() { address = "amman" };
            Order o4 = new Order() { address = "maka" };

            dbcontext.Products.Add(p1);
            dbcontext.Products.Add(p2);
            dbcontext.Products.Add(p3);
            dbcontext.Products.Add(p4);

            dbcontext.Orders.Add(o1);
            dbcontext.Orders.Add(o2);
            dbcontext.Orders.Add(o3);
            dbcontext.Orders.Add(o4);
            dbcontext.SaveChanges();

            var products = dbcontext.Products.ToList();
            var orders = dbcontext.Orders.ToList();

            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var soso in orders)
            {
                Console.WriteLine(soso.address);
            }

            var product = dbcontext.Products.First(p => p.Id == 1);
            product.Name = "car";
            var order = dbcontext.Orders.First(o => o.Id == 1);
            order.address = "gaza";

            var product = dbcontext.Products.First(p => p.Id == 2);
            dbcontext.Products.Remove(product);

            var order = dbcontext.Orders.First(o => o.Id == 3);
            dbcontext.Orders.Remove(order);




        }
    }
}
