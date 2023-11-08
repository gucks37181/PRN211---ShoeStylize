using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Data.Models
{
    public partial class ShoesStylizeContext : DbContext
    {
        public ShoesStylizeContext()
        {
        }

        public ShoesStylizeContext(DbContextOptions<ShoesStylizeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CustomizeShoe> CustomizeShoes { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Shoe> Shoes { get; set; }
        public virtual DbSet<SizeList> SizeLists { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = config["ConnectionStrings:ShoesStylize"];

            return strConn;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__BlogPost__AA126038599AEF9A");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.PostDay).HasColumnType("date");

                entity.Property(e => e.Title).HasMaxLength(30);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__BlogPosts__UserI__38996AB5");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.ShoeId).HasColumnName("ShoeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Shoe)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ShoeId)
                    .HasConstraintName("FK__Comment__ShoeID__398D8EEE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Comment__UserID__3A81B327");
            });

            modelBuilder.Entity<CustomizeShoe>(entity =>
            {
                entity.HasKey(e => e.CusShoeId)
                    .HasName("PK__Customiz__308DFC6FBFCC6974");

                entity.Property(e => e.CusShoeId).HasColumnName("CusShoeID");

                entity.Property(e => e.CustomizationDetails).HasColumnType("text");

                entity.Property(e => e.ShoeId).HasColumnName("ShoeID");

                entity.Property(e => e.ShoesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Shoe)
                    .WithMany(p => p.CustomizeShoes)
                    .HasForeignKey(d => d.ShoeId)
                    .HasConstraintName("FK__Customize__ShoeI__3B75D760");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomizeShoes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Customize__UserI__3C69FB99");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.FeedbackType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShoeId).HasColumnName("ShoeID");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Shoe)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.ShoeId)
                    .HasConstraintName("FK__Feedback__ShoeID__3D5E1FD2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Feedback__UserID__3E52440B");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.CusShoeId).HasColumnName("CusShoeID");

                entity.Property(e => e.ImageLink).IsUnicode(false);

                entity.HasOne(d => d.CusShoe)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.CusShoeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Image__CusShoeID__44FF419A");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserID__4222D4EF");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.CusShoeId).HasColumnName("CusShoeID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShoeId).HasColumnName("ShoeID");

                entity.HasOne(d => d.CusShoe)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.CusShoeId)
                    .HasConstraintName("FK__OrderDeta__CusSh__3F466844");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__403A8C7D");

                entity.HasOne(d => d.Shoe)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ShoeId)
                    .HasConstraintName("FK__OrderDeta__ShoeI__412EB0B6");
            });

            modelBuilder.Entity<Shoe>(entity =>
            {
                entity.Property(e => e.ShoeId).HasColumnName("ShoeID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Size)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Shoes)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Shoes__BrandID__4316F928");

                entity.HasOne(d => d.SizeNavigation)
                    .WithMany(p => p.Shoes)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK__Shoes__SizeID__440B1D61");
            });

            modelBuilder.Entity<SizeList>(entity =>
            {
                entity.HasKey(e => e.SizeId)
                    .HasName("PK__SizeList__83BD095ADD393124");

                entity.ToTable("SizeList");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.Size)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__A9D105341A6957B0")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FullName).HasMaxLength(20);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RoleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
