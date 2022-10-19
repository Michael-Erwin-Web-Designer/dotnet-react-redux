using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new List<Product>
            {
            new Product{Name="Kayak", Description="A boat for one person", Price=275, PictureUrl="https://www.kayak.com", Type="Watersports", Brand="Watersports", QuantityInStock=10},
            new Product{Name="Lifejacket", Description="Protective and fashionable", Price=48, PictureUrl="https://www.kayak.com", Type="Watersports", Brand="Watersports", QuantityInStock=10},
            new Product{Name="Soccer Ball", Description="FIFA-approved size and weight", Price=19, PictureUrl="https://www.kayak.com", Type="Soccer", Brand="Soccer", QuantityInStock=10},
            new Product{Name="Corner Flags", Description="Give your playing field a professional touch", Price=34, PictureUrl="https://www.kayak.com", Type="Soccer", Brand="Soccer", QuantityInStock=10},
            new Product{Name="Stadium", Description="Flat-packed 35,000-seat stadium", Price=79500, PictureUrl="https://www.kayak.com", Type="Soccer", Brand="Soccer", QuantityInStock=10},
            new Product{Name="Thinking Cap", Description="Improve your brain efficiency by 75%", Price=16, PictureUrl="https://www.kayak.com", Type="Chess", Brand="Chess", QuantityInStock=10},
            new Product{Name="Unsteady Chair", Description="Secretly give your opponent a disadvantage", Price=29, PictureUrl="https://www.kayak.com", Type="Chess", Brand="Chess", QuantityInStock=10},
            new Product{Name="Human Chess Board", Description="A fun game for the family", Price=75, PictureUrl="https://www.kayak.com", Type="Chess", Brand="Chess", QuantityInStock=10},
            new Product{Name="Bling-Bling King", Description="Gold-plated, diamond-studded King", Price=1200, PictureUrl="https://www.kayak.com", Type="Chess", Brand="Chess", QuantityInStock=10}
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}