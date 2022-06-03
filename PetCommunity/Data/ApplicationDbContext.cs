using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PetCommunity.Models;
using Microsoft.AspNetCore.Identity;

namespace PetCommunity.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PetCommunity.Models.Product> Product { get; set; }
        public DbSet<PetCommunity.Models.MissingNotice> MissingNotice { get; set; }
        public DbSet<PetCommunity.Models.PetAdoption> PetAdoption { get; set; }
        public DbSet<PetCommunity.Models.Solidarity> Solidarity { get; set; }
    }
}
