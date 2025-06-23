using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SS_Desktop.Models;

namespace SS_Desktop.Libraries.Context
{
    public class AppContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=localhost;Database=SessionNumber1;User Id=sa;Password=sql;TrustServerCertificate=true"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<ItemAmenity> ItemAmenities { get; set; }
        public DbSet<ItemAttraction> ItemAttractions { get; set; }
        public DbSet<ItemPicture> ItemPictures { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.HasKey(u => u.Id).HasName("ID");
                user.Property(u => u.Id).IsRequired().HasColumnType("bigint");
                user.Property(u => u.Guid).IsRequired().HasColumnType("uniqueidentifier");
                user.Property(u => u.UserName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
                user.Property(u => u.FullName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
                user.Property(u => u.Password).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
                user.HasOne(u => u.UserType).WithMany().HasForeignKey(u => u.UserTypeId);
                user.Property(u => u.Gender).IsRequired().HasColumnType("bit");
            });
            modelBuilder.Entity<UserType>(user =>
            {
                user.HasKey(u => u.Id).HasName("ID");
                user.Property(u => u.Guid).IsRequired().HasColumnType("uniqueidentifier");
                user.Property(u => u.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            });
            modelBuilder.Entity<Area>(area =>
            {
                area.HasKey(a => a.Id).HasName("ID");
                area.Property(a => a.Guid).IsRequired().HasColumnType("uniqueidentifier");
            });
            modelBuilder.Entity<Amenity>(amenity =>
            {
                amenity.HasKey(a => a.Id).HasName("ID");
                amenity.Property(a => a.Guid).IsRequired().HasColumnType("uniqueidentifier");
            });
            modelBuilder.Entity<Attraction>(attraction =>
            {
                attraction.HasKey(a => a.Id).HasName("ID");
                attraction.Property(a => a.Guid).IsRequired().HasColumnType("uniqueidentifier");
                attraction.Property(a => a.Name).IsRequired().HasMaxLength(150).HasColumnType("varchar(150)");
                attraction.Property(a => a.Address).IsRequired().HasMaxLength(500).HasColumnType("varchar(500)");
                attraction.HasOne(a => a.Area).WithMany().HasForeignKey(a => a.AreaId);
            });
            modelBuilder.Entity<ItemAmenity>(ia =>
            {
                ia.HasKey(a => a.Id).HasName("ID");
                ia.Property(i => i.Guid).IsRequired().HasColumnType("uniqueidentifier");
                ia.HasOne(i => i.Item).WithMany().HasForeignKey(i => i.ItemId);
                ia.HasOne(i => i.Amenity).WithMany().HasForeignKey(i => i.AmenityId);
            });
            modelBuilder.Entity<ItemAttraction>(ia =>
            {
                ia.HasKey(a => a.Id).HasName("ID");
                ia.Property(i => i.Guid).IsRequired().HasColumnType("uniqueidentifier");
                ia.HasOne(i => i.Item).WithMany().HasForeignKey(i => i.ItemId);
                ia.HasOne(i => i.Attraction).WithMany().HasForeignKey(i => i.AttractionId);
                ia.Property(i => i.Distance).HasColumnType("decimal(5,1)").HasDefaultValue(0.0m);
            });
            modelBuilder.Entity<ItemPicture>(ip =>
            {
                ip.HasKey(a => a.Id).HasName("ID");
                ip.Property(i => i.Guid).IsRequired().HasColumnType("uniqueidentifier");
                ip.HasOne(i => i.Item).WithMany().HasForeignKey(i => i.ItemId);
                ip.Property(i => i.PictureFileName).HasColumnType("varchar(500)");
            });
            modelBuilder.Entity<Item>(i =>
            {
                i.HasKey(i => i.Id).HasName("ID");
                i.Property(i => i.Guid).IsRequired().HasColumnType("uniqueidentifier");
                i.HasOne(i => i.User).WithMany().HasForeignKey(i => i.UserId);
                i.HasOne(i => i.ItemType).WithMany().HasForeignKey(i => i.ItemTypeId);
                i.HasOne(i => i.Area).WithMany().HasForeignKey(i => i.AreaId);
                i.Property(i => i.ExactAddress).HasColumnType("varchar(500)");
                i.Property(i => i.ApproximateAddress).HasColumnType("varchar(250)");
                i.Property(i => i.Description).HasColumnType("varchar(2000)");
                i.Property(i => i.HostRules).HasColumnType("varchar(2000)");
            }); 
            modelBuilder.Entity<ItemType>(it =>
            {
                it.HasKey(a => a.Id).HasName("ID");
                it.Property(i => i.Guid).IsRequired().HasColumnType("uniqueidentifier");
            });
        }
    }
}
