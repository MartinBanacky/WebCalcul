﻿// <auto-generated />
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCalcul.Data;

#nullable disable

namespace WebCalcul.Migrations
{
    [DbContext(typeof(WebCalculDbContext))]
    [Migration("20240206144252_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 31);

            modelBuilder.Entity("WebCalcul.Data.CalculState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("MemoryActiveSign")
                        .HasColumnType("BOOLEAN");

                    b.Property<decimal>("NumberA")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<decimal>("NumberB")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1)");

                    b.Property<bool>("OperatorActiveSign")
                        .HasColumnType("BOOLEAN");

                    b.Property<bool>("PercentageIterationSign")
                        .HasColumnType("BOOLEAN");

                    b.Property<decimal>("Result")
                        .HasColumnType("DECIMAL(18,2)");

                    b.Property<bool>("ResultIterationSign")
                        .HasColumnType("BOOLEAN");

                    b.Property<bool>("RewriteInputSign")
                        .HasColumnType("BOOLEAN");

                    b.Property<bool>("SquareRootSign")
                        .HasColumnType("BOOLEAN");

                    b.HasKey("Id");

                    b.ToTable("CalculStates");
                });
#pragma warning restore 612, 618
        }
    }
}
