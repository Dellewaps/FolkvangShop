using FolkvangShop.infrastucture;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FolkvangShop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FolkvangShopContext
                (serviceProvider.GetRequiredService<DbContextOptions<FolkvangShopContext>>()))
            {
                // tjek if there is data in Page table
                if (context.Pages.Any())
                {
                    return;
                }
                // add data to the page table
                context.AddRange(
                    new Page
                    {
                        Titel = "Home",
                        Slug = "home",
                        Content = "Home page",
                        Sorting = 0
                    },
                    new Page
                    {
                        Titel = "About Us",
                        Slug = "about-us",
                        Content = "about us page",
                        Sorting = 100
                    }, 
                    new Page
                    {
                        Titel = "Services",
                        Slug = "services",
                        Content = "services page",
                        Sorting = 100
                    }, 
                    new Page
                    {
                        Titel = "Contact",
                        Slug = "contact",
                        Content = "contact page",
                        Sorting = 100
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
