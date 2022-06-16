using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models.Blogs;
using Stroyka.Models.Commoun;
using Stroyka.Models.Products;
using Stroyka.Models.Users;
using Stroyka.Models.SqlViews.Products;
using Stroyka.Models.SqlFuncion;
using System.ComponentModel.DataAnnotations.Schema;
using Stroyka.Models.Sales;

namespace Stroyka.Data
{
    public class StroykaDbContext: IdentityDbContext<User>
    {

        public StroykaDbContext(DbContextOptions<StroykaDbContext> options):base(options){}

        // Using Praduct Class
        #region Product
        public DbSet<Models.Products.Status> ProductStatuses { get; set; }
        public DbSet<Brand> ProductBrands { get; set; }
        public DbSet<Material> ProductMaterials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> ProductColors { get; set; }
        public DbSet<Models.Products.Category> ProductCategories { get; set; }
        public DbSet<Models.Products.SubCategory> ProductSubCategories { get; set; }
        public DbSet<SubCategoryToProduct> SubCategoryToProducts { get; set; }
        public DbSet<Review> ProductReviews { get; set; }
        public DbSet<MegaCategory> ProductMegaCategories { get; set; }
        public DbSet<Models.Products.Detail> ProductDetails { get; set; }
        public DbSet<Image> ProductImages { get; set; }
        public DbSet<Stock> ProductStock { get; set; }
        #endregion

        // Using Blog Class
        #region Blog
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Models.Blogs.Category> BlogCategories { get; set; }
        public DbSet<Models.Blogs.SubCategory> BlogSubCategories { get; set; }
        public DbSet<BlogToTag> BlogToTags { get; set; }
        public DbSet<Models.Blogs.Detail> BlogDetails { get; set; }
        public DbSet<Comment> BlogComments { get; set; }
        public DbSet<Tag> BlogTags { get; set; }
        #endregion

        // Using Commoun Class
        #region Commoun
        public DbSet<EmailForSubscribe> EmailForSubscribes { get; set; }
        public DbSet<IndexSlider> IndexSliders { get; set; }
        #endregion

        // =============== Sql Views
        #region SqlViews

        
        public DbSet<BrandStock> BrandStocks { get; set; }

        public DbSet<CategoryProductCount> CategoryProductCounts { get; set; }

        #endregion


        // =============== Sql Funcition
        #region Sql Funcition
        [NotMapped]
        public DbSet<MaxMinPriceByMegaCategory> MaxMinPriceByMegaCategories { get; set; }

        #endregion

        // Sale
        #region Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Stroyka.Models.Sales.Status> PaymentStatuses { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Product
            // Is Unique
            modelBuilder.Entity<Stroyka.Models.Products.Status>()
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

            modelBuilder.Entity<Models.Products.SubCategory>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Models.Products.Category>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Color>()
               .HasIndex(x => x.Name)
               .IsUnique();

            modelBuilder.Entity<Color>()
               .HasIndex(x => x.Code)
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

            // Color Metrail Product Table
            modelBuilder.Entity<Stock>()
                .HasKey(x => new { x.ColorId, x.ProductId,x.MaterialId });

            modelBuilder.Entity<Stock>()
                .HasOne(x => x.Color)
                .WithMany(x => x.Stocks)
                .HasForeignKey(x => x.ColorId);


            modelBuilder.Entity<Stock>()
               .HasOne(x => x.Product)
               .WithMany(x => x.Stocks)
               .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Stock>()
               .HasOne(x => x.Material)
               .WithMany(x => x.Stocks)
               .HasForeignKey(x => x.MaterialId);

            #endregion

            #region Blog
            modelBuilder.Entity<Blog>()
               .Property(b => b.Date)
               .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Comment>()
               .Property(b => b.Date)
               .HasDefaultValueSql("getdate()");

            //Unique Key
            modelBuilder.Entity<Models.Blogs.Category>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<Tag>()
                .HasIndex(u => u.Name)
                .IsUnique();


            // Many To Many
            modelBuilder.Entity<BlogToTag>()
                .HasKey(x => new { x.TagId, x.BlogId });

            modelBuilder.Entity<BlogToTag>()
                .HasOne(x => x.Tag)
                .WithMany(y => y.BlogToTags)
                .HasForeignKey(fk => fk.TagId);

            modelBuilder.Entity<BlogToTag>()
                .HasOne(x => x.Blog)
                .WithMany(y => y.BlogToTags)
                .HasForeignKey(fk => fk.BlogId);
            #endregion

            #region Commoun
            modelBuilder.Entity<EmailForSubscribe>()
                .HasIndex(e => e.Email)
                .IsUnique();
            #endregion


            #region SqlViews

          
            modelBuilder.Entity<BrandStock>(dr =>
            {
                dr.HasKey("Id");
                dr.ToView("BrandStock");
            });

            modelBuilder.Entity<CategoryProductCount>(dr =>
            {
                dr.HasKey("Id");
                dr.ToView("CategoryProductCount");
            });
            #endregion

            #region Sql Function 

            modelBuilder.Entity<MaxMinPriceByMegaCategory>(dr =>
            {
                dr.HasKey("Id");
                dr.ToView("udfMinMaxPriceByMegaCategory");
            });
                
                

            #endregion
        }

    }
}
