using Microsoft.Data.SqlClient; // SqlConnectionStringBuilder
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics; // DbContext, DbContextOptionsBuilder

namespace Packt.Shared;

// this manages the connection to database
public class Northwind : DbContext
{
    // these properties map to tables in the database
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SqlConnectionStringBuilder builder = new();

        builder.DataSource = "."; // "ServerName\InstanceName" e.g. @".\sqlexpress"
        builder.InitialCatalog = "Northwind";
        builder.IntegratedSecurity = true;
        builder.TrustServerCertificate = true;
        builder.MultipleActiveResultSets = true;
        builder.ConnectTimeout = 3; // Because we want to fail fast. Default is 15 seconds.

        string? connection = builder.ConnectionString;

        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Connection: {connection}");
        ForegroundColor = previousColor;

        optionsBuilder.UseSqlServer(connection);

        optionsBuilder.LogTo(WriteLine, // Console
            new[] { RelationalEventId.CommandExecuting })
            .EnableSensitiveDataLogging();

        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // example of using Fluent API instead of attributes
        modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired() // NOT NULL
            .HasMaxLength(15);

        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            // added to "fix" the lack of decimal support in SQLite
            modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();
        }

        // global filter to remove discontinued products
        modelBuilder.Entity<Product>()
            .HasQueryFilter(p => !p.Discontinued);
    }
}