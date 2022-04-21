using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stroyka.Models
{
    public class StroykaDbContext:DbContext
    {

        public StroykaDbContext(DbContextOptions<StroykaDbContext> options):base(options){}
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<IndexSlider> IndexSliders { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubCategoryToProduct> SubCategoryToProducts { get; set; }
        public DbSet<ColorToProductDetail> ColorToProductDetails { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<MegaCategory> MegaCategories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Is Unique

            modelBuilder.Entity<Status>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Brand>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Material>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<SubCategory>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Color>()
               .HasIndex(x => x.Name)
               .IsUnique();

            modelBuilder.Entity<MegaCategory>()
               .HasIndex(x => x.Name)
               .IsUnique();

            // ================ Many To Many ==================
            // SubCategory To Prdouct
            modelBuilder.Entity<SubCategoryToProduct>()
                .HasKey(x => new { x.SubCategoryId, x.ProductId });

            modelBuilder.Entity<SubCategoryToProduct>()
                .HasOne(x => x.Product)
                .WithMany(x => x.SubCategoryToProducts)
                .HasForeignKey(x => x.ProductId);


            modelBuilder.Entity<SubCategoryToProduct>()
               .HasOne(x => x.SubCategory)
               .WithMany(x => x.SubCategoryToProducts)
               .HasForeignKey(x => x.SubCategoryId);

            // Color To ProductDetail
            modelBuilder.Entity<ColorToProductDetail>()
                .HasKey(x => new { x.ColorId, x.ProductDetailId });

            modelBuilder.Entity<ColorToProductDetail>()
                .HasOne(x => x.Color)
                .WithMany(x => x.ColorToProductDetails)
                .HasForeignKey(x => x.ColorId);


            modelBuilder.Entity<ColorToProductDetail>()
               .HasOne(x => x.ProductDetail)
               .WithMany(x => x.ColorToProductDetails)
               .HasForeignKey(x => x.ProductDetailId);


        }

    }
}
