using Microsoft.EntityFrameworkCore;
using ShopMaker.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMaker.Infrastructure.Data.Context
{
    public class ShopMakerDbContext : DbContext
    {
        public ShopMakerDbContext(DbContextOptions<ShopMakerDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<UserDocument> UserDocuments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

    }
}
