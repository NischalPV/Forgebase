using System;
using Microsoft.EntityFrameworkCore;

namespace Forgebase.Masterdata.Infrastructure.Data
{
    public class ForgebaseMasterdataDbContext: DbContext
    {
        public ForgebaseMasterdataDbContext(DbContextOptions<ForgebaseMasterdataDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //MasterData.Seed(builder);
        }

        public DbSet<Core.Entities.Material.ColorCode> ColorCodes { get; set; }
        public DbSet<Core.Entities.Material.Unit> Units { get; set; }
        public DbSet<Core.Entities.Material.Manufacturer> Manufacturers { get; set; }
    }
}
