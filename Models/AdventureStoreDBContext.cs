using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoreApi.Models.Entities;

namespace StoreApi.Models;

public partial class AdventureStoreDBContext : DbContext
{
    public AdventureStoreDBContext()
    {
    }

    public AdventureStoreDBContext(DbContextOptions<AdventureStoreDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<IngresoSalidum> IngresoSalida { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<SalesPersonal> SalesPersonals { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SVR-HOME-WIN19\\SQLEXPRESSHOME;database=AdventureStore2024;User ID=sa;Password=HomeHome2024;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Address__CAA247C84ED9DCA6");

            entity.ToTable("Address");

            entity.Property(e => e.AddressId)
                .ValueGeneratedNever()
                .HasColumnName("address_id");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .HasColumnName("postal_code");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__D54EE9B4022C4692");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__CD65CB854FC044A7");

            entity.ToTable("Customer");

            entity.HasIndex(e => e.Email, "UQ__Customer__AB6E61642AB2F7B6").IsUnique();

            entity.HasIndex(e => e.Dni, "UQ__Customer__D87608A737182F6A").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("last_name");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("last_update");
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("store_id");
        });

        modelBuilder.Entity<DeliveryMethod>(entity =>
        {
            entity.HasKey(e => e.DeliveryMethodId).HasName("PK__Delivery__E4E8E5D28F601789");

            entity.Property(e => e.DeliveryMethodId)
                .ValueGeneratedNever()
                .HasColumnName("delivery_method_id");
            entity.Property(e => e.MethodName)
                .HasMaxLength(50)
                .HasColumnName("method_name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__C52E0BA86399F446");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("store_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Employee__person__5CD6CB2B");

            entity.HasOne(d => d.Store).WithMany(p => p.Employees)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__Employee__store___5DCAEF64");
        });

        modelBuilder.Entity<IngresoSalidum>(entity =>
        {
            entity.HasKey(e => e.IngresoSalidaId).HasName("PK__IngresoS__E099542D65D87F79");

            entity.Property(e => e.IngresoSalidaId)
                .ValueGeneratedNever()
                .HasColumnName("ingreso_salida_id");
            entity.Property(e => e.DateInOut).HasColumnName("date_in_out");
            entity.Property(e => e.TimeInOut).HasColumnName("time_in_out");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.IngresoSalida)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__IngresoSa__user___60A75C0F");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__46596229B0CAD49E");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DeliveryMethodId).HasColumnName("delivery_method_id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.SalesPersonalId).HasColumnName("sales_personal_id");
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("store_id");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("total_price");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Orders__customer__4D94879B");

            entity.HasOne(d => d.DeliveryMethod).WithMany(p => p.Orders)
                .HasForeignKey(d => d.DeliveryMethodId)
                .HasConstraintName("FK__Orders__delivery__5070F446");

            entity.HasOne(d => d.SalesPersonal).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SalesPersonalId)
                .HasConstraintName("FK__Orders__sales_pe__4E88ABD4");

            entity.HasOne(d => d.Store).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__Orders__store_id__4F7CD00D");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__OrderDet__3C5A4080140FDC25");

            entity.Property(e => e.OrderDetailId).HasColumnName("order_detail_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__order__4BAC3F29");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__OrderDeta__produ__4CA06362");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PK__PaymentM__8A3EA9EB1828ADD4");

            entity.Property(e => e.PaymentMethodId)
                .ValueGeneratedNever()
                .HasColumnName("payment_method_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.MethodName)
                .HasMaxLength(50)
                .HasColumnName("method_name");

            entity.HasOne(d => d.Customer).WithMany(p => p.PaymentMethods)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__PaymentMe__custo__5441852A");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Person__543848DFD82ACF44");

            entity.ToTable("Person");

            entity.HasIndex(e => e.Dni, "UQ__Person__D87608A7307AFB8E").IsUnique();

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("person_id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .HasColumnName("dni");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("last_update");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__47027DF56A67CF9C");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.ReleaseYear).HasColumnName("release_year");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Products__catego__5165187F");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Category).WithMany()
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__ProductCa__categ__5629CD9C");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductCa__produ__5535A963");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PK__Promotio__2CB9556BB205951E");

            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Product).WithMany(p => p.Promotions)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Promotion__produ__59063A47");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__60883D9082457AE0");

            entity.Property(e => e.ReviewId).HasColumnName("review_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Rating).HasColumnName("rating");

            entity.HasOne(d => d.Customer).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Reviews__custome__5812160E");

            entity.HasOne(d => d.Product).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Reviews__product__571DF1D5");
        });

        modelBuilder.Entity<SalesPersonal>(entity =>
        {
            entity.HasKey(e => e.SalesPersonalId).HasName("PK__SalesPer__4FF9999B8F7A6499");

            entity.ToTable("SalesPersonal");

            entity.Property(e => e.SalesPersonalId).HasColumnName("sales_personal_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("store_id");

            entity.HasOne(d => d.Store).WithMany(p => p.SalesPersonals)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__SalesPers__store__4AB81AF0");
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasKey(e => e.CartItemId).HasName("PK__Shopping__5D9A6C6E1689445C");

            entity.ToTable("ShoppingCart");

            entity.Property(e => e.CartItemId)
                .ValueGeneratedNever()
                .HasColumnName("cart_item_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__ShoppingC__custo__59FA5E80");

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ShoppingC__produ__5AEE82B9");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.StockId).HasName("PK__Stock__E8666862F43DA15A");

            entity.ToTable("Stock");

            entity.Property(e => e.StockId).HasColumnName("stock_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("store_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Stock__product_i__52593CB8");

            entity.HasOne(d => d.Store).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__Stock__store_id__534D60F1");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__Stores__A2F2A30C6CA4DB16");

            entity.Property(e => e.StoreId)
                .HasMaxLength(50)
                .HasColumnName("store_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.SalesPersonalId).HasColumnName("sales_personal_id");

            entity.HasOne(d => d.Address).WithMany(p => p.Stores)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK__Stores__address___5EBF139D");

            entity.HasOne(d => d.SalesPersonal).WithMany(p => p.Stores)
                .HasForeignKey(d => d.SalesPersonalId)
                .HasConstraintName("FK__Stores__sales_pe__5FB337D6");
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserAcco__B9BE370F38BB19A7");

            entity.HasIndex(e => e.Username, "UQ__UserAcco__F3DBC5727D231F8D").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Employee).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__UserAccou__emplo__5BE2A6F2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
