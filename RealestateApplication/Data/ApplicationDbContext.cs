using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealestateApplication.Models;
using RealestateApplication.Models.Images;
using RealestateApplication.Models.PropertyType;

namespace RealestateApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Home> Homes { get; set; }
        public DbSet<Images> Images { get; set; }

    }
}
