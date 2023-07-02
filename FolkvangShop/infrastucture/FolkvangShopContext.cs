using FolkvangShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FolkvangShop.infrastucture
{
    public class FolkvangShopContext : DbContext
    {
        public FolkvangShopContext(DbContextOptions<FolkvangShopContext> options) :base(options)
            {
            }

        public DbSet<Page> Pages { get; set; }
    }
}
