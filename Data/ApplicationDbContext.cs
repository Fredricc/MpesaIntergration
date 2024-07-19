using Microsoft.EntityFrameworkCore;
using MpesaIntergration.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MpesaIntergration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<MpesaC2B> MpesaC2Bs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}