using Microsoft.EntityFrameworkCore;
using SuperMarketAPI.Models;
using System.Collections.Generic;

namespace SuperMarketAPI.Data
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }

    }
}