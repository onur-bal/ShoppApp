using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }

                context.SaveChanges();
            }
        }

        private static readonly Category[] Categories =
        {
            new Category() {Name="Bilim Kurgu"},
            new Category() {Name="Kişisel Gelişim"}

        };

        private static readonly Product[] Products =
        {
            new Product(){Name="Yer Deniz Büyücüsü" , Price=25, ImageUrl="1.jpg"},
            new Product(){Name="En Uzak Sahil" , Price=25, ImageUrl="2.jpg"},
            new Product(){Name="Atuan Mezarlığı" , Price=25, ImageUrl="3.jpg"},
            new Product(){Name="Sır" , Price=25, ImageUrl="4.jpg"},
            new Product(){Name="Kınyas ve Kayra" , Price=25, ImageUrl="5.jpg"},
            

        };
    }
}
