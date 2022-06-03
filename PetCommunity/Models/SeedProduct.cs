using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PetCommunity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCommunity.Models
{
    public static class SeedProduct
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Product.Any())
                {
                    context.Product.AddRange(
                            //mama, yemek kabı, tasma, kum ve oyuncak
                            new Product() { Name = "Pro Plan", Description = "Pro Plan Okyanus Balıklı Kümes Hayvanlı Kısırlaştırılmış Kedi Maması 1kg", Category = "Kedi Maması", Price = 100 },
                            new Product() { Name = "Royal Canin", Description = "Canin Sensible 33 Hassas Sindirim Sistemli Kediler için Yetişkin Kedi Maması 400gr", Category = "Kedi Maması", Price = 50 },
                            new Product() { Name = "Enjoy", Description = "Kuzu Etli Pirinçli Yetişkin Köpek Maması 15 Kg", Category = "Köpek Maması", Price = 150 },
                            new Product() { Name = "Pro Plan", Description = "Puppy Sensitive Digeston Kuzu Etli Yavru Köpek Maması 12 Kg", Category = "Köpek Maması", Price = 375 },
                            new Product() { Name = "Pet Care", Description = "Evcil hayvanınız için su ve yemek kabı", Category = "Yemek Kabı", Price = 30 },
                            new Product() { Name = "Pet Care", Description = "Evcil hayvanınız için su ve yemek kabı", Category = "Yemek Kabı", Price = 25 },
                            new Product() { Name = "Pet Care", Description = "Kediniz için desenli tasma", Category = "Kedi Tasması", Price = 20 },
                            new Product() { Name = "Pet Care", Description = "Kediniz için desenli tasma", Category = "Kedi Tasması", Price = 25 },
                            new Product() { Name = "Pet Care", Description = "Köpeğiniz için desenli tasma", Category = "Köpek Tasması", Price = 20 },
                            new Product() { Name = "Pet Care", Description = "Köpeğiniz için desenli tasma", Category = "Köpek Tasması", Price = 25 },
                            new Product() { Name = "Lindo Cat", Description = "Bebek Parfümlü İnce Kedi Kumu 10 Lt", Category = "Kedi Kumu", Price = 25 },
                            new Product() { Name = "Proline", Description = "Marsilya Sabunlu Topaklaşan Kedi Kumu 10 Lt", Category = "Kedi Kumu", Price = 30 },
                            new Product() { Name = "Pet Care", Description = "Kediniz için oyuncak", Category = "Kedi Oyuncağı", Price = 20 },
                            new Product() { Name = "Pet Care", Description = "Kediniz için oyuncak", Category = "Kedi Oyuncağı", Price = 25 },
                            new Product() { Name = "Pet Care", Description = "Köpeğiniz için oyuncak", Category = "Köpek Oyuncağı", Price = 10 },
                            new Product() { Name = "Pet Care", Description = "Köpeğiniz için oyuncak", Category = "Köpek Oyuncağı", Price = 20 }

                            );

                    context.SaveChanges();
                }
            }
        }
    }
}



  

