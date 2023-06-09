﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data;

public partial class PracticeContext : DbContext
{
    public PracticeContext()
    {
    }

    public PracticeContext(DbContextOptions<PracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentsAuthor> DocumentsAuthors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CENVASSO\\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NumId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NumId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NumId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Category).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documents_Categories");
        });

        modelBuilder.Entity<DocumentsAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NumId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Author).WithMany(p => p.DocumentsAuthors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentsAuthors_Authors");

            entity.HasOne(d => d.Document).WithMany(p => p.DocumentsAuthors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentsAuthors_Documents");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}