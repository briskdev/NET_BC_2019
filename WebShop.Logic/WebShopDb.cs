using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class WebShopDb : DbContext
    {
        public WebShopDb(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
