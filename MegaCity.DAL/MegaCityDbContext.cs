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
        public DbSet<AdminDto> Admins { get; set; }

        public DbSet<CashboxDto> Cashboxes { get; set; }

        public DbSet<CheckDto> Checks { get; set; }

        public DbSet<FilialDto> Filials { get; set; }

        public DbSet<ManagerDto> Managers { get; set; }

        public DbSet<OrderDto> Orders { get; set; }

        public DbSet<PromotionDto> Promotions { get; set; }

        public DbSet<SpoiledProductsAndGoodsDto> SpoiledProductsAndGoods { get; set; }

        public DbSet<StatisticsDto> Statistics { get; set; }

    }
}
