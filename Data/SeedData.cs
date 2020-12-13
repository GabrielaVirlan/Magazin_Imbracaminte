using MagazinImbracaminte.Data;
using MagazinImbracaminte.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MagazinImbracaminteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MagazinImbracaminteContext>>());
            // Look for any movies.
            if (context.Users.Any() && context.Roles.Any() && context.Products.Any() && context.ProductDetailss.Any() && context.UserRoles.Any())
            {
                return;   // DB has been seeded
            }

            context.Roles.AddRange(
                new Role
                {
                    Name = "Utilizator"
                },

                new Role
                {
                    Name = "Administrator"
                },

                new Role
                {
                    Name = "Guest"
                }
            );

            context.UserRoles.AddRange(
                new UserRole
                {
                    Roles = new List<Role>
                    {
                        new Role {Name = "Utilizator"}
                    }
                },

                new UserRole
                {
                    Roles = new List<Role>
                    {
                        new Role { Name = "Administrator"},
                        new Role { Name = "Utilizator"}
                    }
                },

                new UserRole
                {
                    Roles = new List<Role>
                    {
                        new Role { Name = "Guest"},
                    }
                },

                new UserRole
                {
                    Roles = new List<Role>
                    {
                        new Role { Name = "Administrator"},
                    }
                }

            );


            context.Users.AddRange(
                new User
                {
                    FirstName = "Ana",
                    LastName = "Aanei",
                    PhoneNumber = "0711111111",
                    EmailAdress = "AaneiAna@gmail.com",
                    Passworld = "anaana",
                    UserRole = new UserRole
                    {
                        Roles = new List<Role>
                        {
                            new Role { Name = "Administrator"},
                            new Role { Name = "Utilizator"}
                        }
                    }
                },

                new User
                {
                    FirstName = "Bianca",
                    LastName = "Banisor",
                    PhoneNumber = "0722222222",
                    EmailAdress = "BiancaBanisor@gmail.com",
                    Passworld = "biancabianca",
                    UserRole = new UserRole
                    {
                        Roles = new List<Role>
                        {
                            new Role { Name = "Utilizator"}
                        }
                    }
                }
            );

            context.ProductDetailss.AddRange(
                new ProductDetails
                {
                    Size = "M",
                    Material = "In",
                    Color = "Crem"
                },

                new ProductDetails
                {
                    Size = "S",
                    Material = "Bumbac",
                    Color = "Portocaliu"
                },

                new ProductDetails
                {
                    Size = "L",
                    Material = "Bumbac",
                    Color = "Roz"
                },
                
                new ProductDetails
                {
                    Size = "42",
                    Material = "Blug",
                    Color = "Albastru"
                },

                new ProductDetails
                {
                    Size = "S",
                    Material = "In",
                    Color = "Galben"
                },

                new ProductDetails
                {
                    Size = "S",
                    Material = "Vascoza",
                    Color = "Verde"
                },

                new ProductDetails
                {
                    Size = "XL",
                    Material = "Bumbac",
                    Color = "Visiniu"
                },

                new ProductDetails
                {
                    Size = "38-42",
                    Material = "Bumbac Organic",
                    Color = "Model Banane"
                },

                new ProductDetails
                {
                    Size = "42 - 48",
                    Material = "Bumbac Organic",
                    Color = "Model Craciun"
                }
            );

            context.Products.AddRange(
                new Product
                {
                    Name = "Bluza Crem",
                    InStock = true,
                    Price = 89.99f,
                    Image = Image.FromFile("Bluza_Crerm.jpg"),
                    QuantityInStock = 10,
                    ProductDetails = new ProductDetails
                    {
                        Size = "M",
                        Material = "In",
                        Color = "Crem"
                    }

                },

                new Product
                {
                    Name = "Bluza Portocalie",
                    InStock = true,
                    Price = 79.99f,
                    Image = Image.FromFile("Bluza_Portocalie.jpg"),
                    QuantityInStock = 6,
                    ProductDetails = new ProductDetails
                    {
                        Size = "S",
                        Material = "Bumbac",
                        Color = "Portocaliu"
                    }
                },

                new Product
                {
                    Name = "Bluza Roz",
                    InStock = true,
                    Price = 99.99f,
                    Image = Image.FromFile("Bluza_Roz.jpg"),
                    QuantityInStock = 3,
                    ProductDetails = new ProductDetails
                    {
                        Size = "L",
                        Material = "Bumbac",
                        Color = "Roz"
                    }
                },

                new Product
                {
                    Name = "Jeans Dama",
                    InStock = true,
                    Price = 99.99f,
                    Image = Image.FromFile("Jeans.jpg"),
                    QuantityInStock = 5,
                    ProductDetails = new ProductDetails
                    {
                        Size = "42",
                        Material = "Blug",
                        Color = "Albastru"
                    }
                },

                new Product
                {
                    Name = "Rochie Galbena",
                    InStock = true,
                    Price = 89.99f,
                    Image = Image.FromFile("Rochie_Galbena.jpg"),
                    QuantityInStock = 2,
                    ProductDetails = new ProductDetails
                    {
                        Size = "S",
                        Material = "In",
                        Color = "Galben"
                    }
                },

                new Product
                {
                    Name = "Rochie Roz",
                    InStock = true,
                    Price = 79.99f,
                    Image = Image.FromFile("Rochie_Roz.jpg"),
                    QuantityInStock = 1,
                    ProductDetails = new ProductDetails
                    {

                    }
                },

                new Product
                {
                    Name = "Rochie Verde",
                    InStock = false,
                    Price = 84.99f,
                    Image = Image.FromFile("Rochie_Verde.jpg"),
                    QuantityInStock = 0,
                    ProductDetails = new ProductDetails
                    {
                        Size = "L",
                        Material = "Bumbac",
                        Color = "Roz"
                    }
                },

                new Product
                {
                    Name = "Rochie Visinie",
                    InStock = false,
                    Price = 84.99f,
                    Image = Image.FromFile("Rochie_Visinie.jpg"),
                    QuantityInStock = 0,
                    ProductDetails = new ProductDetails
                    {
                        Size = "XL",
                        Material = "Bumbac",
                        Color = "Visiniu"
                    }
                },

                new Product
                {
                    Name = "Sosete Banane",
                    InStock = true,
                    Price = 19.99f,
                    Image = Image.FromFile("Sosete_Banane.jpg"),
                    QuantityInStock = 10,
                    ProductDetails = new ProductDetails
                    {
                        Size = "38-42",
                        Material = "Bumbac Organic",
                        Color = "Model Banane"
                    }
                },
                new Product
                {
                    Name = "Sosete Craciun",
                    InStock = true,
                    Price = 24.99f,
                    Image = Image.FromFile("Sosete_Craciun.jpg"),
                    QuantityInStock = 9,
                    ProductDetails = new ProductDetails
                    {
                        Size = "42 - 48",
                        Material = "Bumbac Organic",
                        Color = "Model Craciun"
                    }
                }
            );

            context.SaveChanges();
        }
    }
}