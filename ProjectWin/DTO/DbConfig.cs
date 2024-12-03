using System.Data.Entity;

namespace DTO
{
    public partial class DbConfig : DbContext
    {
        public DbConfig()
            : base("name=DbConfig")
        {
        }

        public virtual DbSet<About> abouts { get; set; }
        public virtual DbSet<CartItems> cart_items { get; set; }
        public virtual DbSet<Cart> carts { get; set; }
        public virtual DbSet<Category> categories { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<OrderItems> order_items { get; set; }
        public virtual DbSet<Order> orders { get; set; }
        public virtual DbSet<Policy> policies { get; set; }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<Rating> ratings { get; set; }
        public virtual DbSet<Slider> sliders { get; set; }
        public virtual DbSet<User> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItems>()
                .Property(e => e.total_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Cart>()
                .Property(e => e.total_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Category>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItems>()
                .Property(e => e.total_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.total_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
