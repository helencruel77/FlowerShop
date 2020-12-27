using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class FlowerShopDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Server = tcp:flowersshop.database.windows.net, 1433; Database = DatabaseFlowerShop; User ID = AdminFlowerShop; Password = 123321q!; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
                //не меняй это универсальный  Server=(local)\SQLEXPRESS;
                //твой универспльный мне выдает ошибку Server=DESKTOP-JHAI2OA;
                // ну ты выдумщица лен.......
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Flower> Flowers { set; get; }
        public virtual DbSet<Packaging> Packagings { set; get; }
        public virtual DbSet<Bouquet> Bouquets { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<FlowerBouquet> FlowerBouquets { set; get; }
        public virtual DbSet<PackagingBouquet> PackagingBouquets { set; get; }
        public virtual DbSet<Request> Requests { set; get; }
        public virtual DbSet<RequestFlowers> RequestsFlowers { set; get; }
        public virtual DbSet<Client> Clients { set; get; }

    }
}
