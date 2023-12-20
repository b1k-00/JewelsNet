using CRUDops.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDops.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Wedding Bands" },
                new Category { Id = 2, Name = "Engagement Rings" },
                new Category { Id = 3, Name = "Diamonds" },
                new Category { Id = 4, Name = "Gemstones" },
                new Category { Id = 5, Name = "Metals" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Floral Band", Sku = "AWMGSJ", Price = 68, IsAvailable = true },
                new Product { Id = 2, CategoryId = 1, Name = "Accented Band", Sku = "AWMPS", Price = 35, IsAvailable = true },
                new Product { Id = 3, CategoryId = 1, Name = "Milgrain Flat Inlay Band", Sku = "AWMSGT", Price = 33, IsAvailable = true },
                new Product { Id = 4, CategoryId = 1, Name = "Art Deco Patterned Band", Sku = "AWMSJ", Price = 125, IsAvailable = true },
                new Product { Id = 5, CategoryId = 1, Name = "Eternity Band", Sku = "AWMTFJ", Price = 60, IsAvailable = true },
                new Product { Id = 6, CategoryId = 1, Name = "Bamboo Band", Sku = "AWMUTV", Price = 95, IsAvailable = true },
                new Product { Id = 7, CategoryId = 1, Name = "Floral Band", Sku = "AWMVNP", Price = 65, IsAvailable = true },
                new Product { Id = 8, CategoryId = 1, Name = "Anniversary Band", Sku = "AWMVNS", Price = 65, IsAvailable = true },
                new Product { Id = 9, CategoryId = 1, Name = "Flat Band", Sku = "AWMVNT", Price = 17, IsAvailable = true },
                new Product { Id = 10, CategoryId = 2, Name = "Diamond-Encrusted Ski Coat", Sku = "AWWBTSC", Price = 99, IsAvailable = true },
                new Product { Id = 11, CategoryId = 2, Name = "Eternal Love Training Tank", Sku = "AWWCTT", Price = 0, IsAvailable = false },
                new Product { Id = 12, CategoryId = 2, Name = "Sapphire Skater Jeans", Sku = "AWWGSJ", Price = 68, IsAvailable = true },
                new Product { Id = 13, CategoryId = 2, Name = "Platinum Slicker Jacket", Sku = "AWWSJ", Price = 125, IsAvailable = true },
                new Product { Id = 14, CategoryId = 2, Name = "Golden Dance Pants", Sku = "AWWSDP", Price = 55, IsAvailable = true },
                new Product { Id = 15, CategoryId = 2, Name = "Romantic Tank Top", Sku = "AWWUTT", Price = 22, IsAvailable = true },
                new Product { Id = 16, CategoryId = 2, Name = "Unisex Engagement Vest", Sku = "AWWUTV", Price = 95, IsAvailable = true },
                new Product { Id = 17, CategoryId = 2, Name = "Valentine's T-Shirt", Sku = "AWWVNT", Price = 17, IsAvailable = true },
                new Product { Id = 18, CategoryId = 3, Name = "Blue Moon Diamond Elixir", Sku = "MWB", Price = 2.8M, IsAvailable = true },
                new Product { Id = 19, CategoryId = 3, Name = "Pink Star Diamond Infusion", Sku = "MWLL", Price = 2.8M, IsAvailable = true },
                new Product { Id = 20, CategoryId = 3, Name = "Hope Diamond Essence", Sku = "MWO", Price = 2.8M, IsAvailable = true },
                new Product { Id = 21, CategoryId = 3, Name = "Regent Diamond Nectar", Sku = "MWP", Price = 2.8M, IsAvailable = true },
                new Product { Id = 22, CategoryId = 3, Name = "Koh-i-Noor Diamond Elixir", Sku = "MWR", Price = 2.8M, IsAvailable = true },
                new Product { Id = 23, CategoryId = 3, Name = "Orloff Diamond Euphoria", Sku = "MWS", Price = 2.8M, IsAvailable = true },
                new Product { Id = 24, CategoryId = 4, Name = "Gemini Gemstone", Sku = "PITK", Price = 24.99M, IsAvailable = true },
                new Product { Id = 25, CategoryId = 5, Name = "Calcium Platinum Supplement (150 tablets)", Sku = "SC400", Price = 9.99M, IsAvailable = true },
                new Product { Id = 26, CategoryId = 5, Name = "Gold Flaxseed Oil (90 capsules)", Sku = "SFO100", Price = 12.49M, IsAvailable = true },
                new Product { Id = 27, CategoryId = 5, Name = "Iron Chromium Caplets (150 caplets)", Sku = "SI65", Price = 13.99M, IsAvailable = true },
                new Product { Id = 28, CategoryId = 5, Name = "Magnesium Titanium Tablets (100 tablets)", Sku = "SM250", Price = 12.49M, IsAvailable = true },
                new Product { Id = 29, CategoryId = 5, Name = "Multi-Metallic Vitamin Capsules (90 capsules)", Sku = "SMV", Price = 9.99M, IsAvailable = true },
                new Product { Id = 30, CategoryId = 5, Name = "Vitamin A Silver Caplets (125 caplets)", Sku = "SVA", Price = 11.99M, IsAvailable = true },
                new Product { Id = 31, CategoryId = 5, Name = "Vitamin B-Complex Brass Caplets (100 caplets)", Sku = "SVB", Price = 12.99M, IsAvailable = true },
                new Product { Id = 32, CategoryId = 5, Name = "Vitamin C Copper Tablets (100 tablets)", Sku = "SVC", Price = 9.99M, IsAvailable = true },
                new Product { Id = 33, CategoryId = 5, Name = "Vitamin D3 Zinc Tablets (100 tablets)", Sku = "SVD3", Price = 12.49M, IsAvailable = true });
        }

    }
}