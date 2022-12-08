using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAPI_CodeFirstRevereseSample.Models;

namespace WebAPI_CodeFirstRevereseSample.Data;

public partial class WebApiNet7WithControllersDataContext : DbContext
{
    public WebApiNet7WithControllersDataContext()
    {
    }

    public WebApiNet7WithControllersDataContext(DbContextOptions<WebApiNet7WithControllersDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAPI_NET7_withControllers.Data;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.Property(e => e.ImdbRating).HasColumnName("IMDB_RAting");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
