using ShoppingApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.EFRepositories
{
    public class DBInitializer
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.CatalogBrands.Any())
            {
                context.CatalogBrands.AddRange(GetPreconfiguredCatalogBrands());
                await context.SaveChangesAsync();
            }
            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreconfiguredCatalogTypes());
                await context.SaveChangesAsync();
            }
            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreconfiguredItems());
                await context.SaveChangesAsync();
            }
        }

        static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
             {
                 new CatalogBrand() { BrandName = "Addidas" },
                 new CatalogBrand() { BrandName = "Puma" },
                 new CatalogBrand() { BrandName = "Nike" }
             };
        }

        static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
             {
                 new CatalogType() { Types = "Running" },
                 new CatalogType() { Types = "Basketball" },
                 new CatalogType() { Types = "Tennis" }
             };
        }

        static IEnumerable<CatalogItem> GetPreconfiguredItems()
        {
            return new List<CatalogItem>()
             {
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 3,
                     Description = "Shoes for next century",
                     Name = "World Star",
                     Price = 199.5M
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 1,
                     CatalogBrandId = 2,
                     Description = "Will make you world champions",
                     Name = "White Line",
                     Price = 88.50M
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 3,
                     Description = "You have already won gold medal",
                     Name = "Prism White Shoes",
                     Price = 129
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 2,
                     Description = "Olympic runner",
                     Name = "Foundation Hitech",
                     Price = 12
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 1,
                     Description = "Roslyn Red Sheet",
                     Name = "Roslyn White",
                     Price = 188.5M
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 2,
                     Description = "Lal Land",
                     Name = "Blue Star",
                     Price = 112
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 1,
                     Description = "High in the sky",
                     Name = "Roslyn Green",
                     Price = 212
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 1,
                     CatalogBrandId = 1,
                     Description = "Light as carbon",
                     Name = "Deep Purple",
                     Price = 238.5M
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 1,
                     CatalogBrandId = 2,
                     Description = "High Jumper",
                     Name = "Addidas<White> Running",
                     Price = 129
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 3,
                     Description = "Dunker",
                     Name = "Elequent",
                     Price = 12
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 1,
                     CatalogBrandId = 2,
                     Description = "All round",
                     Name = "Inredeible",
                     Price = 248.5M
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 2,
                     CatalogBrandId = 1,
                     Description = "Pricesless",
                     Name = "London Sky",
                     Price = 412
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 3,
                     CatalogBrandId = 3,
                     Description = "Tennis Star",
                     Name = "Elequent",
                     Price = 123
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 3,
                     CatalogBrandId = 2,
                     Description = "Wimbeldon",
                     Name = "London Star",
                     Price = 218.5M
                 },
                 new CatalogItem()
                 {
                     Picture = "demo.jpg",
                     CatalogTypeId = 3,
                     CatalogBrandId = 1,
                     Description = "Rolan Garros",
                     Name = "Paris Blues",
                     Price = 312
                 }
             };
        }
    }

}
