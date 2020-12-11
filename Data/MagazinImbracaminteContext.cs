using MagazinImbracaminte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinImbracaminte.Data
{
    public class MagazinImbracaminteContext : DbContext
    {
        public MagazinImbracaminteContext(DbContextOptions<MagazinImbracaminteContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }
        public DbSet<ProductDetails> ProductDetailss { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public object User { get; internal set; }
    }
}
