using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LADCH_.AppMVC.Models;

public partial class LadchdbContext : DbContext
{
    public LadchdbContext()
    {
    }

    public LadchdbContext(DbContextOptions<LadchdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Jugadores> Jugadores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOP-BAG1AMM3;Database=LADCHDB;Trusted_Connection=True; Trust Server Certificate=true");
     }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Jugadores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jugadores__3214EC071B38E333");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Posicion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
