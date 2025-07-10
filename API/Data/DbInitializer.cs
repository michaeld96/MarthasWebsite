using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        // Get rid of resource ASAP (using).
        using var scope = app.Services.CreateScope();
        // Get our context that is defined in our Program.cs.
        var context = scope.ServiceProvider.GetRequiredService<StoreContext>()
            ?? throw new InvalidOperationException("Failed to retrieve store context");

        SeedData(context);
    }

    private static void SeedData(StoreContext context)
    {
        // Applies updates and migrations to Db.
        context.Database.Migrate();

        if (context.Products.Any())
        {
            return;
        }

        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "First Art Piece",
                Description = "This is the first piece of test data",
                Price = (long)100.00,
                PictureUrl = "TODO",
                Type = "Oil"
            },
            new Product
            {
                Id = 2,
                Name = "Second Art Piece",
                Description = "A beautiful watercolor painting",
                Price = (long)150.00,
                PictureUrl = "TODO",
                Type = "Watercolor"
            },
            new Product
            {
                Id = 3,
                Name = "Third Art Piece",
                Description = "An abstract acrylic artwork",
                Price = (long)200.00,
                PictureUrl = "TODO",
                Type = "Acrylic"
            },
            new Product
            {
                Id = 4,
                Name = "Fourth Art Piece",
                Description = "A stunning charcoal sketch",
                Price = (long)75.00,
                PictureUrl = "TODO",
                Type = "Charcoal"
            },
            new Product
            {
                Id = 5,
                Name = "Fifth Art Piece",
                Description = "A vibrant digital illustration",
                Price = (long)300.00,
                PictureUrl = "TODO",
                Type = "Digital"
            }
        };
        context.Products.AddRange(products);
        context.SaveChanges();
    }
}
