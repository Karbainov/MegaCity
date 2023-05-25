using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

namespace MegaCity.DAL
{
    public class MegaCityDbContext:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "MegaCityDb");
        }

        public DbSet<GoodsDto> Goods { get; set; }

        public DbSet<ProductDto> Products { get; set; }

        public DbSet<ComponentDto> Components { get; set; }

        public DbSet<StorageChangeDto> StorageChanges { get; set; }

        public DbSet<OrderDto> Orders { get; set; }

        public DbSet<OrderPositionDto> OrderPositions { get; set; }

        public DbSet<StorageChangePositionDto> StorageChangePositions { get; set; }

        public DbSet<UserDto> Users { get; set; }

    }
}
