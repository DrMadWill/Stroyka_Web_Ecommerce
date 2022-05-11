using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stroyka.Models.Blogs;
using Stroyka.Models.Commoun;
using Stroyka.Models.Products;
using Stroyka.Models.Users;

namespace Stroyka.Data
{
    public class StroykaDbContext: IdentityDbContext<User>
    {

        public StroykaDbContext(DbContextOptions<StroykaDbContext> options):base(options){}
        // Using Praduct Class
        #region Product
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<IndexSlider> IndexSliders { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Models.Products.Category> Categories { get; set; }
        public DbSet<Models.Products.SubCategory> SubCategories { get; set; }
        public DbSet<SubCategoryToProduct> SubCategoryToProducts { get; set; }
        public DbSet<ColorToProductDetail> ColorToProductDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MegaCategory> MegaCategories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        #endregion

        // Using Blog Class
        #region Blog
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Models.Blogs.Category> BlogCategories { get; set; }
        public DbSet<Models.Blogs.SubCategory> BlogSubCategories { get; set; }
        public DbSet<BlogToTag> BlogToTags { get; set; }
        public DbSet<Detail> BlogDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> BlogTags { get; set; }
        #endregion

        // Using Commoun Class
        #region Commoun
        public DbSet<EmailForSubscribe> EmailForSubscribes { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Product
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

            modelBuilder.Entity<Models.Products.SubCategory>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<Models.Products.Category>()
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

        }

    }
}
