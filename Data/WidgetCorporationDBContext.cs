﻿using Microsoft.EntityFrameworkCore;
using WidgetCorporation.Models;

namespace WidgetCorporation.Data
{
    public class WidgetCorporationDBContext : DbContext
    {
        public WidgetCorporationDBContext(DbContextOptions<WidgetCorporationDBContext> options)
            : base(options)
        {
        }

        public DbSet<WidgetCorporation.Models.Product> Product { get; set; }
        public DbSet<WidgetCorporation.Models.Customer> Customer { get; set; }
        public DbSet<WidgetCorporation.Models.Login> Login { get; set; }
        public DbSet<WidgetCorporation.Models.Cart> Cart { get; set; }
        public DbSet<WidgetCorporation.Models.CartDetails> CartDetails { get; set; }

    }
}
